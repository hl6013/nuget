using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JinRi.Enum.Model.Product;

namespace JinRi.eTerm.Model
{
    /// <summary>
    /// 运价价格
    /// </summary>
    public class Freight
    {
        /// <summary>
        /// 票面价
        /// </summary>
        public decimal Fare { get; set; }

        /// <summary>
        /// 税费
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// 税费明细
        /// </summary>
        public List<TaxDetail> TaxDetails { get; set; }

        /// <summary>
        /// 外币币种
        /// </summary>
        public string AbroadCurrency { get; set; }
        /// <summary>
        /// 外币票面价
        /// </summary>
        public decimal AbroadFare { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        public string Rate { get; set; }

        /// <summary>
        /// Nuc总计
        /// </summary>
        public string NucTotal { get; set; }
        /// <summary>
        /// ROE
        /// </summary>
        public string ROE { get; set; }


        public List<FreightDetail> FreightDetails { get; set; }
    }

    public class FreightDetail
    {
        /// <summary>
        /// 序号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 运价代码
        /// </summary>
        public string PriceCode { get; set; }
        /// <summary>
        /// NUC
        /// </summary>
        public string NUC { get; set; }
        /// <summary>
        /// 币种
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 出发城市三字码
        /// </summary>
        public string OrgCity { get; set; }

        /// <summary>
        /// 出发城市国家二字码
        /// </summary>
        public string OrgCountryCode { get; set; }

        /// <summary>
        /// 出发城市
        /// </summary>
        public string OrgCityName { get; set; }

        /// <summary>
        /// 抵达城市三字码
        /// </summary>
        public string ArrCity { get; set; }

        /// <summary>
        /// 抵达城市
        /// </summary>
        public string ArrCityName { get; set; }

        /// <summary>
        /// 抵达城市国家二字码
        /// </summary>
        public string ArrCountryCode { get; set; }
        /// <summary>
        /// 航司二字码
        /// </summary>
        public string Aircom { get; set; }

        /// <summary>
        /// 航司中文名称
        /// </summary>
        public string ArlineName { get; set; }

        /// <summary>
        /// 航司图标地址
        /// </summary>
        public string AirLogo { get; set; }

        /// <summary>
        /// 行程类型
        /// </summary>
        public FlightType FlightType { get; set; }
    }

    
}
