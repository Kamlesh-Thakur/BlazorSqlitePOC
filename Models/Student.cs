using System.ComponentModel.DataAnnotations;

namespace BlazorSqlitePOC.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string UniversityName { get; set; } = string.Empty;
    public string Faculty { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
