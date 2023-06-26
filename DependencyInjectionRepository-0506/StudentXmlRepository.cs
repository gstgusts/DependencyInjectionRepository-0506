using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DependencyInjectionRepository_0506
{
    public class StudentXmlRepository : IStudentRepository
    {
        private string _filePath;
        public StudentXmlRepository(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<Student> GetAll()
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var reader = new StreamReader(_filePath))
            {
                var result = serializer.Deserialize(reader);

                if(result != null)
                {
                    return (List<Student>)result;
                }

                return Enumerable.Empty<Student>();
            }

        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public void Save(List<Student> students)
        {
            var serializer = new XmlSerializer(typeof(List<Student>));

            using (var writer = new StreamWriter(_filePath))
            {
                serializer.Serialize(writer, students);
            }
        }
    }
}
