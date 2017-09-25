using System.ComponentModel;

namespace JinRi.Enum.Policy
{
    /// <summary>
    /// 政策枚举
    /// </summary>
    public class PolicyEnum
    {
        /// <summary>
        /// 政策状态
        /// </summary>
        public enum PolicyState
        {
            /// <summary>
            /// 等待审核
            /// </summary>
            [Description("等待审核")]
            WitAudit=1,
            /// <summary>
            /// 审核退回
            /// </summary>
            [Description("审核退回")]
            AuditReturn=2,
            /// <summary>
            /// 启用
            /// </summary>
            [Description("启用")]
            Open=3,
            /// <summary>
            /// 挂起
            /// </summary>
            [Description("挂起")]
            Pause=4,
            /// <summary>
            /// 强制启用
            /// </summary>
            [Description("强制启用")]
            ForceOpen=5,
            /// <summary>
            /// 强制挂起
            /// </summary>
            [Description("强制挂起")]
            ForcePause=6,
            /// <summary>
            /// 全部启用
            /// </summary>
            [Description("全部启用")]
            AllOpen =7,
            /// <summary>
            /// 全部挂起
            /// </summary>
            [Description("全部挂起")]
            AllPause = 8,
            /// <summary>
            /// 软删除
            /// </summary>
            [Description("软删除")]
            Delete =9
        }

        /// <summary>
        /// 票本类型
        /// </summary>
        public enum TicketType
        {
            /// <summary>
            /// BSP
            /// </summary>
            [Description("BSP")]
            BSP = 1,
            /// <summary>
            /// B2B
            /// </summary>
            [Description("B2B")]
            B2B = 2,
            /// <summary>
            /// 境外电子
            /// </summary>
            [Description("境外电子")]
            OVEL = 3,

        }

        /// <summary>
        /// 票本GDS
        /// </summary>
        public enum TicketGDS
        {
            /// <summary>
            /// 境内ETRM
            /// </summary>
            [Description("境内ETRM")]
            IETRM = 1,
            /// <summary>
            /// 境外ETRM
            /// </summary>
            [Description("境外ETRM")]
            OETRM = 2,
            /// <summary>
            /// GALIEO
            /// </summary>
            [Description("GALIEO")]
            GALIEO = 3,
            /// <summary>
            /// AMADUES
            /// </summary>
            [Description("AMADUES")]
            AMADUES = 4,
            /// <summary>
            /// ABACUS
            /// </summary>
            [Description("ABACUS")]
            ABACUS = 5,
            /// <summary>
            /// WORLDSPAN
            /// </summary>
            [Description("WORLDSPAN")]
            WORLDSPAN = 6
        }

        /// <summary>
        /// 换编码类型
        /// </summary>
        public enum EncodeType
        {
            /// <summary>
            /// 无需换编码
            /// </summary>
            [Description("无需换编码")]
            NONE = 1,
            /// <summary>
            /// 换编码出票
            /// </summary>
            [Description("换编码出票")]
            ChangeEncode = 2,
            /// <summary>
            /// 大编出票(无需换编)
            /// </summary>
            [Description("大编出票(无需换编)")]
            LargeNOCE = 3,
            /// <summary>
            /// 大编出票(需换编)
            /// </summary>
            [Description("大编出票(需换编)")]
            LargeNeedCE = 4,
            /// <summary>
            /// 无位不换出票(外放有位时换编)
            /// </summary>
            [Description("无位不换出票(外放有位时换编)")]
            NOSEAT = 5
        }

        /// <summary>
        /// 共享航班类型
        /// </summary>
        public enum ShareFlightType
        {
            /// <summary>
            /// 默认值
            /// </summary>
            [Description("默认值")]
            NONE = 0,
            /// <summary>
            /// 全程无奖励
            /// </summary>
            [Description("全程无奖励")]
            NoReward = 1,
            /// <summary>
            /// 全程指定奖励
            /// </summary>
            [Description("全程指定奖励")]
            FullReward = 2,
            /// <summary>
            /// 共享段无奖励
            /// </summary>
            [Description("共享段无奖励")]
            ShareNoReward = 3,
            /// <summary>
            /// 共享段指定奖励
            /// </summary>
            [Description("共享段指定奖励")]
            ShareFullReword = 4,
            /// <summary>
            /// 部分共享需供审
            /// </summary>
            [Description("部分共享需供审")]
            PartailSNA = 5
        }

        /// <summary>
        /// 指定office换编类型
        /// </summary>
        public enum OfficeType
        {
            /// <summary>
            /// 默认值
            /// </summary>
            [Description("默认值")]
            NONE = 0,
            /// <summary>
            /// 不换编
            /// </summary>
            [Description("不换编")]
            NChangeEncode = 1,
            /// <summary>
            /// 不开票
            /// </summary>
            [Description("不开票")]
            NOpenTicket = 2
        }

    }
}
