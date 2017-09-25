namespace JinRi.Flight.Utility.Extensions
{
    public static class NumberChineseExtensions
    {
        /// <summary>
        /// 中文转数字
        /// </summary>
        /// <param name="chineseStr"></param>
        /// <returns></returns>
        public static string ChineseTONumber(string chineseStr)
        {
            string numStr = "0123456789";
            string chinese = "零一二三四五六七八九";
            char[] c = chinese.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                int index = chineseStr.IndexOf(c[i]);
                if (index != -1)
                    c[i] = numStr.ToCharArray()[index];
            }
            numStr = null;
            chineseStr = null;
            return new string(c);
        }
        /// <summary>
        /// 数字转中文
        /// </summary>
        /// <param name="numberStr"></param>
        /// <returns></returns>
        public static string NumberToChinese(string numberStr)
        {
            string numStr = "0123456789";
            string chineseStr = "零一二三四五六七八九";
            char[] c = numberStr.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                int index = numStr.IndexOf(c[i]);
                if (index != -1)
                    c[i] = chineseStr.ToCharArray()[index];
            }
            numStr = null;
            chineseStr = null;
            return new string(c);
        }
    }
}
