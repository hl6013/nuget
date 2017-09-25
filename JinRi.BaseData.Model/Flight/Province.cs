namespace JinRi.BaseData.Model
{
    /// <summary>
    /// 省市区实体类
    /// ProvinceEnity
    /// <author>
    ///		<name>HuL</name>
    ///		<date>2017.08.31</date>
    /// </author>
    /// </summary>
    public class Province
    {
        /// <summary>
        /// 自增id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 父级Code
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 简称
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public string LevelType { get; set; }
        /// <summary>
        /// 城市Code
        /// </summary>
        public string CityCode { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// 地址组合
        /// </summary>
        public string MergerName { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public decimal Lng { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public decimal Lat { get; set; }
        /// <summary>
        /// 拼音
        /// </summary>
        public string Pinyin { get; set; }
    }
}
