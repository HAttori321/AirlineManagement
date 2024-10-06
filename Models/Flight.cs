namespace AirlineManagement.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public int AccountId { get; set; }
        public int CityId { get; set; }
        public int AirplaneTypeId { get; set; }

        public virtual Account Account { get; set; }
        public virtual City City { get; set; }
        public virtual AirplaneType AirplaneType { get; set; }
    }
}