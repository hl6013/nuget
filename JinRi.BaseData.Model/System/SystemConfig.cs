namespace JinRi.BaseData.Model
{
    /// <summary>
    /// 系统配置类 SystemConfig
    /// SystemConfig
    /// <author>
    ///		<name>HuL</name>
    ///		<date>2017.08.31</date>
    /// </author>
    /// </summary>
    public class SystemConfig
    {
        /// <summary>
        /// 站点ID
        /// </summary>
        public int AppId { get; set; }
        /// <summary>
        ///站点名称
        /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
        /// 站点显示名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 站点地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 依赖的站点
        /// </summary>
        public string DependentProject { get; set; }
        /// <summary>
        /// 是否创建InfluxDB日志库
        /// </summary>
        public bool IsInfluxLogDb { get; set; }
        /// <summary>
        ///  状态 0：无效；1：有效；2：删除
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string ReMark { get; set; }
    }
}
