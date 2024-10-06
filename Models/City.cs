using System.Diagnostics.Metrics;

namespace AirlineManagement.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}