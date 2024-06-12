using BlazorSqlitePOC.Models;

namespace BlazorSqlitePOC.Data;
public static class DbInitializer
{
    public static void Initialize(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        // Look for any pictures.
        if (context.Students.Any())
        {
            return;   // DB has been seeded
        }

        List<Student> students = [
            new Student { Id = 1, Name = "John Doe", UniversityName = "University A", Faculty = "Engineering", Department = "Computer Science", Email = "john.doe@universitya.edu" },
            new Student { Id = 2, Name = "Jane Smith", UniversityName = "University B", Faculty = "Arts", Department = "Literature", Email = "jane.smith@universityb.edu" },
            new Student { Id = 3, Name = "Alice Johnson", UniversityName = "University C", Faculty = "Science", Department = "Physics", Email = "alice.johnson@universityc.edu" }
        ];

        context.Students.AddRange(students);

        context.SaveChanges();
    }
}