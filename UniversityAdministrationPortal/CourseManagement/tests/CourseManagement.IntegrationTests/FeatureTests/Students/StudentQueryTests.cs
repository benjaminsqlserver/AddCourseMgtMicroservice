namespace CourseManagement.IntegrationTests.FeatureTests.Students;

using CourseManagement.SharedTestHelpers.Fakes.Student;
using CourseManagement.Domain.Students.Features;
using Domain;
using FluentAssertions.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class StudentQueryTests : TestBase
{
    [Fact]
    public async Task can_get_existing_student_with_accurate_props()
    {
        // Arrange
        var testingServiceScope = new TestingServiceScope();
        var studentOne = new FakeStudentBuilder().Build();
        await testingServiceScope.InsertAsync(studentOne);

        // Act
        var query = new GetStudent.Query(studentOne.Id);
        var student = await testingServiceScope.SendAsync(query);

        // Assert
        student.FirstName.Should().Be(studentOne.FirstName);
        student.LastName.Should().Be(studentOne.LastName);
        student.Email.Should().Be(studentOne.Email);
        student.PhoneNumber.Should().Be(studentOne.PhoneNumber);
        student.MatriculationNumber.Should().Be(studentOne.MatriculationNumber);
        student.GenderId.Should().Be(studentOne.GenderId);
    }

    [Fact]
    public async Task get_student_throws_notfound_exception_when_record_does_not_exist()
    {
        // Arrange
        var testingServiceScope = new TestingServiceScope();
        var badId = Guid.NewGuid();

        // Act
        var query = new GetStudent.Query(badId);
        Func<Task> act = () => testingServiceScope.SendAsync(query);

        // Assert
        await act.Should().ThrowAsync<NotFoundException>();
    }
}