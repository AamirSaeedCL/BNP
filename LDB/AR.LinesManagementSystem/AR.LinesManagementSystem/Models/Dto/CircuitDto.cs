using AR.LinesManagementSystem.Api.Models.Dto;

namespace AR.LinesManagementSystem.Models.Dto
{
    public class CircuitDto : BaseEntityWithAudit
    {
        public string CurcuitId { get; set; }
        public string Description { get; set; }

        public float AccessBandWidth { get; set; }
        public float PortBandWidth { get; set; }

        public ConnectivityTypeDto ConnectivityType { get; set; }

        public ConnectivityProviderTypeDto ConnectivityProviderType { get; set; }

        public ConfigurationDto ConnectivityCategory { get; set; }

        public ConnectivitySiteTypeDto ConnectivitySiteType { get; set; }

        public ConnectivityPurposeDto ConnectivityPurpose { get; set; }
        public DiversityLevelDto DiversityLevel { get; set; }

        public string DiversityLevelComments { get; set; }

        public ISPTypeDto ISPType { get; set; }
        public ProviderDto Provider { get; set; }
        public string Comments { get; set; }
    }
}