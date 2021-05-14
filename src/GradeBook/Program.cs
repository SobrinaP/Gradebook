using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sobrina's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.3);
            book.AddGrade(77.5);
            var statistics = book.GetStatistics();

                        
            //Print grades to console
            Console.WriteLine($"Highest grade = {statistics.High}");
            Console.WriteLine($"Lowest grade = {statistics.Low}");            
            Console.WriteLine($"Average grade = {statistics.Average}");
        }
    }
}
