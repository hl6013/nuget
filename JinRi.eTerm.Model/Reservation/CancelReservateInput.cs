using System;
using System.Runtime.Serialization;


namespace JinRi.eTerm.Model.Reservation
{
    
    public class CancelReservateInput
    {
        
        public string OrderNo { get; set; }
        
        public string PNRCode { get; set; }
    }
}
