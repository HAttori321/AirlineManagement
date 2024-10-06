using System;
using AirlineManagement.Models;

namespace AirlineManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationContext())
            {
                var account = new Account { Username = "nazar", Password = "123123" };
                var city = new City { Name = "Rivne" };
                var country = new Country { Name = "Ukraine", City = city };
                var airplaneType = new AirplaneType { Model = "Boeing 737" };
                var flight = new Flight { Account = account, City = city, AirplaneType = airplaneType };

                context.Accounts.Add(account);
                context.Cities.Add(city);
                context.Countries.Add(country);
                context.AirplaneTypes.Add(airplaneType);
                context.Flights.Add(flight);

                context.SaveChanges();
            }
            Console.WriteLine("Data has been saved.");
            Console.ReadLine();
        }
    }
}