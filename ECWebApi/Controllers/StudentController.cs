﻿using EnigmaCore.Helper;
using EnigmaCore.Interface;
using EnigmaCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

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
        public IActionResult GetAllStudent()
        {
            try
            {
                var studentList = _studentService.GetAllStudent();

                return Requests.Response(this, new ApiStatus(200), studentList, "");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }

        [HttpPost(Name = "SaveStudent")]
        public IActionResult SaveStudent([FromBody] StudentModel studentModel)
        {
            try
            {
                var (isAdded, isMessage) = _studentService.SaveStudent(studentModel);
                if (!isAdded)
                {
                    return Requests.Response(this, new ApiStatus(406), isMessage, "Error");
                }

                return Requests.Response(this, new ApiStatus(200), "Success", "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }
    }
}
