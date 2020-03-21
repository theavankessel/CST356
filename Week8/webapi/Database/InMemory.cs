using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
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