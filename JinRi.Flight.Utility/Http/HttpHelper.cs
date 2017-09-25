using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace JinRi.Flight.Utility.Http
{
    public class HttpHelper
    {
        public static string HttpGet(string strURL, int timeOut)
        {
            Exception ex = null;
            return HttpGet(strURL, timeOut, Encoding.UTF8, ex);
        }

        private static string HttpGet(string strURL, int timeOut, Encoding encode, Exception ex)
        {
            string rStr = null;
            try
            {
                if (!string.IsNullOrEmpty(strURL))
                {
                    strURL = UrlEncodeGB2312(strURL);
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(strURL);
                    request.Timeout = timeOut;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    StreamReader streamReader = new StreamReader(stream, encode);
                    rStr = streamReader.ReadToEnd();
                    streamReader.Close();
                    response.Close();
                }
            }
            catch (Exception ex1) { ex = ex1; }
            return rStr;
        }

        /// POST方式
        /// </summary>
        /// <param name="strURL">URI资源</param>
        /// <param name="strParm">POST参数</param>
        /// <param name="timeOut">超时值：以毫秒为单位</param>
        /// <returns></returns>
        public static string HttpPostUTF8(string strURL, string strParm, int timeOut)
        {
            StringBuilder rStr = new StringBuilder();
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader streamReader = null;
            Stream requestStream = null;
            try
            {
                //Encoding.GetEncoding("UTF-8").GetBytes(strParm);
                // byte[] postBytes = Encoding.ASCII.GetBytes(UrlEncodeGB2312(strParm));
                byte[] postBytes = Encoding.GetEncoding("UTF-8").GetBytes(strParm);
                request = (HttpWebRequest)HttpWebRequest.Create(strURL);
                request.Timeout = timeOut;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                request.ContentLength = postBytes.Length;
                requestStream = request.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                response = (HttpWebResponse)request.GetResponse();
                streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                rStr.Append(streamReader.ReadToEnd());
                streamReader.Close();
                requestStream.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (requestStream != null)
                {
                    requestStream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            return rStr.ToString();
        }

        /// POST方式
        /// </summary>
        /// <param name="strURL">URI资源</param>
        /// <param name="strParm">POST参数</param>
        /// <param name="timeOut">超时值：以毫秒为单位</param>
        /// <returns></returns>
        public static string HttpPostUTF8_Json(string strURL, string strParm, int timeOut)
        {
            StringBuilder rStr = new StringBuilder();
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader streamReader = null;
            Stream requestStream = null;
            try
            {
                // byte[] postBytes = Encoding.ASCII.GetBytes(UrlEncodeGB2312(strParm));
                //UTF8Encoding utf8 = new UTF8Encoding();
                //Byte[] postBytes = utf8.GetBytes(strParm);
                byte[] postBytes = Encoding.GetEncoding("UTF-8").GetBytes(strParm);
                request = (HttpWebRequest)HttpWebRequest.Create(strURL);
                request.Timeout = timeOut;
                request.Method = "POST";
                request.ContentType = "application/json;charset=utf-8";
                request.ContentLength = postBytes.Length;
                requestStream = request.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                response = (HttpWebResponse)request.GetResponse();
                streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                rStr.Append(streamReader.ReadToEnd());
                streamReader.Close();
                requestStream.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (requestStream != null)
                {
                    requestStream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            return rStr.ToString();
        }

        /// POST方式
        /// </summary>
        /// <param name="strURL">URI资源</param>
        /// <param name="strParm">POST参数</param>
        /// <param name="timeOut">超时值：以毫秒为单位</param>
        /// <returns></returns>
        public static string HttpPostGB2312(string strURL, string strParm, int timeOut)
        {
            StringBuilder rStr = new StringBuilder();
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader streamReader = null;
            Stream requestStream = null;
            try
            {
                Encoding.GetEncoding("UTF-8").GetBytes(strParm);
                byte[] postBytes = Encoding.GetEncoding("UTF-8").GetBytes(strParm);
                request = (HttpWebRequest)HttpWebRequest.Create(strURL);
                request.Timeout = timeOut;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = postBytes.Length;
                requestStream = request.GetRequestStream();
                requestStream.Write(postBytes, 0, postBytes.Length);
                response = (HttpWebResponse)request.GetResponse();
                streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("GB2312"));
                rStr.Append(streamReader.ReadToEnd());
                streamReader.Close();
                requestStream.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (requestStream != null)
                {
                    requestStream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
            return rStr.ToString();
        }

        private static string UrlEncodeGB2312(string strParm)
        {
            byte[] bs = Encoding.GetEncoding("gb2312").GetBytes(strParm);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bs.Length; i++)
            {
                if (bs[i] < 128)
                    sb.Append((char)bs[i]);
                else
                {
                    sb.Append("%" + bs[i++].ToString("x").PadLeft(2, '0'));
                    sb.Append("%" + bs[i].ToString("x").PadLeft(2, '0'));
                }
            }
            return sb.ToString();
        }

        #region 异步请求公共方法 author:shuquanliang, createdate:2015-05-14
        /// <summary>
        /// 异步请求委托
        /// </summary>
        /// <typeparam name="TPara">请求参数类型</typeparam>
        /// <typeparam name="TResult">响应结果</typeparam>
        /// <param name="GetData">请求方法</param>
        /// <param name="para">请求参数</param>
        delegate void CheckPublicDelegate<TPara, TResult>(Func<TPara, TResult> GetData, TPara para);

        /// <summary>
        /// 回调方法
        /// </summary>
        /// <typeparam name="TPara">请求参数类型</typeparam>
        /// <typeparam name="TResult">响应结果</typeparam>
        /// <param name="Ias">委托操作状态</param>
        private static void CallBackMethod<TPara, TResult>(IAsyncResult Ias)
        {
            CheckPublicDelegate<TPara, TResult> md = (CheckPublicDelegate<TPara, TResult>)Ias.AsyncState;
            md.EndInvoke(Ias);
        }

        /// <summary>
        /// 发送异步请求
        /// </summary>
        /// <typeparam name="TPara">请求参数类型</typeparam>
        /// <typeparam name="TResult">响应结果</typeparam>
        /// <param name="GetData">请求方法</param>
        /// <param name="para">请求参数</param>
        private static void CheckSend<TPara, TResult>(Func<TPara, TResult> GetData, TPara para)
        {
            GetData(para);
        }

        /// <summary>
        /// 异步代理方法
        /// </summary>
        /// <typeparam name="TPara">请求参数类型</typeparam>
        /// <typeparam name="TResult">响应结果</typeparam>
        /// <param name="GetData">请求方法</param>
        /// <param name="para">请求参数</param>
        public static void CheckPublicAsync<TPara, TResult>(Func<TPara, TResult> GetData, TPara para)
        {
            //实例化代理
            CheckPublicDelegate<TPara, TResult> md = new CheckPublicDelegate<TPara, TResult>(CheckSend);
            //实例一个回调代理
            AsyncCallback callback = new AsyncCallback(CallBackMethod<TPara, TResult>);
            //开始执行异步方法
            md.BeginInvoke(GetData, para, callback, md);
        }
        #endregion


        #region   HttpClient 请求 HulOperation  

        #region//Get请求
        /// <summary>
        /// 异步Get数据
        /// </summary>
        /// <param name="url">请求URL</param>
        /// <param name="kvp">请求参数</param>
        /// <returns></returns>
        public static string HttpGetStringSync(string url, List<KeyValuePair<string, string>> kvp = null )
        {
            string result = "";
            try
            {
                using (System.Net.Http.HttpClient _client = new System.Net.Http.HttpClient())
                {
                    List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
                    //IEnumerable<KeyValuePair<string, string>> kvp = new[] { 
                    //        new KeyValuePair<string,string>("data",dataStr),
                    //        new KeyValuePair<string, string>("data_digest", checkStr),
                    //        new KeyValuePair<string, string>("msg_type", msg_type),
                    //        new KeyValuePair<string, string>("httpMethod", httpMethod),
                    //        new KeyValuePair<string, string>("company_id", company_id)
                    //    };
                    string parames = "";
                    if (kvp != null)
                    {
                        foreach (var item in kvp)
                        {
                            if (string.IsNullOrEmpty(parames)) parames += "?" + item.Key + "=" + item.Value;
                            else parames += "&" + item.Key + "=" + item.Value;
                        }
                        url += parames;
                    }
                    //_client.Timeout = TimeSpan.FromMilliseconds(timeOut);
                    result = _client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                    if (string.IsNullOrEmpty(result))
                    {
                        throw new Exception("接口返回信息为空 错误:result=" + result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// 异步Get数据请求
        /// </summary>
        /// <typeparam name="T">请求类型</typeparam>
        /// <param name="url">请求URL</param>
        /// <param name="kvp">请求参数</param>
        /// <returns></returns>
        public static T HttpGetStringSync<T>(string url, List<KeyValuePair<string, string>> kvp = null) where T : new()
        {
            T entity = new T();
            try
            {
                using (System.Net.Http.HttpClient _client = new System.Net.Http.HttpClient())
                {
                    List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
                    //IEnumerable<KeyValuePair<string, string>> kvp = new[] {
                    //        new KeyValuePair<string,string>("data",dataStr),
                    //        new KeyValuePair<string, string>("data_digest", checkStr),
                    //        new KeyValuePair<string, string>("msg_type", msg_type),
                    //        new KeyValuePair<string, string>("httpMethod", httpMethod),
                    //        new KeyValuePair<string, string>("company_id", company_id)
                    //    };
                    string parames = "";
                    if (kvp != null)
                    {
                        foreach (var item in kvp)
                        {
                            if (string.IsNullOrEmpty(parames)) parames += "?" + item.Key + "=" + item.Value;
                            else parames += "&" + item.Key + "=" + item.Value;
                        }
                        url += parames;
                    }
                    //_client.Timeout=TimeSpan.FromMilliseconds(timeOut);
                    string result = _client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                    if (string.IsNullOrEmpty(result))
                    {
                        throw new Exception("接口返回信息为空 错误:result=" + result);
                    }
                    else {
                        entity = JsonConvert.DeserializeObject<T>(result);
                    }
                }
            }
            catch (Exception ex)
            {
            
                throw ex;
            }
            return entity;
        }
        #endregion

        #region//Post 请求
        /// <summary>
        /// 异步Post数据请求
        /// </summary>
        /// <typeparam name="T">请求类型</typeparam>
        /// <param name="url">请求URl</param>
        /// <param name="kvp">请求参数</param>
        /// <returns></returns>
        public static T HttpPostStringSync<T>(string url, List<KeyValuePair<string, string>> kvp = null) where T : new()
        {
            T entity = new T();
            try
            {
                using (System.Net.Http.HttpClient _client = new System.Net.Http.HttpClient())
                {
                    List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
                   
                    if (kvp != null)
                    {
                        list.AddRange(kvp);
                    }
                    //_client.Timeout = TimeSpan.FromMilliseconds(timeOut);
                    var result = _client.PostAsync(url, new System.Net.Http.FormUrlEncodedContent(kvp)).Result.Content.ReadAsStringAsync().Result;
                    if (string.IsNullOrEmpty(result))
                    {
                        throw new Exception("接口返回信息为空 错误:result=" + result);
                    }
                    entity = JsonConvert.DeserializeObject<T>(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        /// <summary>
        /// 异步Post数据请求
        /// </summary>
        /// <param name="url">请求url</param>
        /// <param name="kvp">请求参数</param>
        /// <returns></returns>
        public static string HttpPostStringSync(string url, List<KeyValuePair<string, string>> kvp = null)
        {
            string result = "";
            try
            {
                using (System.Net.Http.HttpClient _client = new System.Net.Http.HttpClient())
                {
                    List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
                    //IEnumerable<KeyValuePair<string, string>> kvp = new[] { 
                    //        new KeyValuePair<string,string>("data",dataStr),
                    //        new KeyValuePair<string, string>("data_digest", checkStr),
                    //        new KeyValuePair<string, string>("msg_type", msg_type),
                    //        new KeyValuePair<string, string>("httpMethod", httpMethod),
                    //        new KeyValuePair<string, string>("company_id", company_id)
                    //    };
                    if (kvp != null)
                    {
                        list.AddRange(kvp);
                    }
                    //_client.Timeout = TimeSpan.FromMilliseconds(timeOut);
                    result = _client.PostAsync(url, new System.Net.Http.FormUrlEncodedContent(kvp)).Result.Content.ReadAsStringAsync().Result;
                    if (string.IsNullOrEmpty(result))
                    {
                        throw new Exception("接口返回信息为空 错误:result=" + result);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        #endregion


        #endregion


    }
}
