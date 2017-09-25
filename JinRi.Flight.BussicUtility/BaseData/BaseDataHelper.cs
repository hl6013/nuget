using JinRi.BaseData.Model;
using JinRi.Flight.BussicUtility.Http;
using JinRi.Flight.Utility.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace JinRi.Flight.BussicUtility
{
    public class BaseDataHelper
    {
        #region 配置文件
        /// <summary>
        /// 获取配置文件AppId值
        /// </summary>
        private static string AppId = ConfigurationManager.AppSettings["AppId"].ToString();
        /// <summary>
        /// 基础数据接口URL
        /// </summary>
        private static string Url = ConfigurationManager.AppSettings["BaseDataUrl"].ToString();

        /// <summary>
        /// 根据appid获取信息strURLSystemConfigByAppid
        /// </summary>
        private static string strURLSystemConfigByAppid = Url + "/System/GetByAppId";

        /// <summary>
        /// 基础数据配置SystemConfigURL
        /// </summary>
        private static string strURLSystemConfig = Url + "/System/Get";
        /// <summary>
        ///  基础数据配置strURLAppSetting
        /// </summary>
        private static string strURLAppSetting = Url + "/AppSet/Get";
        /// <summary>
        /// 根据appid和key获取设置信息
        /// </summary>
        private static string strURLAppSettingByKey = Url + "/AppSet/GetByKey";

        /// <summary>
        /// 根据appid获取配置信息集合
        /// </summary>
        private static string strURLGetByAppId = Url + "/AppSet/GetByAppId";
        /// <summary>
        /// 获取有效航司信息
        /// </summary>
        private static string strURLAirLine = Url + "/Airline/Get";
        /// <summary>
        /// 根据航司二字码获取航司信息
        /// </summary>
        private static string strURLAirLineCode = Url + "/Airline/GetByCode";
        /// <summary>
        /// 根据航司二字码集合获取航司信息
        /// </summary>
        private static string strURLAirLineCodes = Url + "/Airline/GetByCodes";

        /// <summary>
        /// 获取城市信息
        /// </summary>
        private static string strURCity = Url + "/City/Get";
        /// <summary>
        /// 根据城市三字码获取有效城市信息
        /// </summary>
        private static string strURLGlobalCityByCode = Url + "/City/GetByCode";
        /// <summary>
        /// 根据城市三字码集合获取有效城市信息
        /// </summary>
        private static string strURLGlobalCityByCodes = Url + "/City/GetByCodes";

        /// <summary>
        /// 根据国家二字码获取有效城市信息
        /// </summary>
        private static string strURLGetByNationCode = Url + "/City/GetByNationCode";
        /// <summary>
        /// 获取机场信息
        /// </summary>
        private static string strURLAirport = Url + "/Airport/Get";
        /// <summary>
        /// 根据机场二字码获取有效信息
        /// </summary>
        private static string strURLAirportByCode = Url + "/Airport/GetByCode";
        /// <summary>
        /// 根据机场二字码集合或者城市三字码获取有效信息
        /// </summary>
        private static string strURLAirportByCodes = Url + "/Airport/GetByCodes";
        /// <summary>
        /// 获取国家信息
        /// </summary>
        private static string strURLNation = Url + "/Nation/Get";
        /// <summary>
        /// 根据国家二字码获取有效信息
        /// </summary>
        private static string strURLNationGetByCode = Url + "/Nation/GetByCode";

        /// <summary>
        /// 根据大洲获取有效信息
        /// </summary>
        private static string strURLNationGetByCnContinent = Url + "/Nation/GetByCnContinent";

        /// <summary>
        ///获取省市区信息
        /// </summary>
        private static string strURLProvince = Url + "/Province/Get";
        /// <summary>
        ///根据ParentID获取所有有效的下级省市区
        /// </summary>
        private static string strURLGetByParentId = Url + "/Province/GetByParentId";
        #endregion

        #region 系统设置SystemConfig
        /// <summary>
        /// 根据appid获取有SystemConfig效配置信息
        /// </summary>
        /// <param name="appId">appId</param>
        /// <returns></returns>
        public static SystemConfig GetSystem(int appId)
        {
            JinRiResponse<SystemConfig> response = new JinRiResponse<SystemConfig>();
            string strMeg = string.Empty;
            try
            {
                if (appId > 0)
                {
                    var requst = JsonConvert.SerializeObject(appId);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLSystemConfigByAppid, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<SystemConfig>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }
        #endregion

        #region 系统设置类AppSetConfig
        /// <summary>
        ///根据当前项目配置Key值获取AppSetConfig有效配置文件信息
        /// </summary>
        /// <param name="key">key值</param>
        /// <returns></returns>
        public static string GetAppSetting(string key)
        {
            JinRiRequest<AppSettingInput> model = new JinRiRequest<AppSettingInput>();
            JinRiResponse<AppSetting> response = new JinRiResponse<AppSetting>();

            string resultData = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(key))
                {
                    model.Data = new AppSettingInput
                    {
                        AppId = int.Parse(AppId),
                        Key = key
                    };
                    var requst = JsonConvert.SerializeObject(model);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLAppSettingByKey, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<AppSetting>>(result);
                        resultData = response.Data.Value;
                    }
                }
            }
            catch (Exception)
            {
                resultData = "";
            }
            //TODO作为临时使用
            //如果从基础数据服务接口拿不到数据，则读取本地的数据
            if (string.IsNullOrEmpty(resultData))
            {
                resultData = ConfigurationManager.AppSettings[key];
            }
            return resultData;           
        }

        #endregion

        #region 航司 Airline

        /// <summary>
        /// 获取有效航司信息
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Airline> GetAirline()
        {
            JinRiResponse<IEnumerable<Airline>> response = new JinRiResponse<IEnumerable<Airline>>();
            try
            {
                string result = HttpHelper.HttpPostUTF8_Json(strURLAirLine, "", 100000);
                if (!string.IsNullOrEmpty(result))
                {
                    response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Airline>>>(result);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }


        /// <summary>
        ///根据航司二字码获取有效航司信息
        /// </summary>
        /// <param name="code">航司二字码</param>
        /// <returns></returns>
        public static Airline GetAirline(string code)
        {
            JinRiResponse<Airline> response = new JinRiResponse<Airline>();
            try
            {
                if (!string.IsNullOrEmpty(code))
                {
                    var requst = JsonConvert.SerializeObject(code);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLAirLineCode + "?code=" + code, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<Airline>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }


        /// <summary>
        ///根据航司二字码集合获取航司信息
        /// </summary>
        /// <param name="model">航司二字码集合</param>
        /// <returns></returns>
        public static IEnumerable<Airline> GetAirline(List<string> model)
        {
            JinRiRequest<List<string>> requestmodel = new JinRiRequest<List<string>>();
            JinRiResponse<IEnumerable<Airline>> response = new JinRiResponse<IEnumerable<Airline>>();
            try
            {
                if (model != null && model.Count > 0)
                {
                    requestmodel.Data = model;
                    var requst = JsonConvert.SerializeObject(requestmodel);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLAirLineCodes, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Airline>>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        #endregion

        #region 城市 City

        /// <summary>
        ///获取有效城市信息
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<GlobalCity> GetGlobalCity()
        {
            JinRiResponse<IEnumerable<GlobalCity>> response = new JinRiResponse<IEnumerable<GlobalCity>>();
            try
            {
                string result = HttpHelper.HttpPostUTF8_Json(strURCity, "", 100000);
                if (!string.IsNullOrEmpty(result))
                {
                    response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<GlobalCity>>>(result);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        /// <summary>
        ///根据城市三字码获取有效城市信息
        /// </summary>
        /// <param name="cityCode">城市三字码</param>
        /// <returns></returns>
        public static GlobalCity GetGlobalCity(string cityCode)
        {
            JinRiResponse<GlobalCity> response = new JinRiResponse<GlobalCity>();
            try
            {
                if (!string.IsNullOrEmpty(cityCode))
                {
                    var requst = JsonConvert.SerializeObject(cityCode);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLGlobalCityByCode + "?cityCode=" + cityCode, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<GlobalCity>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        /// <summary>
        ///根据城市三字码集合获取有效城市信息
        /// </summary>
        /// <param name="model">城市三字码集合</param>
        /// <returns></returns>
        public static IEnumerable<GlobalCity> GetGlobalCity(List<string> model)
        {
            JinRiRequest<List<string>> requestModel = new JinRiRequest<List<string>>();
            JinRiResponse<IEnumerable<GlobalCity>> response = new JinRiResponse<IEnumerable<GlobalCity>>();
            try
            {
                if (model != null && model.Count > 0)
                {
                    requestModel.Data = model;
                    var requst = JsonConvert.SerializeObject(requestModel);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLGlobalCityByCodes, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<GlobalCity>>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        ///<summary>
        ///根据国家二字码获取有效城市信息
        /// </summary>
        /// <param name="countryCode">国家二字码</param>
        /// <returns></returns>
        public static IEnumerable<GlobalCity> GetByNationCode(string countryCode)
        {
            JinRiResponse<IEnumerable<GlobalCity>> response = new JinRiResponse<IEnumerable<GlobalCity>>();
            try
            {
                if (!string.IsNullOrEmpty(countryCode))
                {
                    var requst = JsonConvert.SerializeObject(countryCode);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLGetByNationCode, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<GlobalCity>>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }
        #endregion

        #region 机场 Airport 


        /// <summary>
        /// 获取有效机场信息
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Airport> GetAirport()
        {
            JinRiResponse<IEnumerable<Airport>> response = new JinRiResponse<IEnumerable<Airport>>();
            try
            {
                string result = HttpHelper.HttpPostUTF8_Json(strURLAirport, "", 100000);
                if (!string.IsNullOrEmpty(result))
                {
                    response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Airport>>>(result);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        /// <summary>
        ///根据机场三字码获取有效机场信息
        /// </summary>
        /// <param name="airCode">机场三字码</param>
        /// <returns></returns>
        public static Airport GetAirport(string airCode)
        {
            JinRiResponse<Airport> response = new JinRiResponse<Airport>();
            try
            {
                if (!string.IsNullOrEmpty(airCode))
                {
                    var requst = JsonConvert.SerializeObject(airCode);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLAirportByCode + "?airCode=" + airCode, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<Airport>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        /// <summary>
        ///根据机场三字码集合获取的有效机场
        /// </summary>
        /// <param name="model">机场三字码集合 type查询类型1：城市三字码；2：机场二字码</param>
        /// <returns></returns>
        public static IEnumerable<Airport> GetAirport(AirlineInput model)
        {
            JinRiRequest<AirlineInput> requestModel = new JinRiRequest<AirlineInput>();
            JinRiResponse<IEnumerable<Airport>> response = new JinRiResponse<IEnumerable<Airport>>();
            try
            {
                if (model != null && model.List!=null && model.List.Count > 0 && model.Type > 0)
                {
                    requestModel.Data = model;
                    var requst = JsonConvert.SerializeObject(requestModel);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLAirportByCodes, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Airport>>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }
        #endregion

        #region 国家Nation
        /// <summary>
        /// 获取有效国家信息
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Nation> GetNation()
        {
            JinRiResponse<IEnumerable<Nation>> response = new JinRiResponse<IEnumerable<Nation>>();
            string strURL = strURLNation;
            try
            {
                string result = HttpHelper.HttpPostUTF8_Json(strURLNation, "", 100000);
                if (!string.IsNullOrEmpty(result))
                {
                    response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Nation>>>(result);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        /// <summary>
        ///根据国家二字码获取有效国家信息
        /// </summary>
        /// <param name="code">国家二字码</param>
        /// <returns></returns>
        public static Nation GetNationByCode(string code)
        {
            JinRiResponse<Nation> response = new JinRiResponse<Nation>();
            try
            {
                if (!string.IsNullOrEmpty(code))
                {
                    var requst = JsonConvert.SerializeObject(code);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLNationGetByCode + "?code=" + code, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<Nation>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }


        // <summary>
        ///根据大洲获取有效国家信息
        /// </summary>
        /// <param name="continent">大洲</param>
        /// <returns></returns>
        public static IEnumerable<Nation> GetNation(string continent)
        {
            JinRiResponse<IEnumerable<Nation>> response = new JinRiResponse<IEnumerable<Nation>>();
            try
            {
                if (!string.IsNullOrEmpty(continent))
                {
                    var requst = JsonConvert.SerializeObject(continent);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLNationGetByCnContinent + "?continent=" + continent, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Nation>>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        #endregion

        #region  国内省市区 Province

        /// <summary>
        /// 获取有效省市区信息
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Province> GetProvince()
        {
            JinRiResponse<IEnumerable<Province>> response = new JinRiResponse<IEnumerable<Province>>();
            try
            {
                string result = HttpHelper.HttpPostUTF8_Json(strURLProvince, "", 100000);
                if (!string.IsNullOrEmpty(result))
                {
                    response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Province>>>(result);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }


        /// <summary>
        ///根据ParentID获取所有有效的下级省市区/县
        /// </summary>
        /// <param name="pid">父级ID</param>
        /// <returns></returns>
        public static IEnumerable<Province> GetProvince(string pid)
        {
            JinRiResponse<IEnumerable<Province>> response = new JinRiResponse<IEnumerable<Province>>();
            try
            {
                if (!string.IsNullOrEmpty(pid))
                {
                    var requst = JsonConvert.SerializeObject(pid);
                    string result = HttpHelper.HttpPostUTF8_Json(strURLGetByParentId + "?pid=" + pid, requst, 100000);
                    if (!string.IsNullOrEmpty(result))
                    {
                        response = JsonConvert.DeserializeObject<JinRiResponse<IEnumerable<Province>>>(result);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return response.Data;
        }

        #endregion
    }
}
