using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ 1. Aggregation Operator ------------
            // list of cashier sales
            List<CashierSales> salesList = new List<CashierSales>
            {
                new CashierSales { CashierName = "Ram", Sales = 1500 },
                new CashierSales { CashierName = "Sita", Sales = 2000 },
                new CashierSales { CashierName = "Hari", Sales = 1200 },
                new CashierSales { CashierName = "Asha", Sales = 1800 },
            };

            int totalCashiers = salesList.Count();           
            double totalSales = salesList.Sum(s => s.Sales); 
            double maxSales = salesList.Max(s => s.Sales);   
            double minSales = salesList.Min(s => s.Sales);   
            double avgSales = salesList.Average(s => s.Sales); 

            Console.WriteLine("Cashier Sales Summary:");
            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: Rs. {totalSales}");
            Console.WriteLine($"Highest Sale: Rs. {maxSales}");
            Console.WriteLine($"Lowest Sale: Rs. {minSales}");
            Console.WriteLine($"Average Sale: Rs. {avgSales}");
            
            // ------------ 2. Quantifier Operators ------------

            // list of applicants
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant { Name = "Ram", Age = 17 },
                new Applicant { Name = "Sita", Age = 19 },
                new Applicant { Name = "Hari", Age = 16 },
            };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);  // any applicant smaller then 18
            bool allAbove16 = applicants.All(a => a.Age > 16);  // all applicants bigger then 16

            Console.WriteLine("\nApplicant Age Check:");
            Console.WriteLine($"Any applicant under 18? {anyUnder18}");
            Console.WriteLine($"All applicants above 16? {allAbove16}");

            // ------------ 3. Element Operators ------------

            // list of songs
            List<Music> songs = new List<Music>
            {
                new Music { Title = "Song A", DurationInSeconds = 180 }, // 3 min
                new Music { Title = "Song B", DurationInSeconds = 250 }, // 4:10 min
                new Music { Title = "Song C", DurationInSeconds = 300 }, // 5 min
                new Music { Title = "Song D", DurationInSeconds = 600 }, // 10 min
            };

            var firstSong = songs.First();                    
            var lastSong = songs.Last();                          
            var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240);
            var safeFirstAbove10Min = songs.FirstOrDefault(s => s.DurationInSeconds > 600); // first > 10 min safely

            Console.WriteLine("\nMusic Song Info:");
            Console.WriteLine($"First Song: {firstSong.Title}");
            Console.WriteLine($"Last Song: {lastSong.Title}");
            Console.WriteLine($"First song longer than 4 min: {firstAbove4Min.Title}");
            Console.WriteLine($"First song longer than 10 min (safe): {(safeFirstAbove10Min != null ? safeFirstAbove10Min.Title : "None")}");
        }
    }
}
