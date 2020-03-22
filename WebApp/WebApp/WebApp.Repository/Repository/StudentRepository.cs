using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.DatabaseContext.DatabaseContext;

namespace WebApp.Repository.Repository
{
    public class StudentRepository
    {
        ProjectDbContext _ProjectDbContext = new ProjectDbContext();

        public bool Add(Student student)
        {
            _ProjectDbContext.Students.Add(student);

            return _ProjectDbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            //Pull Id to be deleted
            Student aStudent = _ProjectDbContext.Students.FirstOrDefault(c => c.Id == id);

            _ProjectDbContext.Students.Remove(aStudent);

            return _ProjectDbContext.SaveChanges() > 0;
        }

        public bool Update(Student student)
        {
            Student aStudent = _ProjectDbContext.Students.FirstOrDefault(c => c.Id == student.Id);
            if(aStudent != null)
            {
                aStudent.RollNo = student.RollNo;
                aStudent.Name = student.Name;
                aStudent.Address = student.Address;
                aStudent.Age = student.Age;
            }
            return _ProjectDbContext.SaveChanges() > 0;
        }

        public List<Student> GetAll()
        {
            //List<Student> students = new List<Student>();
            return _ProjectDbContext.Students.ToList();
        }

        public Student GetById(int id)
        {
            //Student student = new Student();
            return _ProjectDbContext.Students.FirstOrDefault(c => c.Id == id);
        }
    }
}
