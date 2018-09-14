using AR.LinesManagementSystem.Api.Models.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class UserRole : BaseEntityWithAudit
    {

        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }
        public User UserId { get; set; }
        public Role RoleId { get; set; }
    }
}