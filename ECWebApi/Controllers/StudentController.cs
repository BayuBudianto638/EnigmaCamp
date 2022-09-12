using EnigmaCore.Interface;
using EnigmaCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _studentService;

        public StudentController(IStudent studentService)
        {
            _studentService = studentService;
        }

        [HttpGet(Name = "GetAllStudent")]
        [Produces("application/json")]
        public List<StudentModel> GetAllStudent()
        {
            var studentList = _studentService.GetAllStudent();

            return studentList;
        }

        [HttpPost(Name = "SaveStudent")]
        public void SaveStudent([FromBody] StudentModel studentModel)
        {
            _studentService.SaveStudent(studentModel);
        }


        [HttpPost(Name = "SaveStudent")]
        public void UpdateStudent([FromBody] StudentModel studentModel)
        {
            _studentService.UpdateStudent(studentModel);
        }
    }
}
