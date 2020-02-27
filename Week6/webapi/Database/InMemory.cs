using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "100",
                EmailAddress = "tom.smith@school.com"
            },
            new Student {
                Id = 2,
                StudentId = "200",
                EmailAddress = "mary.jones@school.com"
            },
            new Student {
                Id = 3,
                StudentId = "300",
                EmailAddress = "johndoe@hotmail.com"
            },
            new Student {
                Id = 4,
                StudentId = "400",
                EmailAddress = "nataliejenkins@gmail.com"
            },
            new Student {
                Id = 5,
                StudentId = "500",
                EmailAddress = "mexwell@aol.com"
            }
        };
        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                FirstName = "Frank",
                MiddleInitial = "E.",
                LastName = "Hall"
            },
            new Instructor {
                Id = 2,
                FirstName = "Eddie",
                MiddleInitial = "P.",
                LastName = "Smith"
            },
            new Instructor {
                Id = 3,
                FirstName = "Joseph",
                MiddleInitial = "L.",
                LastName = "Doe"
            },
            new Instructor {
                Id = 4,
                FirstName = "Mariah",
                MiddleInitial = "H.",
                LastName = "Maxwell"
            },
            new Instructor {
                Id = 5,
                FirstName = "Erika",
                MiddleInitial = "J.",
                LastName = "Ralph"
            }
        };
    }
}