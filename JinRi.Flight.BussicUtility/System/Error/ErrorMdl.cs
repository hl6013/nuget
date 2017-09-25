using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.Flight.BussicUtility
{
    /// <summary>
    /// Result对象
    /// </summary>
    public class ErrorException
    {
        public ErrorException(Exception ex, string onlyMark = "")
        {
            var insStackTrace = new StackTrace(ex, true);
            var insStackFrame = insStackTrace.GetFrame(0);

            ClassName = insStackFrame.GetFileName();
            MethodName = insStackFrame.GetMethod().Name;
            LineNumber = insStackFrame.GetFileLineNumber();
            InnerException = (ex.InnerException != null ? ex.InnerException.Message : "");
            OnlyMark = onlyMark;
            Message = "唯一标识：" + onlyMark
                + ",类名：+" + ClassName
                + ",方法：+" + MethodName
                + ",行号：+" + LineNumber
                + "错误信息：" + ex.ToString();
            var tempEx = ex.InnerException;
            int i = 0;
            while (tempEx != null)
            {
                i++;
                Message += tempEx.Message + " / ";
                tempEx = tempEx.InnerException;
                if (i >= 32)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// 唯一标识
        /// </summary>
        public string OnlyMark { get; set; }

        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 方法名
        /// </summary>
        public string MethodName { get; set; }
        /// <summary>
        /// 行数
        /// </summary>
        public int LineNumber { get; set; }
        /// <summary>
        /// 内部错误
        /// </summary>
        public string InnerException { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }

    }

    
}
