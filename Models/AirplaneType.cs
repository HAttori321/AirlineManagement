namespace AirlineManagement.Models
{
    public class AirplaneType
    {
        public int AirplaneTypeId { get; set; }
        public string Model { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}