using AutoMapper;
using EnigmaCore.Interface;
using EnigmaCore.Model;
using EnigmaData.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaService.DefaultService
{
    public class StudentService : IStudent
    {
        private readonly SchoolContext _schoolContext;
        private IMapper _mapper;
        public StudentService(SchoolContext schoolContext, IMapper mapper)
        {
            _schoolContext = schoolContext;
            _mapper = mapper;
        }

        public void DeleteStudent(int studentId)
        {
            var student = _schoolContext.Students.FirstOrDefault(x => x.StudentId == studentId);

            if (student != null)
            {
                _schoolContext.Students.Remove(student);
                _schoolContext.SaveChanges();
            }
        }

        public List<StudentModel> GetAllStudent()
        {
            var listStudent = _schoolContext.Students.ToList();

            var studentModelList = _mapper.Map<List<StudentModel>>(listStudent);

            return studentModelList;
        }

        public void SaveStudent(StudentModel studentModel)
        {
            var student = _mapper.Map<Student>(studentModel);

            _schoolContext.Students.Add(student);
            _schoolContext.SaveChanges();
        }

        public void UpdateStudent(StudentModel studentModel)
        {
            var student = _mapper.Map<Student>(studentModel);

            _schoolContext.Students.Update(student);
            _schoolContext.SaveChanges();
        }

        public List<StudentModel> GetByPage(int Page, int PageSize)
        {
            var listStudent = _schoolContext.Students
                .Where(w=>w.StudentId > 0)
                .OrderBy(o=>o)
                .Skip(Page)
                .Take(PageSize)
                .ToList();

            var studentModelList = _mapper.Map<List<StudentModel>>(listStudent);

            return studentModelList;
        }
    }
}



//var studentModelList = new List<StudentModel>();
//foreach (var item in listStudent)
//{
//    var student = new StudentModel();
//    student.StudentId = item.StudentId;
//    student.Name = item.Name;

//    studentModelList.Add(student);
//}