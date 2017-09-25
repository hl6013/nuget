
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace JinRi.eTerm.Model.Reservation
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
        ADU = 1,
        /// <summary>
        /// 儿童
        /// </summary>
        [Description("儿童")]
        CHD = 2,
        /// <summary>
        /// 婴儿
        /// </summary>
        [Description("婴儿")]
        INF = 3
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

    
    public class SegmentMdl
    {
        /// <summary>
        /// 出发机场三字码
        /// </summary>
        
        public string DepCode { get; set; }
        /// <summary>
        /// 到达机场三字码
        /// </summary>
        
        public string ArrCode { get; set; }
        /// <summary>
        /// 航班号
        /// </summary>
        
        public string FlightNo { get; set; }
        /// <summary>
        /// 航空公司
        /// </summary>
        
        public string Aircom { get; set; }
        /// <summary>
        /// 出发时间
        /// </summary>
        
        public string DepTime { get; set; }
        /// <summary>
        /// 舱位
        /// </summary>
        
        public CabinMdl[] Cabins { get; set; }
    }

    
    public class CabinMdl
    {
        /// <summary>
        /// 舱位等级
        /// </summary>
        
        public string Level { get; set; }
    }

    
    public class FlightSegmentMdl
    {
        /// <summary>
        /// 航程
        /// </summary>
        
        public int SegmentNumber { get; set; }
        /// <summary>
        /// 航程所属航段
        /// </summary>
        
        public SegmentMdl[] SegmentList { get; set; }
    }

    
    public class TicketMdl
    {
        
        public FlightPassengerMdl FlightPassenger { get; set; }
    }

    
    public class FlightPassengerMdl
    {
        
        public string Name { get; set; }
        
        public string Birthday { get; set; }
        
        public string NationCode { get; set; }
        
        public int PassengerType { get; set; }
        
        public int Sexual { get; set; }
        
        public string PsptEndDate { get; set; }
        
        public string IdentifyNumber { get; set; }
    }

    
    public class OrderDetailMdl
    {
        /// <summary>
        /// 航班航程
        /// </summary>
        
        public FlightSegmentMdl[] FlightSegments { get; set; }
        /// <summary>
        /// 乘机人
        /// </summary>
        
        public FlightPassengerMdl[] Passengers { get; set; }
        /// <summary>
        /// 订单联系人
        /// </summary>
        
        public OrderContactMdl OrderContacts { get; set; }

    }
    
    public class OrderContactMdl
    {
        /// <summary>
        /// 联系人姓名
        /// </summary>
        
        public string ContactName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        
        public string Mobile { get; set; }
    }
}