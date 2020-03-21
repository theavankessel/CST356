public static class BusinessRules
{
    public static bool isSpecial(Student student) =>
        student.Email.ToLower().StartsWith("p");
}