using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.IO;

namespace ExportBookBorrowingData
{
    public class ExportExcelFile
    {
        /// <summary>
        /// Excel导出
        /// </summary>
        /// <param name="path">导出路径，绝对路径(C:/myexcel.xlsx)</param>
        /// <param name="dt">数据源</param>
        /// <param name="TitleName">标题名</param>
        /// <returns></returns>
        public static bool ExportFile(string path, DataTable dt, string TitleName,string SheetName)
        {
            FileStream fs = null;
            try
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet(SheetName);

                int rowCount = dt.Rows.Count;
                int columnCount = dt.Columns.Count;

                ICell cell = null;
                IRow row = null;
                SetTitle(workbook, sheet, row, cell, columnCount, TitleName);
                SetCellTitle(dt, workbook, sheet, row, cell, columnCount);
                SetRowsAndCells(dt, workbook, sheet, row, cell, rowCount, columnCount);
                if (WritingExcel(path, workbook, fs)) return true;
                return false;
            }
            catch (Exception ex)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return false;
            }
        }

        // 设置标题
        private static void SetTitle(IWorkbook workbook, ISheet sheet, IRow row, ICell cell, int columnCount, string titleName)
        {
            try
            {
                row = sheet.CreateRow(0);
                cell = row.CreateCell(0);
                IFont font = workbook.CreateFont();
                // 合并单元格
                sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, columnCount-1));
                ICellStyle style = workbook.CreateCellStyle();
                font.FontName = "等线";
                font.Color = 0;
                font.FontHeightInPoints = 22;
                font.IsBold = true;
                style.Alignment = HorizontalAlignment.CenterSelection;
                style.SetFont(font);
                style.BorderBottom = BorderStyle.Thin;
                style.BorderTop = BorderStyle.Thin;
                style.BorderLeft = BorderStyle.Thin;
                style.BorderRight = BorderStyle.Thin;
                cell.CellStyle = style;
                cell.SetCellValue(titleName);
            }
            catch (Exception ex) { throw ex; }
        }

        // 设置列头
        private static void SetCellTitle(DataTable dt, IWorkbook workbook, ISheet sheet, IRow row, ICell cell, int columnCount)
        {
            try
            {
                // 设置格式
                ICellStyle style = workbook.CreateCellStyle();
                IFont font = workbook.CreateFont();
                font.FontName = "等线";
                font.Color = 0;
                font.FontHeightInPoints = 18;
                style.Alignment = HorizontalAlignment.CenterSelection;
                style.SetFont(font);
                style.BorderBottom = BorderStyle.Thin;
                style.BorderTop = BorderStyle.Thin;
                style.BorderLeft = BorderStyle.Thin;
                style.BorderRight = BorderStyle.Thin;

                row = sheet.CreateRow(1);
                row.Height = 400;
                for (int c = 0; c < columnCount; c++)
                {
                    cell = row.CreateCell(c);
                    cell.SetCellValue(dt.Columns[c].ColumnName);
                    cell.CellStyle = style;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        // 设置每行每列
        private static void SetRowsAndCells(DataTable dt, IWorkbook workbook, ISheet sheet, IRow row, ICell cell, int rowCount, int columnCount)
        {
            try
            {
                // 设置格式
                ICellStyle style = workbook.CreateCellStyle();
                IFont font = workbook.CreateFont();
                font.FontName = "等线";
                font.Color = 0;
                font.FontHeightInPoints = 11;
                style.SetFont(font);
                style.BorderBottom = BorderStyle.Thin;
                style.BorderTop = BorderStyle.Thin;
                style.BorderLeft = BorderStyle.Thin;
                style.BorderRight = BorderStyle.Thin;

                for (int i = 0; i < rowCount; i++)
                {
                    row = sheet.CreateRow(i+2);
                    row.Height = 420;
                    for (int j = 0; j < columnCount; j++)
                    {
                        cell = row.CreateCell(j);
                        cell.SetCellValue(dt.Rows[i][j].ToString());
                        cell.CellStyle = style;
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        // 导出
        private static bool WritingExcel(string path, IWorkbook workbook, FileStream fs)
        {
            try
            {
                using (fs = File.OpenWrite(path))
                {
                    workbook.Write(fs);
                    return true;
                }
            }
            catch (Exception ex) { return false; }
        }
    }
}