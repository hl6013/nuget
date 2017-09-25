using System.ComponentModel;

namespace JinRi.Enum.Common
{
    public class Http
    {
        /// <summary>
        /// 返回代码
        /// </summary>
        public enum ReturnCode
        {
            /// <summary>
            /// 远程请求失败
            /// </summary>
            [Description("远程请求失败")]
            Fail = -1,

            /// <summary>
            /// 数据操作失败
            /// </summary>
            [Description("数据操作失败")]
            Data_Operation_Error = -2,

            /// <summary>
            /// 表示成功
            /// </summary>
            [Description("成功")]
            SUCCESS = 0,
            /// <summary>
            /// 系统错误，未知服务异常。
            /// </summary>
            [Description("系统错误，未知服务异常。")]
            SYSTEM_ERROR = 1,
            /// <summary>
            /// 安全验证错误，不符合安全校验规则。
            /// </summary>
            [Description("安全验证错误，不符合安全校验规则。")]
            SECURITY_CHECK_ERROR = 2,
            /// <summary>
            /// 输入参数为空或错误。
            /// </summary>
            [Description("输入参数为空或错误。")]
            INPUT_INVALID = 3,
            /// <summary>
            /// 非授权合作商户。（合作商户merchant_id错误）
            /// </summary>
            [Description("非授权合作商户。")]
            MERCHANT_ILLEGAL = 4,
            /// <summary>
            /// 备注不能超过100个字符。
            /// </summary>
            [Description("备注不能超过100个字符。")]
            REMARK_INVALID = 5,
            /// <summary>
            /// 访问限制，访问频率过高，被禁止。
            /// </summary>
            [Description("访问限制，访问频率过高，被禁止。")]
            ACCESS_FORBID = 6,
            /// <summary>
            /// 合作商户余额不足，暂时停用，请充值后通知服务商重新启用！
            /// </summary>            
            BALANCE_LESS = 7,

            /// <summary>
            /// 登录异常
            /// </summary>
            [Description("登录异常")]
            LOGIN_EXCEPTION = 10,
            /// <summary>
            /// 用户名或密码错误
            /// </summary>
            [Description("用户名或密码错误")]
            LOGIN_ERROR = 11,
            /// <summary>
            /// 用户名已存在
            /// </summary>
            [Description("用户名已存在")]
            ACCOUNT_EXIST = 12,
            /// <summary>
            /// 用户名不存在
            /// </summary>
            [Description("用户名不存在")]
            ACCOUNT_NOT_EXIST = 13,
            /// <summary>
            /// 原密码错误
            /// </summary>
            [Description("原密码错误")]
            ORIGINAL_PWD_ERROR = 14,

            /// <summary>
            /// 常旅客已存在
            /// </summary>
            [Description("常旅客已存在")]
            PASSENGER_EXIST = 20,
            /// <summary>
            /// 常旅客不存在
            /// </summary>
            [Description("常旅客不存在")]
            PASSENGER_NOT_EXIST = 21,
            /// <summary>
            /// 非该用户的常旅客
            /// </summary>
            [Description("非该用户的常旅客")]
            PASSENGER_ILLEGAL = 22,
            /// <summary>
            /// 常旅客姓名重复
            /// </summary>
            [Description("常旅客姓名重复")]
            PASSENGER_NAME_REPEAT = 23,
            /// <summary>
            /// 常旅客证件号码重复
            /// </summary>
            [Description("常旅客证件号码重复")]
            PASSENGER_IDNUM_REPEAT = 24,
            /// <summary>
            /// 后台用户不存在
            /// </summary>
            [Description("后台用户不存在")]
            ADMIN_USER_NO_EXISTS = 25,

