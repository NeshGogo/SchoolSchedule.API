namespace Domain.Models;

public class Teacher : ModelBase
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public ICollection<Subject> Subjects { get; set; }
}
