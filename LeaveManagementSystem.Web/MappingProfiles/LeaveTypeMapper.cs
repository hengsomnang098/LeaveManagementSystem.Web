using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using Riok.Mapperly.Abstractions;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    [Mapper]
    public partial class LeaveTypeMapper
    {
        public partial LeaveTypeReadOnlyVm DetailDto(LeaveType leaveType);

        public partial List<LeaveTypeReadOnlyVm> LeaveTypeDtos(List<LeaveType> leaveTypes);

        public partial LeaveType LeaveTypeCreateDto(LeaveTypeCreateVM leaveTypeCreateVM);

        public partial LeaveType LeaveTypeEditDto(LeaveTypeEditVM leaveTypeEditVM);

        public partial LeaveTypeEditVM ToEditViewModel(LeaveType entity);

        public partial LeaveType ToEntity(LeaveTypeEditVM vm);
    }
}