            /// <summary>
            /// 订单查询其他异常(除1x能够表示的状态之外的状态)
            /// </summary>
            [Description("订单查询其他异常")]
            QUERY_ORDER_ABNORMITY = 100,
            /// <summary>
            /// 余票查询参数输入错误。
            /// </summary>
            [Description("余票查询参数输入错误。")]
            QUERY_TICKET_PARAM = 101,
            /// <summary>
            /// 输入车站名为空，请确认!
            /// </summary> 
            [Description("输入车站名为空，请确认!")]
            STATION_INPUT_NULL = 102,
            /// <summary>
            /// 出发车站错误。
            /// </summary>
            [Description("出发车站错误。")]
            DEP_ERR = 103,
            /// <summary>
            /// 到达车站错误。
            /// </summary>
            [Description("到达车站错误。")]
            ARR_ERR = 104,
            /// <summary>
            /// 输入车站名错误，请确认
            /// </summary>
            [Description("输入车站名错误，请确认")]
            STATIN_INPUT_INVALID = 105,
            /// <summary>
            /// 查询返回数据失败，暂无列车信息
            /// </summary>
            [Description("查询返回数据失败，暂无列车信息")]
            NO_TRAIN_INFO = 106,
            /// <summary>
            /// 车次信息有误，暂无该列车信息
            /// </summary>
            [Description("车次信息有误，暂无该列车信息")]
            TRAIN_NUMBER = 107,
            /// <summary>
            /// 下订单其他异常(除1x能够表示的状态之外的状态)
            /// </summary>
            [Description("下订单其他异常")]
            ORDER_ABNORMITY = 200,
            /// <summary>
            /// 重复下单异常
            /// </summary>
            [Description("重复下单异常")]
            DUPLICATE_ORDER = 201,
            /// <summary>
            /// 不在受理时间内，拒绝下订单操作，请在规定时间执行此操作。
            /// </summary>
            [Description("不在受理时间内，拒绝下订单操作，请在规定时间执行此操作。")]
            TIME_OUT_REFUSE_ORDER = 202,
            /// <summary>
            /// 一个订单最多允许订购五张票。
            /// </summary>
            [Description("一个订单最多允许订购五张票。")]
            FIVE_LIMIT = 203,
            /// <summary>
            /// 查询订单其他异常（除2x能够表示的状态之外的状态）
            /// </summary>
            [Description("查询订单其他异常（除2x能够表示的状态之外的状态）")]
            QUERY_ORDER_ABNORMITY_OTHER = 300,
            /// <summary>
            /// 订单未找到（订单号错误或不存在）
            /// </summary>
            [Description("订单未找到（订单号错误或不存在）")]
            ORDER_NO_FIND = 301,
            /// <summary>
            /// 非该用户订单
            /// </summary>
            [Description("非该用户订单")]
            ORDER_OWNER_ERROR = 302,
            /// <summary>
            /// 取消订单其他异常（除3x能够表示的状态之外的状态)
            /// </summary>
            [Description("取消订单其他异常")]
            CANCEL_ORDER_ABNORMITY = 400,
            /// <summary>
            /// 订单已出票成功，无法取消，请走退票退款流程。
            /// </summary>
            [Description("订单已出票成功，无法取消，请走退票退款流程。")]
            ORDER_OUT_CANT_CANCEL = 401,
            /// <summary>
            /// 不在受理退款时间内，拒绝取消订单操作, 请在规定时间执行此操作。
            /// </summary>
            [Description("不在受理退款时间内，拒绝取消订单操作, 请在规定时间执行此操作。")]
            TIME_OUT_NO_CANCEL = 402,
            /// <summary>
            /// 查询途经站信息其他异常(除5x能够表示的状态之外的状态)
            /// </summary>
            [Description("查询途经站信息其他异常")]
            SEARCH_STATION_ABNORMITY = 500,
            /// <summary>
            /// 暂时没有该途经站信息。
            /// </summary>
            [Description("暂时没有该途经站信息。")]
            TEMP_NO_STATION_INFO = 501,
            /// <summary>
            /// 支付过程其他异常(除6x能够表示的状态之外的状态)
            /// </summary>
            [Description("支付过程其他异常")]
            PAYING_ABNORMITY = 600,
            /// <summary>
            /// 支付金额与下单时支付金额不符。
            /// </summary>
            [Description("支付金额与下单时支付金额不符。")]
            PAY_ORDER_AMOUNT_NO_MATCH = 601,
            /// <summary>
            /// 该订单已经支付成功，拒绝重复支付。 
            /// </summary>
            [Description("该订单已经支付成功，拒绝重复支付。")]
            ORDER_PAYED = 602,
            /// <summary>
            /// 没有开通预定中支付订单权限。 
            /// </summary>
            [Description("没有开通预定中支付订单权限。")]
            NO_ORDER_PAY_AUTH = 603,
            /// <summary>
            /// 超过约定支付有效时间期，该订单已禁止支付。
            /// </summary>
            [Description("超过约定支付有效时间期，该订单已禁止支付。")]
            TIMEOUT_PAY = 604,
            /// <summary>
            /// 保险查询过程其他异常(除7x能够表示的状态之外的状态)
            /// </summary>
            [Description("保险查询过程其他异常")]
            INSURANCE_ABNORMITY = 700,
            /// <summary>
            /// 订单下无相关保险信息 
            /// </summary>
            [Description("订单下无相关保险信息 ")]
            ORDER_NO_INSURANCE_INFO = 701,
            /// <summary>
            /// 改签过程其他异常(除8x能够表示的状态之外的状态)
            /// </summary>
            [Description("改签过程其他异常")]
            CHANGE_ABNORMITY = 800,
            /// <summary>
            /// 拒绝不存在订单改签和重复申请订单改签。 
            /// </summary>
            [Description("拒绝不存在订单改签和重复申请订单改签")]
            REFUSE_NO_EXISTE_ORDER = 801,
            /// <summary>
            /// 出票成功的订单才可以申请改签。 
            /// </summary>
            [Description("出票成功的订单才可以申请改签")]
            OUT_TICKET_CAN_CHANGE = 802,
            /// <summary>
            /// 航班信息不存在
            /// </summary>
            [Description("航班信息不存在")]
            FLIGHT_INFO_NO_EXSTIS = 803,

            /// <summary>
            /// 记录已存在
            /// </summary>
            [Description("记录已存在")]
            RECORD_EXSITS = 805,
            /// <summary>
            /// 记录不存在
            /// </summary>
            [Description("记录不存在")]
            RECORD_NOT_EXSITS = 806,

            /// <summary>
            /// 非法请求
            /// </summary>
            [Description("非法请求")]
            ILLEGAL_REQUEST = 999,
            /// <summary>
            /// 订单超出支付时间段
            /// </summary>
            [Description("订单超出支付时间段")]
            ORDER_OUT_PAY_PERIOD = 1101,
            /// <summary>
            /// 订单状态错误
            /// </summary>
            [Description("订单状态错误")]
            ORDER_STATUS_ERROR = 1102,
            /// <summary>
            /// 退款失败
            /// </summary>
            [Description("退款失败")]
            Refund_Fail = 1201,

        }
    }
}
