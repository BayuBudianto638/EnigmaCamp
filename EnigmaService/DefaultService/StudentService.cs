﻿using AutoMapper;
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
            var student = new Student()
            {
                Name = studentModel.Name
            };

            _schoolContext.Students.Add(student);
            _schoolContext.SaveChanges();
        }

        public void UpdateStudent(StudentModel studentModel)
        {
            var student = _schoolContext.Students.FirstOrDefault(w => w.Name == studentModel.Name);

            if (student != null)
            {
                student = new Student()
                {
                    Name = studentModel.Name
                };

                _schoolContext.Students.Update(student);
                _schoolContext.SaveChanges();
            };
        }
    }
}
