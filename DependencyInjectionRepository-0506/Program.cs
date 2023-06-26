namespace DependencyInjectionRepository_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IStudentRepository repo = new StudentJsonRepository(@"Data/students.json");

            //IStudentRepository repo = new StudentXmlRepository(@"Data/students.xml");

            var repo = StudentRepositoryFactory.Create();

            // inject dependency in constructor
            var data = new StudentData(repo);

            // inject dependency using method
            //var data = new StudentData();
            //data.SetRepository(repo);

            // inject using public property
            //var data = new StudentData();
            //data.Repository = repo;

            var list = data.Students;

            foreach (var item in list) {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }

            // repoXml.Save(list.ToList());
        }
    }
}