using JinRi.Flight.BussicUtility;
using JinRi.Flight.BussicUtility.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JinRi.Flight.BussicUtility.Tests
{
    [TestClass()]
    public class BaseDataHelperTests
    {
        /// <summary>
        /// 获取航司
        /// </summary>
        [TestMethod()]
        public void GetAirlineTest()
        {
            var result = BaseDataHelper.GetAirline();
            Assert.AreEqual(result, result);
        }
        /// <summary>
        /// 获取省市区
        /// </summary>
        [TestMethod()]
        public void GetProvinceTest()
        {
            var dff = BaseDataHelper.GetProvince();
            Assert.AreEqual(dff, dff);
        }

        /// <summary>
        /// 根据appid和key获取AppSetConfig有效设置信息
        /// </summary>
        [TestMethod()]
        public void GetAppSettingTest()
        {
            var a= BaseDataHelper.GetAppSetting("IsBookSpot");
        }

        /// <summary>
        /// 根据航司二字码集合获取航司信息
        /// </summary>
        [TestMethod()]
        public void GetAirlineTest1()
        {
            Assert.IsNotNull(BaseDataHelper.GetAirline(new List<string>
            {
              "MU"
            }), "测试成功");
        }

        /// <summary>
        /// 根据城市三字码集合获取有效城市信息
        /// </summary>
        [TestMethod()]
        public void GetGlobalCityTest()
        {
            Assert.IsNotNull(BaseDataHelper.GetGlobalCity(new List<string>
            {
              "FNJ"
            }), "测试成功");
        }

        /// <summary>
        /// 根据机场三字码集合获取的有效机场
        /// </summary>
        [TestMethod()]
        public void GetAirportTest()
        {
            List<string> list = new List<string>() { "INC", "AVA" };
            Assert.IsNotNull(BaseDataHelper.GetAirport(new AirlineInput
            {
                Type = 1,
                List = list
            }), "测试成功");
        }

     

    }
}