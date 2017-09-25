using System;

namespace JinRi.Flight.Utility.Time
{
    /// <summary>
    /// 时间工具类
    /// </summary>
    public class TimeHelper
    {
        /// <summary>
        /// 获取与JS兼容的时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetCurrentTicksForJs()
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            DateTime dtResult = DateTime.Now;//获取时间           
            long t = (dtResult.Ticks - startTime.Ticks) / 10000;//除10000调整为13位  
            return t;
        }

        /// <summary>
        /// 根据时间获取当前周
        /// </summary>
        /// <param name="date">时间</param>
        /// <returns></returns>
        public static string GetWeek(DateTime date)
        {
            string[] Day = new string[] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = Day[Convert.ToInt32(date.DayOfWeek.ToString("d"))].ToString();
            return week;
        }
    }
}
