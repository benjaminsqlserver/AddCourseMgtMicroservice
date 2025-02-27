namespace CourseManagement.FunctionalTests.FunctionalTests.Students;

using CourseManagement.SharedTestHelpers.Fakes.Student;
using CourseManagement.FunctionalTests.TestUtilities;
using System.Net;
using System.Threading.Tasks;

public class GetStudentTests : TestBase
{
    [Fact]
    public async Task get_student_returns_success_when_entity_exists()
    {
        // Arrange
        var student = new FakeStudentBuilder().Build();
        await InsertAsync(student);

        // Act
        var route = ApiRoutes.Students.GetRecord(student.Id);
        var result = await FactoryClient.GetRequestAsync(route);

        // Assert
        result.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}