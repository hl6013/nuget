using JinRi.Enum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model
{
    public class Trip
    {
        /// <summary>
        /// 出发机场三字码
        /// </summary>

        public string DepCode { get; set; }

        /// <summary>
        /// 出发机场
        /// </summary>
        public string DepAiport { get; set; }

        /// <summary>
        /// 到达机场三字码
        /// </summary>

        public string ArrCode { get; set; }

        /// <summary>
        /// 抵达机场
        /// </summary>
        public string ArrAiport { get; set; }

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
        /// 机型大小
        /// </summary>
        public Product.CraftWidthType CraftWidthType { get; set; }
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
        /// 舱位
        /// </summary>
        public string Cabin { get; set; }
    }
}
