namespace DependencyInjectionRepository_0506
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();

        void Save(Student student);

        void Save(List<Student> students);
    }
}
