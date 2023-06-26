using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionRepository_0506
{
    public class StudentJsonRepository : IStudentRepository
    {
        private string _filePath;

        public StudentJsonRepository(string path)
        {
            _filePath = path;
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public void Save(List<Student> students)
        {
            var json = new List<Student>();
        }
    }
}
