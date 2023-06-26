using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionRepository_0506
{
    public class StudentData
    {
        private IStudentRepository _studentRepository;

        public StudentData()
        {
            
        }

        public StudentData(IStudentRepository repo)
        {
            _studentRepository = repo;
        }

        public IStudentRepository Repository { 
            get {
                return _studentRepository;
            } 
            set { 
                _studentRepository = value;
            } 
        }

        public IEnumerable<Student> Students => _studentRepository.GetAll();

        public void Save(List<Student> students)
        {
            _studentRepository.Save(students);
        }

        public Student? Get(int id)
        {
            return _studentRepository.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public void SetRepository(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}
