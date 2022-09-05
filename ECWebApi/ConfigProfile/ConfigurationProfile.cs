using AutoMapper;
using EnigmaCore.Model;
using EnigmaData.Database;

namespace ECWebApi.ConfigProfile
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<Student, StudentModel>();
            CreateMap<StudentModel, Student>();
        }
    }
}
