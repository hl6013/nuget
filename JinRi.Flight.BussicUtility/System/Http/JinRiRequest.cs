using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Web;

namespace JinRi.Flight.BussicUtility.Http
{
    /// <summary>
    /// 基础请求对象
    /// </summary>
    public class JinRiRequest
    {
        public JinRiRequest()
        {

        }
        /// <summary>
        /// IP
        /// </summary>
        public string IP { get { return GetIp(); } }


        private static string GetIp()
        {
            try
            {
                if (HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
                    return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Split(new char[] { ',' })[0];
                else
                    return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            catch (Exception e)
            {
                return "0.0.0.0";
            }
        }


        /// <summary>
        /// 来源
        /// </summary>
        public string AppId
        {
            get
            {
                return ConfigurationManager.AppSettings["AppId"] ?? "";
            }
        }
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
    }
    /// <summary>
    /// 基础业务请求
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JinRiRequest<T> : JinRiRequest
    {
        public T Data { get; set; }
    }

    public class JinRiPageRequest<T> : JinRiRequest<T>
    {
        public PagedInputDto PageInput { get; set; }
    }

    public class PagedInputDto
    {
        /// <summary>
        /// 查询数量
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// 跳过个数
        /// </summary>
        [Range(0, int.MaxValue)]
        public int SkipCount { get { return (CurrentPage - 1) * PageSize; } }
    }

    class AppConsts
    {
        /// <summary>
        /// Default page size for paged requests.
        /// </summary>
        public const int DefaultPageSize = 10;

        /// <summary>
        /// Maximum allowed page size for paged requests.
        /// </summary>
        public const int MaxPageSize = 1000;
    }

}
