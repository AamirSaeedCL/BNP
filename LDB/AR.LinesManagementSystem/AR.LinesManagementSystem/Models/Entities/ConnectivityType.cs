using AR.LinesManagementSystem.Api.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class ConnectivityType : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Name { get; set; }
        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }
    }
}