
using System;
using System.Collections.Generic;

namespace ExportBookBorrowingData
{
    // 借还日期约束处理
    public class DateConstraint
    {
        static List<string> _Offdays;
        //随机生成某时间段日期
        public static DateTime RandomDate(DateTime startTime, DateTime endTime)
        {
            var Range = (endTime - startTime).Days;
            var randomDay = new Random().Next(1, Range);
            DateTime dateTime = new DateTime();
            dateTime = startTime.AddDays(randomDay);
            if (!IsValidDate(dateTime))
            {
                while (IsValidDate(dateTime))
                {
                    Range = (dateTime - endTime).Days;
                    randomDay = new Random().Next(1, Range);
                    dateTime = startTime.AddDays(randomDay);
                }
                return dateTime;
            }
            return dateTime;
        }

        // 判断借还日期是否合理
        public static bool IsValidDate(DateTime date)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            string StrDate = date.ToString("yyyy-MM-dd");
            if (StrDate == "2019-05-05" || StrDate == "2019-10-12") return true;
            AddOffDays();
            if (_Offdays.Contains(StrDate) || !MonthValid(year, month, day) || date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday) return false;
            return true;
        }

        // 年、月约束
        private static bool MonthValid(int year, int month, int day)
        {
            if (year == 2018 && month != 12 || year == 2018 && month == 12 && day < 17 || year == 2019 && month == 2 || year == 2019 && month == 7 || year == 2019 && month == 8 || year == 2019 && month == 9 && day < 9 || year == 2019 && month == 10 && day < 8) return false;
            return true;
        }

        // 添加无规则休息日
        private static void AddOffDays()
        {
            _Offdays = new List<string>();
            _Offdays.Add("2018-12-31");
            _Offdays.Add("2019-01-01");
            _Offdays.Add("2019-01-28");
            _Offdays.Add("2019-01-29");
            _Offdays.Add("2019-01-30");
            _Offdays.Add("2019-01-31");
            _Offdays.Add("2019-03-01");
            _Offdays.Add("2019-04-05");
            _Offdays.Add("2019-04-29");
            _Offdays.Add("2019-04-30");
            _Offdays.Add("2019-05-01");
            _Offdays.Add("2019-05-02");
            _Offdays.Add("2019-05-03");
            _Offdays.Add("2019-06-07");
            _Offdays.Add("2019-09-13");
            _Offdays.Add("2019-09-30");
        }
    }
}