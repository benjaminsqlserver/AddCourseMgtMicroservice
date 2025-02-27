namespace CourseManagement.Domain.Instructors.Models;

using Destructurama.Attributed;

public sealed record InstructorForUpdate
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

}
