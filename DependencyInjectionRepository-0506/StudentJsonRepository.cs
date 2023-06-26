using Newtonsoft.Json;
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
            var json = File.ReadAllText(_filePath);

            var result = JsonConvert.DeserializeObject<List<Student>>(json);

            if(result != null)
            {
                return result;
            }

            return Enumerable.Empty<Student>();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public void Save(List<Student> students)
        {
            var json = JsonConvert.SerializeObject(students, Formatting.Indented);

            File.WriteAllText(_filePath, json);
        }
    }
}
