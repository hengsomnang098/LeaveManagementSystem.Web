namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVm : BaseLeaveTypeVm
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfDays { get; set; }
    }
}
