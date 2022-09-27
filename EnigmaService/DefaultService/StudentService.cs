using AutoMapper;
using EnigmaCore.Interface;
using EnigmaCore.Model;
using EnigmaData.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public (bool, string) SaveStudent(StudentModel studentModel)
        {
            try
            {
                var student = _mapper.Map<Student>(studentModel);

                _schoolContext.Database.BeginTransaction();

                _schoolContext.Students.Add(student);
                _schoolContext.SaveChanges();

                _schoolContext.Database.CommitTransaction();
                return (true, "Success");
            }
            catch (DbException ex)
            {
                _schoolContext.Database.RollbackTransaction();
                return (false, "Error");
            }
        }

        public void UpdateStudent(StudentModel studentModel)
        {
            try
            {
                var student = _mapper.Map<Student>(studentModel);

                _schoolContext.Database.BeginTransaction();

                _schoolContext.Students.Update(student);
                _schoolContext.SaveChanges();

                _schoolContext.Database.CommitTransaction();
            }
            catch (DbException ex)
            {
                _schoolContext.Database.RollbackTransaction();
            }
        }
    }
}
