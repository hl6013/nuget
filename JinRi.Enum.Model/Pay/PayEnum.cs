using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.Enum.Pay
{
    /// <summary>
    /// 支付，货币相关枚举
    /// </summary>
    public class PayEnum
    {

        /// <summary>
        /// 币种类型
        /// </summary>
        public enum Currency
        {
            /// <summary>
            /// 人民币
            /// </summary>
            [Description("人民币")]
            RMB = 0,
            /// <summary>
            /// 美元
            /// </summary>
            [Description("美元")]
            USD =1,
            /// <summary>
            /// 港币
            /// </summary>
            [Description("港币")]
            HKD=2,
            /// <summary>
            /// 日元
            /// </summary>
            [Description("日元")]
            JPY =3,
            /// <summary>
            /// 欧元
            /// </summary>
            [Description("欧元")]
            EUR =4,
            /// <summary>
            /// 英镑
            /// </summary>
            [Description("英镑")]
            GBP =5,
            /// <summary>
            /// 泰铢
            /// </summary>
            [Description("泰铢")]
            THB=6,
            /// <summary>
            /// 韩元
            /// </summary>
            [Description("韩元")]
            KRW=7
        }

        /// <summary>
        /// 支付类型
        /// </summary>
        public enum PayType
        {
            /// <summary>
            /// 线下支付
            /// </summary>
            [Description("线下支付")]
            OFFL = 0,
            /// <summary>
            /// 支付宝
            /// </summary>
            [Description("支付宝")]
            ZFB = 1,
            /// <summary>
            /// 支付宝
            /// </summary>
            [Description("微信")]
            WX = 2,
            /// <summary>
            /// 块钱
            /// </summary>
            [Description("快钱")]
            KQ = 3,
            /// <summary>
            /// 财付通
            /// </summary>
            [Description("财付通")]
            CFT = 4
        }

        /// <summary>
        /// 交易类型
        /// </summary>
        public enum TradeType
        {
            /// <summary>
            /// 支付
            /// </summary>
            [Description("支付")]
            Pay = 1,
            /// <summary>
            /// 退款
            /// </summary>
            [Description("退款")]
            Refund = 2,
            /// <summary>
            /// 分润
            /// </summary>
            [Description("分润")]
            Profit = 3,
            /// <summary>
            /// 退分润
            /// </summary>
            [Description("退分润")]
            RefundProfit = 4,
            /// <summary>
            /// 补差
            /// </summary>
            [Description("补差")]
            SendersPay = 5,
            /// <summary>
            /// 退补差
            /// </summary>
            [Description("退补差")]
            RefundSendersPay = 6

        }

        /// <summary>
        /// 补差枚举
        /// </summary>
        public enum SupplStatus
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("补差交易")]
            TradeSuppl = 1,
            /// <summary>
            /// 
            /// </summary>
            [Description("退补差")]
            RefundSuppl = 2
        }

        /// <summary>
        /// 返点类型
        /// </summary>
        public enum SupplType
        {
            /// <summary>
            /// 
            /// </summary>
            [Description("留钱")]
            Policy = 1,
            /// <summary>
            /// 
            /// </summary>
            [Description("代金券")]
            voucher = 2
        }
    }
}
