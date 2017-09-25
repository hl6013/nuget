using JinRi.Enum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model
{
    public class Passenger
    {
        /// <summary>
        /// 乘机人序号
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// 出身年月
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// 所在国家
        /// </summary>
        public string Nation { get; set; }

        /// <summary>
        /// 所在国家二字码
        /// </summary>
        public string NationCode { get; set; }

        /// <summary>
        /// 乘机人类型
        /// </summary>
        public User.PassengerType PassengerType { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public User.Sexual Sexual { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public User.IdentifyClass IdentifyClass { get; set; }

        /// <summary>
        /// 证件有效期
        /// </summary>
        public string PsptEndDate { get; set; }


        /// <summary>
        /// 证件号码
        /// </summary>
        public string IdentifyNumber { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }


        /// <summary>
        /// 发证国家
        /// </summary>
        public string IssuingCountry{get;set;}
    }
}
