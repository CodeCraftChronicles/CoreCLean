namespace CoreClean.BCL.Domaine.Contracts;
public interface IEntity
{
}

public interface IEntity<TId> : IEntity
{
    public TId Id { get; set; }
}

public interface IAuditableEntity : IEntity
{
    string CreatedBy { get; set; }

    DateTime CreatedOn { get; init; }

    string? LastModifiedBy { get; set; }

    DateTime? LastModifiedOn { get; set; }
    bool IsDeleted { get; set; }
    DateTime? DeletedOn { get; set; }
    public string? DeletedBy { get; set; }
}

public interface IAuditableEntity<TId> : IAuditableEntity, IEntity<TId>
{
}