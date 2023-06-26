using DependencyInjectionRepository_0506;

namespace DependencyInjection.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IStudentRepository repo = new MockStudentRepository();
            var data = new StudentData(repo);


        }
    }
}