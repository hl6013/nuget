using System.ComponentModel;

namespace JinRi.Enum.Order
{
    /// <summary>
    /// 订单枚举
    /// </summary>
    public class OrderEnum
    {

        /// <summary>
        /// 订单来源
        /// </summary>
        public enum OrderSource
        {
            /// <summary>
            /// 国际平台
            /// </summary>
            [Description("国际平台")]
            IFlight = 0,
            /// <summary>
            /// 途牛
            /// </summary>
            [Description("途牛")]
            Tuniu = 1
        }

        /// <summary>
        /// 订单状态
        /// </summary>
        public enum OrderStatus
        {
            /// <summary>
            /// 空订单状态
            /// </summary>
            [Description("空订单状态")]
            NoStatus = -2,
            /// <summary>
            /// 等待审核
            /// </summary>
            [Description("等待审核")]
            ConfirmWaitting = -1,
            /// <summary>
            /// 等待支付
            /// </summary>
            [Description("等待支付")]
            PayWaitting = 0,
            /// <summary>
            /// 支付成功
            /// </summary>
            [Description("支付成功")]
            Payed = 1,
            /// <summary>
            /// 出票成功
            /// </summary>
            [Description("出票成功")]
            OutTicketed = 2,
            /// <summary>
            /// 审核退回
            /// </summary>
            [Description("审核退回")]
            AuditReturn = 3,
            /// <summary>
            /// 申请退票
            /// </summary>
            [Description("申请退票")]
            RefundApply = 4,
            /// <summary>
            /// 退款中
            /// </summary>
            [Description("退款中")]
            Refunding = 5,
            /// <summary>
            /// 取消订单
            /// </summary>
            [Description("取消订单")]
            Cancel = 6,
            ///// <summary>
            ///// 暂不能出票
            ///// </summary>
            //[Description("暂不能出票")]
            //CannotOut = 7,
            ///// <summary>
            ///// 暂不能废
            ///// </summary>
            //[Description("暂不能废")]
            //CannotScrap = 8,
            /// <summary>
            /// 暂不能退
            /// </summary>
            [Description("暂不能退")]
            CannotRefund = 9,
            ///// <summary>
            ///// 航班延误
            ///// </summary>
            //[Description("航班延误")]
            //Delayed = 10,
            /// <summary>
            /// 退款成功
            /// </summary>
            [Description("退款成功")]
            RefundSuccess = 14
        }


        /// <summary>
        /// 机票（乘客）状态
        /// </summary>
        public enum TicketStatus
        {
            /// <summary>
            /// 默认
            /// </summary>
            [Description("正常")]
            Normal = 0,
            /// <summary>
            /// 
            /// </summary>
            [Description("申请退票")]
            ApplyRefund = 1,
            /// <summary>
            /// 
            /// </summary>
            [Description("退票成功")]
            RefundSuccess = 2,
            /// <summary>
            /// 
            /// </summary>
            [Description("退款中")]
            Refunding = 3,
        };

        #region 改期
        /// <summary>
        /// 改期原因
        /// </summary>
        public enum ChangeReason
        {
            ///// <summary>
            ///// 空
            ///// </summary>
            //[Description("空")]
            //None = 0,
            /// <summary>
            /// 自愿改期
            /// </summary>
            [Description("自愿改期")]
            WillChange = 1,
            ///// <summary>
            ///// 改姓名或称谓
            ///// </summary>
            //[Description("改姓名或称谓")]
            //NameChange = 2,
            ///// <summary>
            ///// 航变改期
            ///// </summary>
            //[Description("航变改期")]
            //FlightChange = 3,
            /// <summary>
            /// 非自愿及特殊改期
            /// </summary>
            [Description("非自愿及特殊改期")]
            UnWillChange = 4
        }

        /// <summary>
        /// 改期状态
        /// </summary>
        public enum ChangeStatus
        {
            /// <summary>
            /// 待审核
            /// </summary>
            [Description("待审核")]
            WaitAudit = 0,
            /// <summary>
            /// 审核退回
            /// </summary>
            [Description("审核退回")]
            AuditReturn = 1,
            /// <summary>
            /// 待付款
            /// </summary>
            [Description("待付款")]
            WaitPay = 2,
            /// <summary>
            /// 支付成功
            /// </summary>
            [Description("支付成功")]
            Payed = 3,
            /// <summary>
            /// 待完成
            /// </summary>
            [Description("待完成")]
            WaitComplete = 5,
            /// <summary>
            /// 已完成
            /// </summary>
            [Description("已完成")]
            Completed = 6,
            /// <summary>
            /// 已失败
            /// </summary>
            [Description("已失败")]
            Failed = 7,
            /// <summary>
            /// 已取消
            /// </summary>
            [Description("已取消")]
            Canceled = 9,
            /// <summary>
            /// 退款中
            /// </summary>
            [Description("退款中")]
            Refunding = 10,
            /// <summary>
            /// 退款完成
            /// </summary>
            [Description("退款完成")]
            RefundSuccess = 11
        }
        #endregion

        #region 退票
        /// <summary>
        /// 退票状态
        /// </summary>
        public enum RefundState
        {
            [Description("全部")]
            All = -1,

