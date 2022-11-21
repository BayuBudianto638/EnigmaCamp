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

        //[Route("GetAllStudent")]
        [HttpGet("GetAllStudent")]
        [Produces("application/json")]
        public List<StudentModel> GetAllStudent()
        {
            var studentList = _studentService.GetAllStudent();

            return studentList;
        }

        [Route("SaveStudent")]
        [HttpPost]
        public void SaveStudent([FromBody] StudentModel model)
        {
            _studentService.SaveStudent(model);
        }

        [Route("UpdateStudent")]
        [HttpPatch]
        public void UpdateStudent([FromBody] StudentModel model)
        {
            _studentService.UpdateStudent(model);
        }

        [Route("DeleteStudent")]
        [HttpDelete]
        public void DeleteStudent(int studentId)
        {
            _studentService.DeleteStudent(studentId);
        }
    }
}
