namespace AirlineManagement.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}