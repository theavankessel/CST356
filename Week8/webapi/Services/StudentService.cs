using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public List<StudentViewModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentViewModel>();

        foreach(var student in _studentRepository.GetAllStudents())
        {
            studentViewModels.Add(new StudentViewModel {
                StudentId = student.StudentId,
                Email = student.Email,
                Special = BusinessRules.isSpecial(student)
            });
        }

        return studentViewModels;
    }
}