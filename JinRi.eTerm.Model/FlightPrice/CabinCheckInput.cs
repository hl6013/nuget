
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model.FlightPrice
{
    
     
    public class CabinCheckInput
    {
        
        public List<FlightCabinInput> FlightCabinInputs { get; set; }
    }
    public class FlightCabinInput
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
        /// 乘客人数
        /// </summary>
        
        public int PassengerNum { get; set; }

    }
}
