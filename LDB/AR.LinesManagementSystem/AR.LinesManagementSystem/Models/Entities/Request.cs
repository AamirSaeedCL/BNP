using AR.LinesManagementSystem.Api.Models.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace AR.LinesManagementSystem.Models
{
    public class Request : BaseEntityWithAudit
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.FieldRequired)]
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Number { get; set; }
        public string Name { get; set; }
        [StringLength(500, ErrorMessage = ErrorMessage.DescriptionFieldLength)]
        public string Description { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Region { get; set; }
        public DateTimeOffset DateSubmitted { get; set; }
        public RequestStatus RequestStatus { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string Requester { get; set; }
        public string AssignedSystemAdmin { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public String SiteCode { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public String CountryCode { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public String CityCode { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public String GeomarketCode { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string GeographyCode { get; set; }
        public string Address { get; set; }
        public RigType RigType { get; set; }
        public Rig Rig { get; set; }
        public ProductLine ProductLine { get; set; }
        public SubProductLine SubProductLine { get; set; }
        public Router Router { get; set; }
        public Provider Provider { get; set; }
        public Contract Contract { get; set; }
        public string OrderDetail { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string SchlumbergerEntity { get; set; }
        public Supplier Supplier { get; set; }
        public string SLBFinancialApprover { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string AccountingUnit { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string ActivityCode { get; set; }
        public Segment Segment { get; set; }
        public Supplier SupplierMailingName { get; set; }
        public string SpecialDeliveryInstructions { get; set; }
        public string ScopeOfService { get; set; }
        public string Risk { get; set; }
        public string AttachmentFileURL { get; set; }

        public Reason ServiceRequestReason { get; set; }

        public string NewService { get; set; }

        public DateTimeOffset DateRequierd { get; set; }

        public Service RelatedService { get; set; }
        public string ServiceTerm { get; set; }

        public DateTimeOffset PendingDisconnectDate { get; set; }


        public ServiceType ServiceType { get; set; }

        public double RelatedServiceCost { get; set; }

        public string LicenseResponsibility { get; set; }

        public Boolean IsEsCircuit { get; set; }


        public SatelliteService SatelliteService { get; set; }

        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string AccountCode { get; set; }

        public ServiceClass ServiceClass { get; set; }

        public Boolean IsEsBilledByProvider { get; set; }

        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string InBoundBandwidth { get; set; }
        [StringLength(250, ErrorMessage = ErrorMessage.FieldLength)]
        public string OutBoundBandwidth { get; set; }

        public string NumberOfTerminal { get; set; }

        public Boolean IsTerminalRequired { get; set; }

        public Ownership Ownership { get; set; }

        public AntennaCategory AntennaCategory { get; set; }

        public string AntennaSpaceConstraints { get; set; }

        public AntennaType AntennaType { get; set; }

        public string AntennaTypeOther { get; set; }
        public string TerminalSLAs { get; set; }


        public Boolean IsDemobilizationRequired { get; set; }
        public string DemobilizationRequiredDetail { get; set; }
        public Boolean IsInstallationRequired { get; set; }
        public string InstallationRequiredDetail { get; set; }

        public Boolean IsSiteSurveyRequired { get; set; }
        public string SiteSurveyRequiredDetail { get; set; }

        public Boolean IsMaintenanceServiceRequired { get; set; }
        public string MaintenanceServiceRequiredDetail { get; set; }

        public string DeliveryLocation { get; set; }

        public ServiceConnectionType ServiceConnectionType { get; set; }

        public Boolean IsCablingCabinToPoC { get; set; }
        public string ServiceConnectionDetail { get; set; }
        public string DeliveryLogisticRequirementsProviderDetails { get; set; }

        public DateTimeOffset DateQuoteReceived { get; set; }
        public DateTimeOffset DateQuoteRequested { get; set; }

        public Currency Currency { get; set; }
        public decimal CurrencyRate { get; set; }


        public decimal WSCCostDetailsLCBandwidth { get; set; }
        public decimal WSCCostDetailsLCTeleport { get; set; }
        public decimal WSCCostDetailsLCTerminal { get; set; }
        public decimal WSCCostDetailsLCSubTotal { get; set; }
        public decimal WSCCostDetailsLCOther1 { get; set; }
        public decimal WSCCostDetailsLCOther2 { get; set; }
        public decimal WSCCostDetailsLCOther3 { get; set; }

        public decimal WSCCostDetailsLCTotalProviderMonthlyCost { get; set; }
        public decimal WSCCostDetailsLCOneTimeHubCost { get; set; }
        public decimal WSCCostDetailsLCOneTimeRemoteCost { get; set; }
        public decimal WSCCostDetailsLCTotalOneTime { get; set; }


        public decimal WSCCostDetailsUSDBandwidth { get; set; }
        public decimal WSCCostDetailsUSDTeleport { get; set; }
        public decimal WSCCostDetailsUSDTerminal { get; set; }
        public decimal WSCCostDetailsUSDSubTotal { get; set; }
        public decimal WSCCostDetailsUSDOther1 { get; set; }
        public decimal WSCCostDetailsUSDOther2 { get; set; }
        public decimal WSCCostDetailsUSDOther3 { get; set; }

        public decimal WSCCostDetailsUSDTotalProviderMonthlyCost { get; set; }
        public decimal WSCCostDetailsUSDOneTimeHubCost { get; set; }
        public decimal WSCCostDetailsUSDOneTimeRemoteCost { get; set; }
        public decimal WSCCostDetailsUSDTotalOneTime { get; set; }

        public Boolean IsBudgetService { get; set; }
        public BudgetService BudgetService { get; set; }
        public decimal BudgetedCost { get; set; }
        public decimal BudgetedMonth { get; set; }

        public string ChargeDetails { get; set; }
        public Boolean IsESApproval { get; set; }
        public string EsApprover { get; set; }
        public string ESApproval { get; set; }
        public string EsApproverSignature { get; set; }
        public string EsApprovalDate { get; set; }
        public string EsApprovalNotes { get; set; }
        public Boolean IsITApproval { get; set; }
        public string ITApprover { get; set; }
        public string ITApproval { get; set; }
        public string ITApproverSignature { get; set; }
        public DateTimeOffset ITApprovalDate { get; set; }
        public string ITApprovalNotes { get; set; }

        public RequestAction RequestAction { get; set; }

    }

    public enum RequestType
    {
        FSR = 1,
        LPR = 2
    }
}