using AR.LinesManagementSystem.Api.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class Supplier : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Name { get; set; }
        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }

        public string Address { get; set; }

        public string ContactName { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactCellPhone { get; set; }
        public string ContactEmailAddress { get; set; }
    }
}