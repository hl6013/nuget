
using JinRi.eTerm.Model.FlightPrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model.FlighSearch
{
    

    public class CabinCheckDto
    {
        
        public List<FlightCabinDetail> FlightCabinDetails { get; set; }
        
        public FlightPriceDto FlightPrice { get; set; }
    }
    

    public class FlightCabinDetail
    {
        /// <summary>
        ///航班号
        /// </summary>
        
        public string FlightNo { get; set; }

        /// <summary>
        /// 舱位
        /// </summary>
        
        public string Cabin { get; set; }

        /// <summary>
        /// 出发机场三字码
        /// </summary>
        
        public string DepCode { get; set; }

        /// <summary>
        /// 到达机场三字码
        /// </summary>
        
        public string ArrCode { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        
        public string DepDate { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        
        public string DepTime { get; set; }

        /// <summary>
        /// 抵达时间
        /// </summary>
        
        public string ArrTime { get; set; }

        /// <summary>
        /// +天
        /// </summary>
        
        public string AddDay { get; set; }

        /// <summary>
        /// 乘客人数
        /// </summary>
        
        public int PassengerNum { get; set; }
        /// <summary>
        /// 舱位状态
        /// </summary>
        
        public string CabinStatus { get; set; }
    }


}