            /// <summary>
            /// 申请退款
            /// </summary>
            [Description("申请退票")]
            Apply = 0,
            ///// <summary>
            ///// 确认金额
            ///// </summary>
            //[Description("已审核，正在退票")]
            //ConfirmAmount = 1,
            /// <summary>
            /// 退款处理中
            /// </summary>
            [Description("退款处理中")]
            Refunding = 2,
            /// <summary>
            /// 退款中
            /// </summary>
            [Description("退款中")]
            ConfirmRefund = 3,
            /// <summary>
            /// 退款完成
            /// </summary>
            [Description("退款完成")]
            Refunded = 4,
            /// <summary>
            /// 申请退回
            /// </summary>
            [Description("申请退回")]
            AuditReturn = 5,
            ///// <summary>
            ///// 暂不能退款
            ///// </summary>
            //[Description("暂不能退款")]
            //CanNotRefund = 5,
            ///// <summary>
            ///// 已审核，正在废票
            ///// </summary>
            //[Description("已审核，正在废票")]
            //CoinfirmVoid = 6,
            ///// <summary>
            ///// 暂不能废票
            ///// </summary>
            //[Description("暂不能废票")]
            //CanNotVoid = 7

        }

        /// <summary>
        /// 退废类型
        /// </summary>
        public enum RefundType
        {
            /// <summary>
            /// 废票
            /// </summary>
            [Description("废票")]
            Repeal = 0,
            /// <summary>
            /// 退票
            /// </summary>
            [Description("退票")]
            Refund = 1,
            ///// <summary>
            ///// 退差
            ///// </summary>
            //[Description("退差")]
            //Disparity = 2
        }

        /// <summary>
        /// 退款类型
        /// </summary>
        public enum AccountType
        {
            /// <summary>
            /// 退供应
            /// </summary>
            [Description("供应")]
            Provider = 0,
            /// <summary>
            /// 退平台
            /// </summary>
            [Description("平台")]
            Platform = 1,
            /// <summary>
            /// 退利润
            /// </summary>
            [Description("利润")]
            Profit = 2,
            /// <summary>
            /// 分润
            /// </summary>
            [Description("分润")]
            Fenrun = 3,
            /// <summary>
            /// 退补差
            /// </summary>
            [Description("补差")]
            Suppl = 4
        }

        /// <summary>
        /// 申请退款类型
        /// </summary>
        public enum ApplyRefundType
        {
            /// <summary>
            /// 正常退款
            /// </summary>
            [Description("正常退款")]
            Default = 0,
            /// <summary>
            /// 补退款
            /// </summary>
            [Description("补退款")]
            PatchRefund = 1
        }

        /// <summary>
        /// 退票原因
        /// </summary>
        public enum RefundReson
        {
            ///// <summary>
            ///// 当日作废
            ///// </summary>
            //[Description("当日作废")]
            //Depose = 1,
            /// <summary>
            /// 按客规自愿退票
            /// </summary>
            [Description("按客规自愿退票")]
            ByOrder = 2,
            /// <summary>
            /// 非自愿及特殊退票
            /// </summary>
            [Description("非自愿及特殊退票")]
            Special = 3,
            ///// <summary>
            ///// 航班延误申请全退
            ///// </summary>
            //[Description("航班延误申请全退")]
            //Delay = 4
        }

        /// <summary>
        /// 退废订单状态
        /// </summary>
        public enum RefundStatus
        {
            /// <summary>
            /// 初始化
            /// </summary>
            [Description("初始化")]
            Default,
            /// <summary>
            /// 废票
            /// </summary>
            [Description("废票")]
            Repeal,
            /// <summary>
            /// 退票
            /// </summary>
            [Description("退票")]
            Refund,
            /// <summary>
            /// 已废
            /// </summary>
            [Description("已废")]
            Repealed,
            /// <summary>
            /// 已退
            /// </summary>
            [Description("已退")]
            Refunded,
            /// <summary>
            /// 审核
            /// </summary>
            [Description("审核")]
            Audit
        }
        #endregion

        #region 团队票
        /// <summary>
        /// 团队票状态
        /// </summary>
        public enum TearmOrderStatus
        {
            /// <summary>
            /// 取消订单
            /// </summary>
            [Description("取消订单")]
            Cancel = -1,
            /// <summary>
            /// 提交申请
            /// </summary>
            [Description("提交申请")]
            Apply = 1,
            /// <summary>
            /// 等待支付
            /// </summary>
            [Description("等待支付")]
            WaitPay = 5,
            /// <summary>
            /// 支付成功
            /// </summary>
            [Description("支付成功")]
            SuccPay = 6,
            /// <summary>
            /// 出票成功
            /// </summary>
            [Description("出票成功")]
            Finish = 10
        };
        #endregion

        #region 行程单
        /// <summary>
        /// 配送类型
        /// </summary>
        public enum ExpressType
        {
            /// <summary>
            /// 快递
            /// </summary>
            [Description("快递")]
            Distribution = 1,
            /// <summary>
            /// 自取
            /// </summary>
            [Description("自取")]
            TheDoor = 2
        }

        /// <summary>
        /// 行程单获取方式
        /// </summary>
        public enum JourneyMode
        {
            /// <summary>
            /// 邮寄[另加10元]
            /// </summary>
            [Description("邮寄")]
            Post = 1,
            /// <summary>
            /// 自取
            /// </summary>
            [Description("自取")]
            SelfGet = 2,
            /// <summary>
            /// 保留
            /// </summary>
            [Description("保留")]
            Keep = 3
        }
        #endregion


        /// <summary>
        /// TODO:这个和User.Role里面的类型是有冲突的，后续需要处理下
        /// 账户类型  
        /// </summary>
        public enum PlantType
        {
            /// <summary>
            /// 平台
            /// </summary>
            [Description("平台")]
            Platform = 1,
            /// <summary>
            /// 供应商
            /// </summary>
            [Description("供应商")]
            Provide = 2,
            /// <summary>
            /// 采购商
            /// </summary>
            [Description("采购商")]
            Purchase = 3
        }

    }
}
