using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // -------1. Select-------
            // list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // square each number
            var squared = numbers.Select(n => n * n);

            // print squared numbers
            Console.WriteLine("Squared Numbers:");
            foreach (var num in squared)
            {
                Console.WriteLine(num);
            }
            
            // -------2. Where-------
            // list of books
            List<Book> books = new List<Book>
            {
                new Book { Title = "C# Basics", Price = 800 },
                new Book { Title = "Advanced C#", Price = 1500 },
                new Book { Title = "Database Systems", Price = 1200 },
                new Book { Title = "LINQ Mastery", Price = 600 }
            };

            // filter premium books
            var premiumBooks = books.Where(b => b.Price > 1000);

            // print books
            Console.WriteLine("\nPremium Books:");
            foreach (var b in premiumBooks)
            {
                Console.WriteLine($"{b.Title} - Rs. {b.Price}");
            }
            
            // -------3. OrderBy-------
            // list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ram" },
                new Student { Name = "Sita" },
                new Student { Name = "Hari" },
                new Student { Name = "Shyam" },
            };

            // sort by name
            var sortedStudents = students.OrderBy(s => s.Name);

            // print sorted
            Console.WriteLine("\nSorted Students:");
            foreach (var s in sortedStudents)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
