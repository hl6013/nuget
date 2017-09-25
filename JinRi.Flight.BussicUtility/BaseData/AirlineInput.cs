using System.Collections.Generic;

namespace JinRi.Flight.BussicUtility
{
    /// <summary>
    /// 根据航司二字码返回实体
    /// </summary>
    public class AirlineInput
    {
        /// <summary>
        /// 航司二字码
        /// </summary>
        public List<string> List { get; set; }
        /// <summary>
        /// 查询类型 1：城市三字码；2机场三字码
        /// </summary>
        public int Type { get; set; }
    }
  
}
