namespace DependencyInjectionRepository_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IStudentRepository repo = new StudentJsonRepository(@"Data/students.json");

            IStudentRepository repoXml = new StudentXmlRepository(@"Data/students.xml");

            var list = repoXml.GetAll();

            foreach (var item in list) {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }

            // repoXml.Save(list.ToList());
        }
    }
}