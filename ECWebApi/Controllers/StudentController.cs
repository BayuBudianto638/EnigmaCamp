using EnigmaCore.Interface;
using EnigmaCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        //[Route("api/[GetAllStudent]")]
        [HttpGet(Name = "GetAllStudent")]
        [Produces("application/json")]
        public List<StudentModel> GetAllStudent()
        {
            var studentList = _studentService.GetAllStudent();

            return studentList;
        }

        [HttpPost(Name = "SaveStudent")]
        public void SaveStudent([FromBody] StudentModel model)
        {
            _studentService.SaveStudent(model);
        }

        [HttpPatch(Name = "UpdateStudent")]
        public void UpdateStudent([FromBody] StudentModel model)
        {
            _studentService.UpdateStudent(model);
        }

        [HttpDelete(Name = "DeleteStudent")]
        public void DeleteStudent(int studentId)
        {
            _studentService.DeleteStudent(studentId);
        }
    }
}
