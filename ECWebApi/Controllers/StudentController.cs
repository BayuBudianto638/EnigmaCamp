using ECWebApi.Model;
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

        [HttpGet("GetAllStudent")]
        [Produces("application/json")]
        public List<StudentModel> GetAllStudent()
        {
            var studentList = _studentService.GetAllStudent();

            return studentList;
        }

        [HttpPost("SaveStudent")]
        public void SaveStudent([FromBody] StudentModel studentModel)
        {
            _studentService.SaveStudent(studentModel);
        }

        [HttpPost("UpdateStudent")]
        public void UpdateStudent([FromBody] StudentModel studentModel)
        {
            _studentService.UpdateStudent(studentModel);
        }

        [HttpGet("GetByPage")]
        [Produces("application/json")]
        public List<StudentModel> GetByPage(int Page, int PageSize)
        {
            var studentList = _studentService.GetByPage(Page, PageSize);

            return studentList;
        }
    }
}
