
using System;
using System.Collections.Generic;

namespace JinRi.eTerm.Model.Reservation
{
    public class GetReservateDto
    {
        public string PNRCode { get; set; }
        public List<ReservatePassenger> Passengers { get; set; }
        public List<ReservateFlightInfo> Flights { get; set; }
    }

    public class ReservatePassenger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }

        //public string PassengerType
        //{
        //    get
        //    {
        //        return PNRHelper.GetPasserType(Sex);
        //    }
        //}
    }

    public class ReservateFlightInfo
    {
        public string FlightNo { get; set; }
        public string Cabin { get; set; }
        public string Week { get; set; }

        public AirportInfo Depart { get; set; }

        public AirportInfo Arrivele { get; set; }

    }

    public class AirportInfo
    {
        public string PortIataCode { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
