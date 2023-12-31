using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFistExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                context.Database.CreateIfNotExists();

                var student = new Student
                {
                    Name = "Sally Smith",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added: " + student.Name);
            }


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
