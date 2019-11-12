using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed
{
    public static class Utility
    {
        public static string ReadString(this ExcelWorksheet sht, int row, int col) => sht.Cells[row, col].Value.ToString().Trim();

        public static int ReadInteger(this ExcelWorksheet sht, int row, int col) => int.Parse(sht.ReadString(row, col));

        public static DateTime ReadDate(this ExcelWorksheet sht, int row, int col)
        {
            var data = sht.Cells[row, col].Value;
            if (data == null) return DateTime.MinValue;
            return DateTime.Parse(data.ToString());
        }
        public static DateTime ReadDateValue(this ExcelWorksheet sht, int row, int col)
        {
            var data = sht.Cells[row, col].Value;
            if (data == null) return DateTime.MinValue;
            return DateTime.FromOADate(double.Parse(data.ToString()));
        }

        public static bool ReadBool(this ExcelWorksheet sht, int row, int col) => sht.ReadString(row, col) == "-1";

        public static decimal ReadDecimal(this ExcelWorksheet sht, int row, int col) => decimal.Parse(sht.ReadString(row, col));

        public static string SelectCity(this ExcelWorksheet sht, int row, int col)
        {
            string addr = sht.ReadString(row, col);
            string[] words = addr.Split(", ");
            return words[0];
        }
        public static string SelectCountry(this ExcelWorksheet sht, int row, int col)
        {
            string addr = sht.ReadString(row, col);
            string[] words = addr.Split(", ");
            return words[1];
        }


    }
}
