using StudentDatabase.Models;

namespace StudentDatabase.Services.Students;
public interface IStudentService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string StduentFirstName, string StudentLastName, string StudentHobby);
    List<Student> DeleteStudent(string FirstName);
}