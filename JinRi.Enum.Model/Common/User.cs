using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.Enum.Common
{
    /// <summary>
    /// 用户枚举类
    /// </summary>
    public class User
    {
        /// <summary>
        /// 乘机人类型
        /// </summary>
        public enum PassengerType
        {
            /// <summary>
            /// 成人
            /// </summary>
            [Description("成人")]
            ADU = 0,
            /// <summary>
            /// 儿童
            /// </summary>
            [Description("儿童")]
            CHD = 1,
            /// <summary>
            /// 婴儿
            /// </summary>
            [Description("婴儿")]
            INF = 2,
            /// <summary>
            /// 婴儿
            /// </summary>
            [Description("外宾")]
            FADU = 3,
            /// <summary>
            /// 婴儿
            /// </summary>
            [Description("外宾儿童")]
            FCHD = 4
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
            Male = 0,
            /// <summary>
            /// 女性
            /// </summary>
            [Description("女")]
            Female = 1,
            /// <summary>
            /// 其他
            /// </summary>
            [Description("其他")]
            Other = 2
        }

        /// <summary>
        /// 证件类型
        /// </summary>
        public enum IdentifyClass
        {
            /// <summary>
            /// 身份证
            /// </summary>
            [Description("身份证")]
            IdCard = 0,
            /// <summary>
            /// 护照
            /// </summary>
            [Description("护照")]
            Passport = 1,
            /// <summary>
            /// 港澳通行证
            /// </summary>
            [Description("港澳通行证")]
            Officer = 2,
            /// <summary>
            /// 台胞证                                                                                             
            /// </summary>
            [Description("台胞证")]
            /// <remarks/>
            Taiwan = 3,
            /// <summary>
            /// 其它
            /// </summary>
            [Description("其它")]
            Other = 4
        }

        /// <summary>
        /// 用户角色
        /// </summary>
        public enum Role
        {
            /// <summary>
            /// 分销商
            /// </summary>
            [Description("分销商")]
            Seller = 1,
            /// <summary>
            /// 供票商
            /// </summary>
            [Description("供票商")]
            Provider = 2,
            /// <summary>
            /// 平台管理员
            /// </summary>
            [Description("平台管理员")]
            Admin = 3,
            /// <summary>
            /// 途牛
            /// </summary>
            [Description("途牛")]
            Tuiniu = 4,
            /// <summary>
            /// 系统【特指自动化相关的】
            /// </summary>
            [Description("系统")]
            System = 5,
        }
    }
}
