using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AR.LinesManagementSystem.Api.Migrations
{
    public partial class initialDatabaseStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AntennaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntennaCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AntennaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntennaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CircuitTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CircuitTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectivityCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectivityCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectivityProviderTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectivityProviderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectivityPurposes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectivityPurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectivitySiteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectivitySiteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectivityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectivityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    EndDate = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    StartDate = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BandwidthCode = table.Column<string>(maxLength: 250, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Rate = table.Column<decimal>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryLocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiversityLevels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiversityLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ISPTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISPTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LineStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Networks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Networks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ownership",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ownership", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RigTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RigTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SatelliteServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatelliteServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    IsPreLoadedInRequest = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceConnectionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceConnectionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    ContactCellPhone = table.Column<string>(nullable: true),
                    ContactEmailAddress = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactTelephone = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(maxLength: 250, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: true),
                    CountryCode = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Department = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 250, nullable: true),
                    GIN = table.Column<string>(maxLength: 8, nullable: true),
                    GeoSite = table.Column<string>(maxLength: 50, nullable: true),
                    Geomarket = table.Column<string>(maxLength: 50, nullable: true),
                    JobCode = table.Column<string>(maxLength: 50, nullable: true),
                    JobTitle = table.Column<string>(maxLength: 250, nullable: true),
                    LastName = table.Column<string>(maxLength: 250, nullable: true),
                    ManagerGIN = table.Column<string>(maxLength: 8, nullable: true),
                    Segment = table.Column<string>(maxLength: 50, nullable: true),
                    Telephone = table.Column<string>(maxLength: 50, nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubProductLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    ProductLineId = table.Column<int>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubProductLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubProductLines_ProductLines_ProductLineId",
                        column: x => x.ProductLineId,
                        principalTable: "ProductLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rigs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Operator = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    RigTypeId = table.Column<int>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rigs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rigs_RigTypes_RigTypeId",
                        column: x => x.RigTypeId,
                        principalTable: "RigTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcceptedDate = table.Column<DateTimeOffset>(nullable: false),
                    AccessBandWidth = table.Column<string>(maxLength: 250, nullable: true),
                    AssociatedCircuitId = table.Column<short>(nullable: false),
                    BandWidth = table.Column<string>(maxLength: 250, nullable: true),
                    CircuitNumber = table.Column<string>(maxLength: 250, nullable: false),
                    ConfirmDeliveryDate = table.Column<DateTimeOffset>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    DateSubmitted = table.Column<DateTimeOffset>(nullable: false),
                    DeliveryCategoryId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    EntityInformation = table.Column<string>(maxLength: 500, nullable: true),
                    EntitySiteCode = table.Column<string>(maxLength: 250, nullable: true),
                    EsCircuit = table.Column<string>(maxLength: 500, nullable: true),
                    LineStatusId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NonESSharingEntity = table.Column<string>(maxLength: 250, nullable: true),
                    PendingDisconnectDate = table.Column<DateTimeOffset>(nullable: false),
                    PendingInstallDate = table.Column<DateTimeOffset>(nullable: false),
                    ServiceTypeId = table.Column<int>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UpgradedCircuitId = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Circuits_DeliveryCategories_DeliveryCategoryId",
                        column: x => x.DeliveryCategoryId,
                        principalTable: "DeliveryCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Circuits_LineStatuses_LineStatusId",
                        column: x => x.LineStatusId,
                        principalTable: "LineStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Circuits_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    RoleIdId = table.Column<int>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    UserIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleIdId",
                        column: x => x.RoleIdId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserIdId",
                        column: x => x.UserIdId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountCode = table.Column<string>(maxLength: 250, nullable: true),
                    AccountingUnit = table.Column<string>(maxLength: 250, nullable: true),
                    ActivityCode = table.Column<string>(maxLength: 250, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AntennaCategoryId = table.Column<int>(nullable: true),
                    AntennaSpaceConstraints = table.Column<string>(nullable: true),
                    AntennaTypeId = table.Column<int>(nullable: true),
                    AntennaTypeOther = table.Column<string>(nullable: true),
                    AssignedSystemAdmin = table.Column<string>(nullable: true),
                    AttachmentFileURL = table.Column<string>(nullable: true),
                    BudgetServiceId = table.Column<int>(nullable: true),
                    BudgetedCost = table.Column<decimal>(nullable: false),
                    BudgetedMonth = table.Column<decimal>(nullable: false),
                    ChargeDetails = table.Column<string>(nullable: true),
                    CityCode = table.Column<string>(maxLength: 250, nullable: true),
                    ContractId = table.Column<int>(nullable: true),
                    CountryCode = table.Column<string>(maxLength: 250, nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: true),
                    CurrencyRate = table.Column<decimal>(nullable: false),
                    DateQuoteReceived = table.Column<DateTimeOffset>(nullable: false),
                    DateQuoteRequested = table.Column<DateTimeOffset>(nullable: false),
                    DateRequierd = table.Column<DateTimeOffset>(nullable: false),
                    DateSubmitted = table.Column<DateTimeOffset>(nullable: false),
                    DeliveryLocation = table.Column<string>(nullable: true),
                    DeliveryLogisticRequirementsProviderDetails = table.Column<string>(nullable: true),
                    DemobilizationRequiredDetail = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    ESApproval = table.Column<string>(nullable: true),
                    EsApprovalDate = table.Column<string>(nullable: true),
                    EsApprovalNotes = table.Column<string>(nullable: true),
                    EsApprover = table.Column<string>(nullable: true),
                    EsApproverSignature = table.Column<string>(nullable: true),
                    GeographyCode = table.Column<string>(maxLength: 250, nullable: true),
                    GeomarketCode = table.Column<string>(maxLength: 250, nullable: true),
                    ITApproval = table.Column<string>(nullable: true),
                    ITApprovalDate = table.Column<DateTimeOffset>(nullable: false),
                    ITApprovalNotes = table.Column<string>(nullable: true),
                    ITApprover = table.Column<string>(nullable: true),
                    ITApproverSignature = table.Column<string>(nullable: true),
                    InBoundBandwidth = table.Column<string>(maxLength: 250, nullable: true),
                    InstallationRequiredDetail = table.Column<string>(nullable: true),
                    IsBudgetService = table.Column<bool>(nullable: false),
                    IsCablingCabinToPoC = table.Column<bool>(nullable: false),
                    IsDemobilizationRequired = table.Column<bool>(nullable: false),
                    IsESApproval = table.Column<bool>(nullable: false),
                    IsEsBilledByProvider = table.Column<bool>(nullable: false),
                    IsEsCircuit = table.Column<bool>(nullable: false),
                    IsITApproval = table.Column<bool>(nullable: false),
                    IsInstallationRequired = table.Column<bool>(nullable: false),
                    IsMaintenanceServiceRequired = table.Column<bool>(nullable: false),
                    IsSiteSurveyRequired = table.Column<bool>(nullable: false),
                    IsTerminalRequired = table.Column<bool>(nullable: false),
                    LicenseResponsibility = table.Column<string>(nullable: true),
                    MaintenanceServiceRequiredDetail = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NewService = table.Column<string>(nullable: true),
                    Number = table.Column<string>(maxLength: 250, nullable: false),
                    NumberOfTerminal = table.Column<string>(nullable: true),
                    OrderDetail = table.Column<string>(nullable: true),
                    OutBoundBandwidth = table.Column<string>(maxLength: 250, nullable: true),
                    OwnershipId = table.Column<int>(nullable: true),
                    PendingDisconnectDate = table.Column<DateTimeOffset>(nullable: false),
                    ProductLineId = table.Column<int>(nullable: true),
                    ProviderId = table.Column<int>(nullable: true),
                    Region = table.Column<string>(maxLength: 250, nullable: true),
                    RelatedServiceCost = table.Column<double>(nullable: false),
                    RelatedServiceId = table.Column<int>(nullable: true),
                    RequestActionId = table.Column<int>(nullable: true),
                    RequestStatusId = table.Column<int>(nullable: true),
                    Requester = table.Column<string>(maxLength: 250, nullable: true),
                    RigId = table.Column<int>(nullable: true),
                    RigTypeId = table.Column<int>(nullable: true),
                    Risk = table.Column<string>(nullable: true),
                    RouterId = table.Column<int>(nullable: true),
                    SLBFinancialApprover = table.Column<string>(nullable: true),
                    SatelliteServiceId = table.Column<int>(nullable: true),
                    SchlumbergerEntity = table.Column<string>(maxLength: 250, nullable: true),
                    ScopeOfService = table.Column<string>(nullable: true),
                    SegmentId = table.Column<int>(nullable: true),
                    ServiceClassId = table.Column<int>(nullable: true),
                    ServiceConnectionDetail = table.Column<string>(nullable: true),
                    ServiceConnectionTypeId = table.Column<int>(nullable: true),
                    ServiceRequestReasonId = table.Column<int>(nullable: true),
                    ServiceTerm = table.Column<string>(nullable: true),
                    ServiceTypeId = table.Column<int>(nullable: true),
                    SiteCode = table.Column<string>(maxLength: 250, nullable: true),
                    SiteSurveyRequiredDetail = table.Column<string>(nullable: true),
                    SpecialDeliveryInstructions = table.Column<string>(nullable: true),
                    SubProductLineId = table.Column<int>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true),
                    SupplierMailingNameId = table.Column<int>(nullable: true),
                    TerminalSLAs = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false),
                    WSCCostDetailsLCBandwidth = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCOneTimeHubCost = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCOneTimeRemoteCost = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCOther1 = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCOther2 = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCOther3 = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCSubTotal = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCTeleport = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCTerminal = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCTotalOneTime = table.Column<decimal>(nullable: false),
                    WSCCostDetailsLCTotalProviderMonthlyCost = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDBandwidth = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDOneTimeHubCost = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDOneTimeRemoteCost = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDOther1 = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDOther2 = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDOther3 = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDSubTotal = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDTeleport = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDTerminal = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDTotalOneTime = table.Column<decimal>(nullable: false),
                    WSCCostDetailsUSDTotalProviderMonthlyCost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_AntennaCategories_AntennaCategoryId",
                        column: x => x.AntennaCategoryId,
                        principalTable: "AntennaCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_AntennaTypes_AntennaTypeId",
                        column: x => x.AntennaTypeId,
                        principalTable: "AntennaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_BudgetServices_BudgetServiceId",
                        column: x => x.BudgetServiceId,
                        principalTable: "BudgetServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Ownership_OwnershipId",
                        column: x => x.OwnershipId,
                        principalTable: "Ownership",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_ProductLines_ProductLineId",
                        column: x => x.ProductLineId,
                        principalTable: "ProductLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Services_RelatedServiceId",
                        column: x => x.RelatedServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_RequestActions_RequestActionId",
                        column: x => x.RequestActionId,
                        principalTable: "RequestActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_RequestStatuses_RequestStatusId",
                        column: x => x.RequestStatusId,
                        principalTable: "RequestStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Rigs_RigId",
                        column: x => x.RigId,
                        principalTable: "Rigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_RigTypes_RigTypeId",
                        column: x => x.RigTypeId,
                        principalTable: "RigTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Routers_RouterId",
                        column: x => x.RouterId,
                        principalTable: "Routers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_SatelliteServices_SatelliteServiceId",
                        column: x => x.SatelliteServiceId,
                        principalTable: "SatelliteServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Segments_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "Segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_ServiceClasses_ServiceClassId",
                        column: x => x.ServiceClassId,
                        principalTable: "ServiceClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_ServiceConnectionType_ServiceConnectionTypeId",
                        column: x => x.ServiceConnectionTypeId,
                        principalTable: "ServiceConnectionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Reasons_ServiceRequestReasonId",
                        column: x => x.ServiceRequestReasonId,
                        principalTable: "Reasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_SubProductLines_SubProductLineId",
                        column: x => x.SubProductLineId,
                        principalTable: "SubProductLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_Suppliers_SupplierMailingNameId",
                        column: x => x.SupplierMailingNameId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_DeliveryCategoryId",
                table: "Circuits",
                column: "DeliveryCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_LineStatusId",
                table: "Circuits",
                column: "LineStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_ServiceTypeId",
                table: "Circuits",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AntennaCategoryId",
                table: "Requests",
                column: "AntennaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AntennaTypeId",
                table: "Requests",
                column: "AntennaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_BudgetServiceId",
                table: "Requests",
                column: "BudgetServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ContractId",
                table: "Requests",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CurrencyId",
                table: "Requests",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_OwnershipId",
                table: "Requests",
                column: "OwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ProductLineId",
                table: "Requests",
                column: "ProductLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ProviderId",
                table: "Requests",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RelatedServiceId",
                table: "Requests",
                column: "RelatedServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestActionId",
                table: "Requests",
                column: "RequestActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RequestStatusId",
                table: "Requests",
                column: "RequestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RigId",
                table: "Requests",
                column: "RigId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RigTypeId",
                table: "Requests",
                column: "RigTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_RouterId",
                table: "Requests",
                column: "RouterId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SatelliteServiceId",
                table: "Requests",
                column: "SatelliteServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SegmentId",
                table: "Requests",
                column: "SegmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceClassId",
                table: "Requests",
                column: "ServiceClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceConnectionTypeId",
                table: "Requests",
                column: "ServiceConnectionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceRequestReasonId",
                table: "Requests",
                column: "ServiceRequestReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceTypeId",
                table: "Requests",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SubProductLineId",
                table: "Requests",
                column: "SubProductLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SupplierId",
                table: "Requests",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_SupplierMailingNameId",
                table: "Requests",
                column: "SupplierMailingNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Rigs_RigTypeId",
                table: "Rigs",
                column: "RigTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubProductLines_ProductLineId",
                table: "SubProductLines",
                column: "ProductLineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleIdId",
                table: "UserRoles",
                column: "RoleIdId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserIdId",
                table: "UserRoles",
                column: "UserIdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "CircuitTypes");

            migrationBuilder.DropTable(
                name: "ConnectivityCategories");

            migrationBuilder.DropTable(
                name: "ConnectivityProviderTypes");

            migrationBuilder.DropTable(
                name: "ConnectivityPurposes");

            migrationBuilder.DropTable(
                name: "ConnectivitySiteTypes");

            migrationBuilder.DropTable(
                name: "ConnectivityTypes");

            migrationBuilder.DropTable(
                name: "DeliveryLocation");

            migrationBuilder.DropTable(
                name: "DeliveryTypes");

            migrationBuilder.DropTable(
                name: "DiversityLevels");

            migrationBuilder.DropTable(
                name: "ISPTypes");

            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "DeliveryCategories");

            migrationBuilder.DropTable(
                name: "LineStatuses");

            migrationBuilder.DropTable(
                name: "AntennaCategories");

            migrationBuilder.DropTable(
                name: "AntennaTypes");

            migrationBuilder.DropTable(
                name: "BudgetServices");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Ownership");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "RequestActions");

            migrationBuilder.DropTable(
                name: "RequestStatuses");

            migrationBuilder.DropTable(
                name: "Rigs");

            migrationBuilder.DropTable(
                name: "Routers");

            migrationBuilder.DropTable(
                name: "SatelliteServices");

            migrationBuilder.DropTable(
                name: "Segments");

            migrationBuilder.DropTable(
                name: "ServiceClasses");

            migrationBuilder.DropTable(
                name: "ServiceConnectionType");

            migrationBuilder.DropTable(
                name: "Reasons");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "SubProductLines");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "RigTypes");

            migrationBuilder.DropTable(
                name: "ProductLines");
        }
    }
}
