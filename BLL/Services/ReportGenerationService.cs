using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL.Contracts;
using BLL.Models;
using Common;
using CommonContracts;
using DalContracts.DishesToFoodstuffs;
using DalContracts.Foodstuff;
using DalContracts.MeasurementUnits;
using DAL;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace BLL.Services
{
    public class ReportGenerationService : ServiceBase, IReportGenerationService
    {
        public ReportGenerationService(IDalService dalService) : base(dalService)
        {
        }

        public async Task Generate(IEnumerable<DishCookModel> dishes, string path)
        {
            await Task.Factory.StartNew(() =>
            {
                string[] header;
                string[][] table;
                ExcelHelper.GetTable(CountFoodstuffs(dishes), out header, out table);

                var workbook = new XSSFWorkbook();
                var sheet = workbook.CreateSheet("report");
                sheet.DrawTable("A1", 1, new[] {header}, BorderStyle.Thin);
                sheet.DrawTable("A2", 1, table, BorderStyle.Thin);

                using (var fileData = new FileStream(path, FileMode.Create))
                {
                    workbook.Write(fileData);
                }


                Process.Start(path);
            });
        }

        private IEnumerable<FoodstuffPrintModel> CountFoodstuffs(IEnumerable<DishCookModel> dishes)
        {
            var foodstuffs = DalService.FormatOp(FoodstuffProcedures.Get, new Foodstuff()).ToList();
            var units = DalService.FormatOp(MeasurementUnitsProcedures.Get, new MeasurementUnit()).ToList();
            var foodstuffToDishes =
                DalService.FormatOp(DishesToFoodstuffsProcedures.Get, new DishesToFoodstuffs()).ToList();
            var list = dishes.SelectMany(x => foodstuffToDishes.Where(y => y.DishId == x.DishId).Select(y =>
                new KeyValuePair<int, decimal>(y.FoodstuffId, x.Count*y.Consumption))).GroupBy(x => x.Key).Select(x =>
                    new KeyValuePair<int, decimal>(x.Key, x.Sum(y => y.Value)));

            return list.Select(x =>
            {
                var foodstuff = foodstuffs.FirstOrDefault(y => y.FoodstuffId == x.Key);
                return new FoodstuffPrintModel
                {
                    Name = foodstuff?.Name,
                    MeasurementUnit =
                        units.FirstOrDefault(y => y.MeasurementUnitId == foodstuff?.MeasurementUnitId)?.Name,
                    Quantity = x.Value
                };
            });
        }
    }
}