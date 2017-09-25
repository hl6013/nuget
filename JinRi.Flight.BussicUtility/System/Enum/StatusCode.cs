﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.Flight.BussicUtility
{

    public enum StatusCode
    {
        /// <summary>
        /// 请求(或处理)成功
        /// </summary>
        [Description("请求(或处理)成功")]
        Sys_Success = 200,
        /// <summary>
        /// 内部请求出错
        /// </summary>
        [Description("内部请求出错")]
        Sys_Error = 500,
        /// <summary>
        /// 未授权标识
        /// </summary>
        [Description("未授权标识")]
        Sys_Unauthorized = 401,
        /// <summary>
        /// 请求参数不完整或不正确
        /// </summary>
        [Description("请求参数不完整或不正确")]
        Sys_ParameterError = 400,
        /// <summary>
        /// 请求TOKEN失效
        /// </summary>
        [Description("请求TOKEN失效")]
        Sys_TokenInvalid = 403,
        /// <summary>
        /// HTTP请求类型不合法
        /// </summary>
        [Description("HTTP请求类型不合法")]
        Sys_HttpMehtodError = 405,
        /// <summary>
        /// HTTP请求不合法
        /// </summary>
        [Description("HTTP请求不合法,请求参数可能被篡改")]
        Sys_HttpRequestError = 406,
        /// <summary>
        /// HTTP请求不合法
        /// </summary>
        [Description("该URL已经失效")]
        Sys_URLExpireError = 407,
    }
}
