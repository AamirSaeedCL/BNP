using AR.LinesManagementSystem.Api.Models.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class ProductLine : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Name { get; set; }
        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }
        public List<SubProductLine> SubProductLine { get; set; }
    }
}