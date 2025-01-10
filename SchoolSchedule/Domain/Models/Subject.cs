namespace Domain.Models;

public class Subject : ModelBase
{
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public int HoursPerWeek { get; set; }
}
