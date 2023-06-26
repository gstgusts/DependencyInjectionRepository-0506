using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionRepository_0506
{
    public class MockStudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetAll()
        {
            return new List<Student> {
            new Student
            {
                Id = 1,
                Name = "Test",
                Surname = "Test"
            },
             new Student
            {
                Id = 1,
                Name = "Test",
                Surname = "Test"
            }
            };
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public void Save(List<Student> students)
        {
            throw new NotImplementedException();
        }
    }
}
