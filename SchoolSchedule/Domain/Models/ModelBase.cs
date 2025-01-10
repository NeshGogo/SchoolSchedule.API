
namespace Domain.Models;

public abstract class ModelBase : IId, IAudit
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string UpdatedBy { get; set; }
}
