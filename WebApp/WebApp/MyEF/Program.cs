using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.BLL.BLL;

namespace MyEF
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager _studentManager = new StudentManager();

            Student student = new Student()
            {
                Name = "Karim",
                Address = "Mirpur",
                RollNo = "001",
                Age = 25
            };

            //if (_studentManager.Add(student))
            //{
            //    Console.WriteLine("Saved");
            //}
            //else
            //{
            //    Console.WriteLine("Not Saved");
            //}

            //if (_studentManager.Delete(2))
            //{
            //    Console.WriteLine("Deleted");
            //}
            //else
            //{
            //    Console.WriteLine("Not Deleted");
            //}

            //Update

            //student.Id = 2;
            //student.Name = "Yusuf";
            //student.Address = "Dhanmondi";
            //student.Age = 22;
            //student.RollNo = "1000";

            //if (_studentManager.Update(student))
            //{
            //    Console.WriteLine("Updated");
            //}
            //else
            //{
            //    Console.WriteLine("Not Updated");
            //}

            var students = _studentManager.GetAll();
            var aStudent = _studentManager.GetById(4);

            Console.ReadKey();
        }
    }
}
