using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model.Enum
{
    /// <summary>
    /// 航程类型
    /// </summary>
    public enum FlightType
    {
        /// <summary>
        /// 单程
        /// </summary>
        [Description("单程")]
        OW = 1,
        /// <summary>
        /// 往返
        /// </summary>
        [Description("往返")]
        HR = 2,
        /// <summary>
        /// 多程
        /// </summary>
        [Description("多程")]
        MT = 3
    }

    /// <summary>
    /// 机型大小
    /// </summary>
    
    public enum CraftWidthType
    {
        /// <summary>
        /// 无机型大小
        /// </summary>
        [Description("无")]
        
        None = 0,
        /// <summary>
        /// 大
        /// </summary>
        [Description("大")]
        
        L = 1,
        /// <summary>
        /// 中
        /// </summary>
        [Description("中")]
        
        M = 2,
        /// <summary>
        /// 小
        /// </summary>
        [Description("小")]
        
        S = 3
    }

    /// <summary>
    /// 乘机人类型
    /// </summary>
    
    public enum PassengerType
    {
        /// <summary>
        /// 成人
        /// </summary>
        [Description("成人")]
        
        ADT = 0,
        /// <summary>
        /// 儿童
        /// </summary>
        [Description("儿童")]
        
        CNN = 1
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum Sexual
    {
        /// <summary>
        /// 男性
        /// </summary>
        [Description("男")]
        Male = 1,
        /// <summary>
        /// 女性
        /// </summary>
        [Description("女")]
        Female = 2,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 3
    }
}
