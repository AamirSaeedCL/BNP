using AR.LinesManagementSystem.Context;
using AR.LinesManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace AR.LinesManagementSystem.DbEntities
{

    public static class DbInitializer
    {

        public static void Initialize(ArDBContext context)
        {
            context.Database.EnsureCreated();//if db is not exist ,it will create database .but ,do nothing .
            // Look for existing connectivity type rows
            if (context.ConnectivityTypes.Any())
            {
                return;   // DB has been seeded
            }
            // 1- feed the conenctivity type rows
            var types = new List<ConnectivityType>() {
                new ConnectivityType { Name = "Internet",  },
                new ConnectivityType { Name = "MAN" },
                new ConnectivityType { Name = "MPLS" },
                new ConnectivityType { Name = "P2P" },
                new ConnectivityType { Name = "Cross-Connect (Physical)" },
                new ConnectivityType { Name = "Cross-Connect (Virtual)" },
                new ConnectivityType { Name = "Cross-Connect (IX/Cloud-Connect (Port))" },
                new ConnectivityType { Name = "Hosting" },
                new ConnectivityType { Name = "Telco-Project Management" },
                new ConnectivityType { Name = "Radio Link" },
                new ConnectivityType { Name = "RTDS" },
                new ConnectivityType { Name = "SAT - BGAN" },
                new ConnectivityType { Name = "SAT - HughesNet" },
                new ConnectivityType { Name = "SAT - iDirect Network" },
                new ConnectivityType { Name = "SAT - LinkStart Network" },
                new ConnectivityType { Name = "SAT - Satlink Network" },
                new ConnectivityType { Name = "SAT - SCPC Link" },
                new ConnectivityType { Name = "SAT - Solante Network" },
                new ConnectivityType { Name = "Cellular" }
            };
            context.ConnectivityTypes.AddRange(types);


            // 2 - feed the ConnectivityProviderType rows
            var providerTypes = new List<ConnectivityProviderType>() {
                new ConnectivityProviderType { Name = "Global" },
                new ConnectivityProviderType { Name = "Local" },
                new ConnectivityProviderType { Name = "SLB-owned" }
            };
            context.ConnectivityProviderTypes.AddRange(providerTypes);


            // 3 - feed the ConnectivityCategories rows
            var connectivityCategories = new List<ConnectivityCategory>() {
                new ConnectivityCategory { Name = "SINET" },
                new ConnectivityCategory { Name = "Internet"},
                new ConnectivityCategory { Name = "E-Net" },
                new ConnectivityCategory { Name = "Hosting" },
                new ConnectivityCategory { Name = "Project Manager"}
            };
            context.ConnectivityCategories.AddRange(connectivityCategories);


            // 4 - feed the Connectivity Site Type rows
            var connectivitySiteTypes = new List<ConnectivitySiteType>() {
                new ConnectivitySiteType { Name = "Branch (Serves only 1 site)" },
                new ConnectivitySiteType { Name = "Hub (Serves multiple sites but is not DC)"},
                new ConnectivitySiteType { Name = "DC" },
                new ConnectivitySiteType { Name = "Field" },
                new ConnectivitySiteType { Name = "Teleport"},
                new ConnectivitySiteType { Name = "Meetme Point"}
            };
            context.ConnectivitySiteTypes.AddRange(connectivitySiteTypes);


            // 5 - feed the Connectivity Purpose rows
            var connectivityPurposes = new List<ConnectivityPurpose>() {
                new ConnectivityPurpose { Name = "Primary Direct SINeT" },
                new ConnectivityPurpose { Name = "Primary VPN SINeT"},
                new ConnectivityPurpose { Name = "Backup VPN SINeT" },
                new ConnectivityPurpose { Name = "VPN-Other" },
                new ConnectivityPurpose { Name = "Direct Client Connectivity"},
                new ConnectivityPurpose { Name = "E-Net/DMZ Hosting Connectivity"},
                new ConnectivityPurpose { Name = "Local Internet Offload"},
                new ConnectivityPurpose { Name = "Regional Internet Gateway"},
                new ConnectivityPurpose { Name = "Cloud Connection (Private)"},
                new ConnectivityPurpose { Name = "Cloud Connection (Public)"},
                new ConnectivityPurpose { Name = "Hosting(equipment)"}
            };
            context.ConnectivityPurposes.AddRange(connectivityPurposes);


            // 6 - feed the DiversityLevel
            var diversityLevels = new List<DiversityLevel>() {
                new DiversityLevel { Name = "Diverse Last Mile" },
                new DiversityLevel { Name = "Shared Last Mile"}
            };
            context.DiversityLevels.AddRange(diversityLevels);

            // 7 - feed the ISPType
            var ispTypes = new List<ISPType>() {
                new ISPType { Name = "Dedicated" },
                new ISPType { Name = "Shared"}
            };
            context.ISPTypes.AddRange(ispTypes);


            // 8 - feed the Provider
            var providers = new List<Provider>() {
                new Provider { Name = "Provider 1" },
                new Provider { Name = "Provider 2"}
            };
            context.Providers.AddRange(providers);

            // 10 - feed the Regions rows
            var rigTypes = new List<RigType>() {
                new RigType { Name = "Barge" },
                new RigType { Name = "Semi-Sub" },
                new RigType { Name = "Drillship" },
                new RigType { Name = "Floater/Tender" },
                new RigType { Name = "Jack Up" },
                new RigType { Name = "Land Rig" },
                new RigType { Name = "Vessel" }
            };
            context.RigTypes.AddRange(rigTypes);

            // 11 - feed the Regions rows
            var productlines = new List<ProductLine>() {
                new ProductLine { Name = "Wellsite Connectivity" },
                new ProductLine { Name = "SLB" },
                new ProductLine { Name = "Geoservices" },
                new ProductLine { Name = "Cameron" },
                new ProductLine { Name = "Smith" },
                new ProductLine { Name = "Wellsite Connectivity" },
            };
            context.ProductLines.AddRange(productlines);
            context.SaveChanges();

            // 11 - feed the Product line
            var subproductlines = new List<SubProductLine>() {
                    new SubProductLine { Name = "WG",
                        ProductLine = context.ProductLines.Where(p => p.Name == "Cameron").FirstOrDefault()
                },
                new SubProductLine { Name = "OFS",
                        ProductLine = context.ProductLines.Where(p => p.Name == "Cameron").FirstOrDefault()
                },
                new SubProductLine { Name = "Geoservices",
                        ProductLine = context.ProductLines.Where(p => p.Name == "Geoservices").FirstOrDefault()
                },
                new SubProductLine { Name = "WG",
                        ProductLine = context.ProductLines.Where(p => p.Name == "SLB").FirstOrDefault()
                },
                new SubProductLine { Name = "OFS",
                        ProductLine = context.ProductLines.Where(p => p.Name == "SLB").FirstOrDefault()

                },
                 new SubProductLine { Name = "MI Drilling",
                        ProductLine = context.ProductLines.Where(p => p.Name == "Smith").FirstOrDefault()
                },
                  new SubProductLine { Name = "MI International",
                        ProductLine = context.ProductLines.Where(p => p.Name == "Smith").FirstOrDefault()
                },
                  new SubProductLine { Name = "Wilson Supply",
                        ProductLine = context.ProductLines.Where(p => p.Name == "Smith").FirstOrDefault()
                },
                new SubProductLine { Name = "Wellsite Connectivity",
                        ProductLine = context.ProductLines.Where(p => p.Name == "Wellsite Connectivity").FirstOrDefault()
                }
            };
            context.SubProductLines.AddRange(subproductlines);

            context.SaveChanges();
        }

    }
}
