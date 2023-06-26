namespace DependencyInjectionRepository_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentJsonRepository(@"Data/students.json");

            var list = repo.GetAll();
        }
    }
}