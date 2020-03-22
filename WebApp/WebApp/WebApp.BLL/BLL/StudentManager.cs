using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.Repository.Repository;

namespace WebApp.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _StudentRepository = new StudentRepository();

        public bool Add(Student student)
        {
            return _StudentRepository.Add(student);
        }

        public bool Delete(int id)
        {
            return _StudentRepository.Delete(id);
        }

        public bool Update(Student student)
        {
            return _StudentRepository.Update(student);
        }

        public List<Student> GetAll()
        {
            return _StudentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return _StudentRepository.GetById(id);
        }
    }
}
