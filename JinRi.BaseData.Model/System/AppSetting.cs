namespace JinRi.BaseData.Model
{
    /// <summary>
    /// 系统配置类 JinRiAppSetting
    /// JinRiAppSetting
    /// <author>
    ///		<name>HuL</name>
    ///		<date>2017.08.31</date>
    /// </author>
    /// </summary>
    public class AppSetting
    {
        public int Id { get; set; }
        /// <summary>
        /// 站点ID
        /// </summary>
        public int AppId { get; set; }
        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Value值
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 状态 0：无效；1：有效；2：删除
        /// </summary>
        public int State { get; set; }

    }
}
