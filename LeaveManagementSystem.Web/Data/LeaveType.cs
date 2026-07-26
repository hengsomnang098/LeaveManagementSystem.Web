namespace LeaveManagementSystem.Web.Data;

public class LeaveType 
{   
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int NumberOfDays { get; set; }
}