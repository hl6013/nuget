
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JinRi.Flight.BussicUtility.System.Tests
{
    [TestClass()]
    public class ConfigHelperTests
    {


        /// <summary>
        /// 全球航司
        /// </summary>
        /// <param name="type">状态，1为有效；0为无效；默认为1有效</param>
        /// <returns></returns>
        [TestMethod()]
        public void GetAirlineTest()
        {
            var dff = BaseDataHelper.GetAirline();
            Assert.IsNotNull(dff, "请求成功！");
        }


        /// <summary>
        /// 获取城市
        /// </summary>
        /// <param name="type">状态，1为有效；0为无效；默认为1有效</param>
        /// <returns></returns>
        [TestMethod()]
        public void GetCityTest()
        {
            var dff = BaseDataHelper.GetAirline();
            Assert.IsNotNull(dff, "请求成功！");
        }

        /// <summary>
        /// 获取机场
        /// </summary>
        /// <param name="type">状态，1为有效；0为无效；默认为1有效</param>
        /// <returns></returns>
        [TestMethod()]
        public void GetFLightTest()
        {
            var dff = BaseDataHelper.GetAirport();
            Assert.IsNotNull(dff, "请求成功！");
        }
        /// <summary>
        /// 获取国家
        /// </summary>
        /// <param name="type">状态，1为有效；0为无效；默认为1有效</param>
        /// <returns></returns>
        [TestMethod()]
        public void GetNationTest()
        {
            var dff = BaseDataHelper.GetNation();
            Assert.IsNotNull(dff, "请求成功！");
        }
        /// <summary>
        /// 获取省市区
        /// </summary>
        /// <param name="type">状态，1为有效；0为无效；默认为1有效</param>
        /// <returns></returns>
        [TestMethod()]
        public void GetProvinceTest()
        {
            var dff = BaseDataHelper.GetProvince();
            Assert.IsNotNull(dff, "请求成功！");
        }
    }
}