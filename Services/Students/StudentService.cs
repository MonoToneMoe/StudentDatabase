using StudentDatabase.Data;
using StudentDatabase.Models;

namespace StudentDatabase.Services.Students;
public class StudentService : IStudentService
{
    private readonly DataContext _db;

    public StudentService(DataContext db) // Injecting our DataContext file, which represents our Database
    {
        _db = db;
    }

    public List<Student> AddStudent(string StudentFirstName, string StudentLastName, string StudentHobby)
    {
        Student newStudent = new();
        newStudent.FirstName = StudentFirstName;
        newStudent.LastName = StudentLastName;
        newStudent.Hobby = StudentHobby;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string StudentFirstName)
    {
        var foundStudent = _db.Students.FirstOrDefault(student => student.FirstName == StudentFirstName);
        if(foundStudent != null) {
            _db.Students.Remove(foundStudent);
            _db.SaveChanges();
        }

        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }
}