
using System;
using System.Collections.Generic;

namespace JinRi.Flight.BussicUtility.Http
{
    /// <summary>
    /// 基础返回结果
    /// </summary>
    public class JinRiResponse
    {
        public JinRiResponse()
        {

        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public JinRiResponse(StatusCode code, bool isSuccess = false, string message = "")
        {
            Code = Convert.ToInt32(code).ToString();
            Msg = message;
            IsSuccess = isSuccess;
        }

        /// <summary>
        /// 是否执行成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        public string Code { get; set; }


        /// <summary>
        ///     设置成功状态
        /// </summary>
        public virtual void SetSuccess()
        {
            IsSuccess = true;
        }


        /// <summary>
        ///     重写tostring
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0},ErrorCode:{1},Message:{2}", IsSuccess, Code, Msg);
        }

    }
    /// <summary>
    /// 信息返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JinRiResponse<T> : JinRiResponse
    {
        public JinRiResponse()
        {

        }

        /// <summary>
        ///     构造函数
        /// </summary>
        public JinRiResponse(StatusCode errorCode, T data = default(T), bool isSuccess = false, string message = "")
            : base(errorCode, isSuccess, message)
        {
            Data = data;
        }

        public T Data { get; set; }

        /// <summary>
        ///     设置返回数据
        /// </summary>
        public virtual void SetSuccess(T data)
        {
            IsSuccess = true;
            Data = data;
        }

        /// <summary>
        ///     设置返回数据
        /// </summary>
        public virtual JinRiResponse<T> SetApiResult(T data)
        {
            Data = data;
            return this;
        }
    }

    public class JinRiPageResponse<T> : JinRiResponse<T>
    {
        /// <summary>
        /// Total count of Items.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Creates a new <see cref="PagedResultDto{T}"/> object.
        /// </summary>
        public JinRiPageResponse()
        {

        }

        /// <summary>
        /// Creates a new <see cref="PagedResultDto{T}"/> object.
        /// </summary>
        /// <param name="totalCount">Total count of Items</param>
        /// <param name="items">List of items in current page</param>
        public JinRiPageResponse(List<T> items)
            : base()
        {
            if (items != null)
            {
                TotalCount = items.Count;
            }
        }
    }
}
