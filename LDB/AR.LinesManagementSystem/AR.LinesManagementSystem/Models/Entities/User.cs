using AR.LinesManagementSystem.Api.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class User : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Alias { get; set; }



        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string FirstName { get; set; }


        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string LastName { get; set; }



        [StringLength(8, ErrorMessage = ErrorMessage.FieldLength)]
        public string GIN { get; set; }



        [StringLength(50, ErrorMessage = ErrorMessage.FieldLength)]
        public string Email { get; set; }



        [StringLength(50, ErrorMessage = ErrorMessage.FieldLength)]
        public string Segment { get; set; }


        [StringLength(10, ErrorMessage = ErrorMessage.FieldLength)]
        public string Area { get; set; }


        [StringLength(50, ErrorMessage = ErrorMessage.FieldLength)]
        public string Geomarket { get; set; }



        [StringLength(50, ErrorMessage = ErrorMessage.FieldLength)]
        public string JobCode { get; set; }

        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string JobTitle { get; set; }

        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Department { get; set; }


        [StringLength(8, ErrorMessage = ErrorMessage.FieldLength)]
        public string ManagerGIN { get; set; }


        [StringLength(50, ErrorMessage = ErrorMessage.FieldLength)]
        public string Telephone { get; set; }

        [StringLength(50, ErrorMessage = ErrorMessage.FieldLength)]
        public string CountryCode { get; set; }

        [StringLength(50, ErrorMessage = ErrorMessage.FieldLength)]
        public string GeoSite { get; set; }

    }
}