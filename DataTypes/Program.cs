using EnigmaCore.Interface;
using EnigmaService.DefaultService;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IStudent, StudentService>()
            .BuildServiceProvider();


    }
}