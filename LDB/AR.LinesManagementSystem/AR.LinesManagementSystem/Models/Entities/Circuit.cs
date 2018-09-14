using AR.LinesManagementSystem.Api.Models.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class Circuit : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string CircuitNumber { get; set; }

        public string Name { get; set; }


        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string AccessBandWidth { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string BandWidth { get; set; }
        public ServiceType ServiceType { get; set; }
        public LineStatus LineStatus { get; set; }

        public DateTimeOffset PendingInstallDate { get; set; }

        public DateTimeOffset AcceptedDate { get; set; }

        public DateTimeOffset PendingDisconnectDate { get; set; }
        public DateTimeOffset ConfirmDeliveryDate { get; set; }

        public DeliveryCategory DeliveryCategory { get; set; }

        public Int16 AssociatedCircuitId { get; set; }
        public Int16 UpgradedCircuitId { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string NonESSharingEntity { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string EntitySiteCode { get; set; }
        [StringLength(500, ErrorMessage = ErrorMessage.FieldLength)]
        public string EntityInformation { get; set; }
        [StringLength(500, ErrorMessage = ErrorMessage.FieldLength)]
        public string EsCircuit { get; set; }
        public DateTimeOffset DateSubmitted { get; set; }
    }
}