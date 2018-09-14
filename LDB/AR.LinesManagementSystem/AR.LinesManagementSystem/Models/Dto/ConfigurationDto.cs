namespace AR.LinesManagementSystem.Api.Models.Dto
{
    public class ConfigurationDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }

    public class ReasonDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class ConnectivityProviderTypeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ConnectivityPurposeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ConnectivitySiteTypeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ConnectivityTypeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class DiversityLevelDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ISPTypeDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class ProviderDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
