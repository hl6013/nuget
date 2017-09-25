using System;
using System.Runtime.Serialization;

namespace JinRi.eTerm.Model.Reservation
{
    
     
    public class BaseInput
    {
        
        public String OrderNo { get; set; }

    }

    
    public class ReservateInput : BaseInput
    {
        
    }

    
    public class ReservateByObjInput : BaseInput
    {
        
        public OrderDetailMdl OrderDetail { get; set; }
    }


}
