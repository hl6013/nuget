using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model.Reservation
{
    /// <summary>
    /// 获取定位信息
    /// </summary>
    
    public class GetReservateInput
    {
        
        public string OrderNo { get; set; }
        
        public string PNRCode { get; set; }
    }
}
