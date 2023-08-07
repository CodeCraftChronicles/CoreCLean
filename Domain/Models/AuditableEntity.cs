using CoreClean.BCL.Domaine.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreClean.BCL.Domaine.Models;

public abstract class AuditableEntity<TId> : IAuditableEntity<TId>
{       
    public TId Id { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedOn { get; init; } = DateTime.UtcNow;
    public string? LastModifiedBy { get; set; } = null;
    public DateTime? LastModifiedOn { get; set; } = null;    
    public bool IsDeleted { get; set; } =default;
    public DateTime? DeletedOn { get; set; }
    public string? DeletedBy { get; set; }
}
