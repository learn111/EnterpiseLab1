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

                var dishPrintModels = CountFoods(dishes).ToList();
                ExcelHelper.GetTable(dishPrintModels, out header, out table);

                var workbook = new XSSFWorkbook();
                var sheet = workbook.CreateSheet("report");
                sheet.DrawTable("A1", 1, new[] {header}, BorderStyle.Thin);
                sheet.DrawTable("A2", 1, table, BorderStyle.Thin);
                var row = sheet.GetRow(dishPrintModels.Count+1) ?? sheet.CreateRow(dishPrintModels.Count+1);
                row.CreateCell(2).SetCellValue("Всего");
                row.CreateCell(3).SetCellValue((double) dishPrintModels.Sum(x=>x.PriceTotal));
                using (var fileData = new FileStream(path, FileMode.Create))
                {
                    workbook.Write(fileData);
                }


                Process.Start(path);
            });
        }

        private IEnumerable<DishPrintModel> CountFoods(IEnumerable<DishCookModel> dishes)
        {
            var foodstuffs = DalService.FormatOp(FoodstuffProcedures.Get, new Foodstuff()).ToList();
            var units = DalService.FormatOp(MeasurementUnitsProcedures.Get, new MeasurementUnit()).ToList();
            var foodstuffToDishes =
                DalService.FormatOp(DishesToFoodstuffsProcedures.Get, new DishesToFoodstuffs()).ToList();
            return dishes.Select(x => new DishPrintModel
            {
                Count = x.Count,
                Name = x.DishName,
                PriceSingle =
                    foodstuffToDishes.Where(y => y.DishId == x.DishId)
                        .Sum(y => y.Consumption*foodstuffs.First(z => z.FoodstuffId == y.FoodstuffId).Price)
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