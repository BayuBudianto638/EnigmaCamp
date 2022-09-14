using EnigmaService.DefaultService;

namespace EnigmaTest
{
    public class StudentServiceTest
    {
        [Fact]
        public void Test1()
        {
            var studentService = new StudentService();

            var a = studentService.GetAllStudent();

            Assert.NotNull(a);
        }
    }
}