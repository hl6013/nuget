
using JinRi.Enum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JinRi.eTerm.Model.PNR
{
    /// <summary>
    /// PNR解析结果
    /// </summary>
    public class PNRAnalysDto
    {
        /// <summary>
        /// 行程类型
        /// </summary>
        public Product.FlightType FlightType { get; set; }
        /// <summary>
        /// 行程详细
        /// </summary>
        public List<FlightTrip> FlightTrips { get; set; }
        /// <summary>
        /// 乘机人信息
        /// </summary>
        public List<Passenger> Passengers { get; set; }
        /// <summary>
        /// 运价信息
        /// </summary>
        public Freight Freight { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string CTCT { get; set; }
        /// <summary>
        /// 联系手机
        /// </summary>
        public string CTCM { get; set; }
        /// <summary>
        /// PNRCode
        /// </summary>
        public string PNRCode { get; set; }

        /// <summary>
        /// OfficeID
        /// </summary>
        public string OfficeID { get; set; }

        /// <summary>
        /// 大编码
        /// </summary>
        public string Largecode { get; set; }

        /// <summary>
        /// 是否IT票面
        /// </summary>
        public bool IsITFare { get; set; }
        /// <summary>
        /// 是否Net运价
        /// </summary>
        public bool IsNetPrice { get; set; }

        /// <summary>
        /// 行程类型
        /// </summary>
        public Eterm.TripType TripType { get; set; }
    }


    public class FlightTrip:Trip
    {

    }

    
}
