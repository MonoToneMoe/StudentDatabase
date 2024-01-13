using StudentDatabase.Models;
using StudentDatabase.Services.Students;
using Microsoft.AspNetCore.Mvc;

namespace StudentDatabase.Controllers;

[ApiController]
[Route("[controller]")]

public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route("GetStudents")]
    public List<Student> GetStudents()
    {
        return _studentService.GetStudents();
    }

    [HttpPost] // use Post to add Data
    [Route("AddStudent/{StudentFirstName}/{StudentLastName}/{StudentHobby}")] // To pass data through Routes add /{parameter name}
    public List<Student> AddStudent(string StudentFirstName, string StudentLastName, string StudentHobby)
    {
        return _studentService.AddStudent(StudentFirstName, StudentLastName, StudentHobby);
    }

    [HttpDelete]
    [Route("DeleteStduent/{StudentFirstName}")]
    public List<Student> DeleteStudent(string StudentFirstName)
    {
        return _studentService.DeleteStudent(StudentFirstName);
    }
}