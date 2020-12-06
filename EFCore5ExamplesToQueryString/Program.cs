using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EFCore5ExamplesToQueryString
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new Ef5ExampleDbContext();

            //var students = new List<Student>
            //{
            //    new Student
            //    {
            //        Name="Ramil",
            //    },
            //    new Student
            //    {
            //        Name="Yusif",
            //    },
            //    new Student
            //    {
            //        Name="Ilham",
            //    },
            //    new Student
            //    {
            //        Name="Sənan",
            //    },
            //    new Student
            //    {
            //        Name="Mahir",
            //    }
            //};

            //dbContext.AddRange(students);
            //dbContext.SaveChanges();

            var studentsQuery = dbContext.Students.Where(x => x.Name.Contains("i"));

            var students = studentsQuery.ToList();

            var studentsQueryString = dbContext.Students.Where(x => x.Name.Contains("i")).ToQueryString();
        }
    }
}
