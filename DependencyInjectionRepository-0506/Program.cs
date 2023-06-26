namespace DependencyInjectionRepository_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository repo = new StudentJsonRepository(@"Data\student.json");

            var student1 = new Student
            {
                Id = 1,
                Name = "Gusts",
                Surname = "Linkevich",
            };

            var student2 = new Student
            {
                Id = 2,
                Name = "Jhon",
                Surname = "Abdula",
            };

            var students = new List<Student> { student1, student2 };

            var list = repo.GetAll();
        }
    }
}