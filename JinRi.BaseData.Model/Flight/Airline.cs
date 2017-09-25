namespace JinRi.BaseData.Model
{
    /// <summary>
    /// 全球航司实体类
    /// Airline
    /// <author>
    ///		<name>HuL</name>
    ///		<date>2017.08.31</date>
    /// </author>
    /// </summary>
    public class Airline
    {
        /// <summary>
        /// 自增Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 航司二字码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 航司中文名称
        /// </summary>
        public string Cname { get; set; }
        /// <summary>
        /// 航司英文名称
        /// </summary>
        public string Ename { get; set; }
        /// <summary>
        /// 航司图标
        /// </summary>
        public string Logo { get; set; }
        /// <summary>
        /// 航司所属国家
        /// </summary>
        public string CountryCode { get; set; }
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
