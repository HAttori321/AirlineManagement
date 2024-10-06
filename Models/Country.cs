namespace AirlineManagement.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        public int? CityId { get; set; }
        public virtual City City { get; set; }
    }
}