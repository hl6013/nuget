
namespace JinRi.BaseData.Model
{
    /// <summary>
    /// 全球城市实体类
    /// GlobalCityEntity
    /// <author>
    ///		<name>HuL</name>
    ///		<date>2017.08.31</date>
    /// </author>
    /// </summary>
    public class GlobalCity
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 大洲
        /// </summary>
        public string Continent { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// 国家二字码
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// 城市二字码
        /// </summary>
        public string CityCode { get; set; }
        /// <summary>
        /// 城市中文名称
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 城市英文名称
        /// </summary>
        public string EName { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        ///是否有效  1：有效；0：无效   
        /// </summary>
        public byte IsDelete { get; set; }
    }
}
