using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model.FlighSearch
{
    
    public class FlightSearchDto
    {
        /// <summary>
        /// 航班信息
        /// </summary>
        
        public List<FlightInfo> FlightInfos { get; set; }
        ///// <summary>
        ///// 总记录数
        ///// </summary>
        //
        //public int FlightCount { get; set; }
    }
    
    public class FlightInfo
    {
        /// <summary>
        /// 序号
        /// </summary>
        
        public int Index { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 航段信息
        /// </summary>
        
        public List<Segment> Segments { get; set; }
        /// <summary>
        /// 价格信息
        /// </summary>
        
        public List<PriceInfo> PriceInfos { get; set; }
    }

    ///// <summary>
    ///// 机型大小
    ///// </summary>
    //
    //public enum CraftWidthType
    //{
    //    /// <summary>
    //    /// 无机型大小
    //    /// </summary>
    //    [Description("无")]
    //    
    //    None = 0,
    //    /// <summary>
    //    /// 大
    //    /// </summary>
    //    [Description("大")]
    //    
    //    L = 1,
    //    /// <summary>
    //    /// 中
    //    /// </summary>
    //    [Description("中")]
    //    
    //    M = 2,
    //    /// <summary>
    //    /// 小
    //    /// </summary>
    //    [Description("小")]
    //    
    //    S = 3
    //}

    ///// <summary>
    ///// 乘机人类型
    ///// </summary>
    //
    //public enum PassengerType
    //{
    //    /// <summary>
    //    /// 成人
    //    /// </summary>
    //    [Description("成人")]
    //    
    //    ADT = 0,
    //    /// <summary>
    //    /// 儿童
    //    /// </summary>
    //    [Description("儿童")]
    //    
    //    CNN = 1
    //}

    
    /// <summary>
    /// 航班信息
    /// </summary>
    public class Segment
    {
        /// <summary>
        /// 出发机场三字码
        /// </summary>

        public string DepCode { get; set; }

        /// <summary>
        /// 出发机场
        /// </summary>
        public string DepName { get; set; }

        /// <summary>
        /// 到达机场三字码
        /// </summary>

        public string ArrCode { get; set; }

        /// <summary>
        /// 抵达机场
        /// </summary>
        public string ArrName { get; set; }

        /// <summary>
        /// 航司logo
        /// </summary>
        public string AirLogo { get; set; }


        /// <summary>
        /// 航司名称
        /// </summary>
        public string ArlineName { get; set; }

        /// <summary>
        /// 出发航站楼
        /// </summary>

        public string DepTerminal { get; set; }
        /// <summary>
        /// 到达航站楼
        /// </summary>

        public string ArrTerminal { get; set; }
        /// <summary>
        /// 航班号
        /// </summary>

        public string FlightNo { get; set; }
        /// <summary>
        /// 航空公司二字码
        /// </summary>

        public string Aircom { get; set; }


        /// <summary>
        /// 航空公司名称
        /// </summary>

        public string AirName { get; set; }

        ///// <summary>
        ///// 机型大小
        ///// </summary>
        //
        //public CraftWidthType CraftWidthType { get; set; }
        /// <summary>
        /// 出发时间
        /// </summary>

        public DateTime DepTime { get; set; }
        /// <summary>
        /// 到达时间
        /// </summary>

        public DateTime ArrTime { get; set; }

        /// <summary>
        /// 到底日期所加天数
        /// </summary>

        public string AddDay { get; set; }

        /// <summary>
        /// 机型
        /// </summary>

        public string AirplaneType { get; set; }


        /// <summary>
        /// 飞行时长
        /// </summary>

        public string Duration { get; set; }

        /// <summary>
        /// 舱位
        /// </summary>

        public string Cabin { get; set; }
        /// <summary>
        /// 舱位数量
        /// </summary>

        public string CabinQuantity { get; set; }

        /// <summary>
        /// 实际承运航班号
        /// </summary>

        public string OPFlightNo { get; set; }

        /// <summary>
        /// 经停次数
        /// </summary>

        public int StopNum { get; set; }

        /// <summary>
        /// 餐食级别
        /// </summary>

        public string FoodGrade { get; set; }

    }

    
    /// <summary>
    /// 价格信息
    /// </summary>
    public class PriceInfo
    {
        /// <summary>
        /// 单张结算价
        /// </summary>
        
        public decimal TicketPrice { get; set; }

        /// <summary>
        /// 票面价
        /// </summary>
        
        public decimal ParPrice { get; set; }
        /// <summary>
        /// 税费
        /// </summary>
        
        public decimal Tax { get; set; }

        /// <summary>
        /// 乘客类型
        /// </summary>
        
        public string PassengerType { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        
        public int Quantity { get; set; }

        /// <summary>
        /// 行李信息
        /// </summary>
        
        public string Bag { get; set; }

        /// <summary>
        /// 代理费率
        /// </summary>
        
        public string Agency { get; set; }

    }
}
