using DataTypes;
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
        public List<StudentModel> GetAllStudent()
        {
            var studentList = _studentService.GetAllStudent();

            return studentList;
        }
    }
}
