using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinRi.eTerm.Model
{
    /// <summary>
    /// 税收明细
    /// </summary>

    public class TaxDetail
    {
        public string TaxType { get; set; }
        public decimal Tax { get; set; }
    }
}
