
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model.FlightPrice
{
    
    public class FlightPriceQueryInput
    {
        public List<TripDto> Trips { get; set; }
    }

    
     
    public class TripDto
    {
        /// <summary>
        /// 出发城市三字码
        /// </summary>
        public string OrgCityCode { get; set; }
        /// <summary>
        /// 目的城市三字码
        /// </summary>

        public string DstCityCode { get; set; }

        /// <summary>
        /// 航班号不含航司二字码前缀
        /// </summary>

        public string FlightNo { get; set; }

        /// <summary>
        /// 航空公司二字吗
        /// </summary>

        public string Aircom { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>

        public DateTime DepTime { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>

        public DateTime ArrTime { get; set; }

        /// <summary>
        /// 经停次数
        /// </summary>

        public string StopTimes { get; set; }

        /// <summary>
        /// 舱位
        /// </summary>

        public string Cabin { get; set; }


        ///// <summary>
        ///// Eterm日期格式
        ///// </summary>
        //public string EtermDate
        //{
        //    get {
        //        return TimeHelper.GetEtermDate(DepTime);
        //    }
        //}

        /// <summary>
        /// 出发时间 小时分
        /// </summary>
        public string Orgtime
        {
            get
            {
                return DepTime.ToString("hhmm");
            }
        }
        /// <summary>
        /// 到达时间 小时分
        /// </summary>
        public string Dsttime
        {
            get
            {
                return ArrTime.ToString("hhmm");
            }
        }

        /// <summary>
        /// 是否隔天
        /// </summary>
        public string IsAddDay
        {
            get
            {
                return ArrTime.ToString("dd").CompareTo(ArrTime.ToString("dd")) > 0 ? ">" : "<";
            }
        }

    }
}
