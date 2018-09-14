using AR.LinesManagementSystem.Api.Models.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class Contract : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = "Name cannot be longer than 250 characters.")]
        public string Name { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }
    }
}