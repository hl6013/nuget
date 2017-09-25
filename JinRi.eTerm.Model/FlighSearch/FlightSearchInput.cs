
using JinRi.eTerm.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model.FlighSearch
{
    
    public class FlightSearchInput
    {
        /// <summary>
        /// 行程类型
        /// </summary>
        
        public FlightType FlightType { get; set; }
        /// <summary>
        /// 成人数量
        /// </summary>
        
        public int ADTQuantity { get; set; }
        /// <summary>
        /// 儿童数量
        /// </summary>
        
        public int CNNQuantity { get; set; }
        /// <summary>
        /// 行程信息
        /// </summary>
        
        public List<SearchTrip> SearchTrips { get; set; }
    }


    
    public class SearchTrip
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
        /// 出发日期
        /// </summary>
        
        public string DepDate { get; set; }


    }
}
