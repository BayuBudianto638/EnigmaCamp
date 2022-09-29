using EnigmaCore.Helper;
using EnigmaCore.Interface;
using EnigmaCore.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Net.NetworkInformation;

namespace ECWebApi.Controllers
{
    [Route("Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _studentService;

        public StudentController(IStudent studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("GetAllStudent")]
        [SwaggerOperation("GetAllStudent")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        [Produces("application/json")]
        [Authorize]
        public IActionResult GetAllStudent()
        {
            try
            {
                var studentList = _studentService.GetAllStudent();

                return Requests.Response(this, new ApiStatus(200), studentList, "");
            }
            catch(Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }

        [HttpPost("SaveStudent")]
        [SwaggerOperation("SaveStudent")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        [Authorize]
        public IActionResult SaveStudent([FromBody] StudentModel studentModel)
        {
            try
            {
                _studentService.SaveStudent(studentModel);

                return Requests.Response(this, new ApiStatus(200), "Success", "Success");
            }
            catch(Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }
    }
}
