using System;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student()
                {
                    StudentName = "John"
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            Console.WriteLine("Student saved successfully!");
            Console.ReadKey();
        }
    }
}
