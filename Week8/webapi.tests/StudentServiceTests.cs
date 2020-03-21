using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTests
{
    private StudentService _studentService;
    private IStudentRepository _studentRepository;

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();
        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void ShouldReturnSpecialStudents()
    {
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 100,
                    Email = "pbc@g.com"
                },
                new Student {
                    StudentId = 10,
                    Email = "pallie@gmail.com"
                }
            }
        );

        var studentViewModels = _studentService.GetAllStudents();

        Assert.That(studentViewModels.Any(s => s.Special), Is.EqualTo(true));

        studentViewModels.Any(s => s.Special).Should().BeTrue();
    }

    [Test]
    public void ShouldNotReturnSpecialStudents()
    {
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 2,
                    Email = "abc@g.com"
                },
                new Student {
                    StudentId = 1,
                    Email = "wallie@gmail.com"
                }
            }
        );

        var studentViewModels = _studentService.GetAllStudents();

        Assert.That(studentViewModels.Any(s => s.Special), Is.EqualTo(false));

        studentViewModels.Any(s => s.Special).Should().BeFalse();
    }
}