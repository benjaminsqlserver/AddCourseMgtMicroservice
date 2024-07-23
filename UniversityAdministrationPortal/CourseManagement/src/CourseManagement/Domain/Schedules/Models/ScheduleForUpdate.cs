namespace CourseManagement.Domain.Schedules.Models;

using Destructurama.Attributed;

public sealed record ScheduleForUpdate
{
    public DateTime ClassTiming { get; set; }
    public string Location { get; set; }
    public Guid CourseID { get; set; }
    public Guid InstructorID { get; set; }
}
