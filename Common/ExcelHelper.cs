using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Common.Attributes;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace Common
{
    public static class ExcelHelper
    {
        public static void DrawTable(this ISheet sheet, string cellRef, int columnWidth, string[][] data,
            BorderStyle borderStyle)
        {
            var reference = new CellReference(cellRef);
            var rowCount = reference.Row;
            var style = sheet.Workbook.CreateCellStyle();
            style.BorderTop = borderStyle;
            style.BorderLeft = borderStyle;
            style.BorderBottom = borderStyle;
            style.BorderRight = borderStyle;

            foreach (var dataRow in data)
            {
                var row = sheet.GetRow(rowCount) ?? sheet.CreateRow(rowCount);
                var cellCount = reference.Col;
                foreach (var item in dataRow)
                {
                    for (var i = 0; i < columnWidth; i++)
                    {
                        row.CreateCell(cellCount + i).CellStyle = style;
                    }
                    var cell = row.GetCell(cellCount);

                    var cra = new CellRangeAddress(rowCount, rowCount, cellCount, cellCount + columnWidth - 1);
                    sheet.AddMergedRegion(cra);
                    cell.SetCellValue(item);
                    cellCount += (short) columnWidth;
                }
                rowCount++;
            }
        }

        public static void GetTable<T>(IEnumerable<T> models, out string[] header, out string[][] body)
        {
            var props = GetProps<T>();

            header = props.Select(x =>
            {
                var attr = x.GetCustomAttributes(true).FirstOrDefault(y => y is DisplayNameAttribute);
                return attr != null ? ((DisplayNameAttribute) attr).DisplayName : x.Name;
            }).ToArray();

            body = models.Select(x => props.Select(y =>
            {
                var value = y.GetValue(x);
                if (value is bool)
                    return (bool) value ? "Да" : "Нет";
                return value?.ToString();
            }).ToArray()).ToArray();
        }

        private static List<PropertyInfo> GetProps<T>() => typeof (T).GetProperties()
            .Where(x => Attribute.IsDefined(x, typeof (PrintAttribute)))
            .ToList();
    }
}