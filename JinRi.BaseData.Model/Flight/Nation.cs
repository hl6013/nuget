namespace JinRi.BaseData.Model
{
    /// <summary>
    /// 全球基础数据实体类
    /// NationEntity
    /// <author>
    ///		<name>HuL</name>
    ///		<date>2017.08.31</date>
    /// </author>
    /// </summary>
    public class Nation
    {
        /// <summary>
        /// 自增id
        /// </summary>
        public int Id { get; set; }
       /// <summary>
       /// 城市代码
       /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 大洲英文名称
        /// </summary>
        public string Continent { get; set; }
        /// <summary>
        /// 城市名称
        /// </summary>
        public string CnName { get; set; }
        /// <summary>
        /// 城市英文名称
        /// </summary>
        public string EnName { get; set; }
        /// <summary>
        /// 大洲中文名称
        /// </summary>
        public string CnContinent { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 是否有效  1：有效；0：无效
        /// </summary>
        public byte IsDelete { get; set; }
    }
}
