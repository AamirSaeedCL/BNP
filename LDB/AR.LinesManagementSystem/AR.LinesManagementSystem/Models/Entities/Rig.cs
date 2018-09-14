using AR.LinesManagementSystem.Api.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class Rig : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Location { get; set; }
        public string Operator { get; set; }

        public RigType RigType { get; set; }

        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }

    }
}