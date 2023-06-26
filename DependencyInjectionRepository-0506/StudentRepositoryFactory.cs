using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionRepository_0506
{
    public class StudentRepositoryFactory
    {
        public static IStudentRepository Create()
        {
            var repoToCreate = ConfigurationManager.AppSettings["RepoType"];

            Console.WriteLine(repoToCreate);

            switch (repoToCreate)
            {
                case "JSON":
                    return new StudentJsonRepository(@"Data/students.json");
                case "XML":
                    return new StudentXmlRepository(@"Data/students.xml");
                default:
                    return new StudentJsonRepository(@"Data/students.json");
            }
            
        }
    }
}
