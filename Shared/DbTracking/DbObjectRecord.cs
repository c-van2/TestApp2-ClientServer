namespace TestApp2.Shared.DbTracking;

public class DbObjectRecord
{
    public int Id { get; set; }
    public string ObjectType { get; set; } = string.Empty; // Table, View, Stored Procedure
    public string ObjectName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Project { get; set; } = string.Empty;
    public string Environment { get; set; } = string.Empty; // Dev, Prod, Both
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime LastModifiedAt { get; set; }
    public string ModifiedBy { get; set; } = string.Empty;
    public string ChangesNotes { get; set; } = string.Empty;
    public string? Version { get; set; }
    public string SqlScript { get; set; } = string.Empty;
    public string Dependencies { get; set; } = string.Empty;
    public string UsedIn { get; set; } = string.Empty;
}
