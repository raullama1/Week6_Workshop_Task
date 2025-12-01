using System;
using System.Collections.Generic;
using System.Linq;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            // list of tour bookings
            
            List<TourBooking> tours = new List<TourBooking>
            {
                new TourBooking { CustomerName = "Ram", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
                new TourBooking { CustomerName = "Sita", Destination = "Thailand", Price = 15000, DurationInDay = 5, IsInternational = true },
                new TourBooking { CustomerName = "Hari", Destination = "Kathmandu", Price = 12000, DurationInDay = 6, IsInternational = false },
                new TourBooking { CustomerName = "Shyam", Destination = "Singapore", Price = 20000, DurationInDay = 4, IsInternational = true },
            };
            
            // Filter
            var filteredTours = tours
                                .Where(t => t.Price > 10000 && t.DurationInDay > 4);
            
            // Transform
            var projectedTours = filteredTours
                                 .Select(t => new
                                 {
                                     t.CustomerName,
                                     t.Destination,
                                     Category = t.IsInternational ? "International" : "Domestic",
                                     t.Price
                                 });
            
            // Sort based on Category then by Price
            var sortedTours = projectedTours
                              .OrderBy(t => t.Category)   // Domestic comes first alphabetically
                              .ThenBy(t => t.Price);      // then by price ascending
            
            // Display tours
            Console.WriteLine("Filtered & Sorted Tour Bookings:");
            foreach (var t in sortedTours)
            {
                Console.WriteLine($"Customer: {t.CustomerName}, Destination: {t.Destination}, Category: {t.Category}, Price: Rs. {t.Price}");
            }
        }
    }
}
