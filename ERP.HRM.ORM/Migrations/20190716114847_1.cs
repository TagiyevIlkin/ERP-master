using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.HRM.ORM.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MobilePhonePin = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ShortName = table.Column<string>(maxLength: 50, nullable: false),
                    Index = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FamilyStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationLegalForm",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationLegalForm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationLegalType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationLegalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Period",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Period", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonApplicationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonApplicationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonelFileType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelFileType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VacationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonPhone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    Number = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPhone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonPhone_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentPosition",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentId = table.Column<int>(nullable: false),
                    ContractTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    VacationDayCount = table.Column<string>(nullable: true),
                    MaterialResponsibilityFile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentPosition_ContractType_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "ContractType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentPosition_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StuctureType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StuctureType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StuctureType_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    FatherName = table.Column<string>(maxLength: 50, nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Residence = table.Column<string>(maxLength: 100, nullable: false),
                    PinCode = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    FamilyStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personel_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personel_FamilyStatus_FamilyStatusId",
                        column: x => x.FamilyStatusId,
                        principalTable: "FamilyStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personel_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrganizationLegalFormId = table.Column<int>(nullable: false),
                    OrganizationLegalTypeId = table.Column<int>(nullable: false),
                    TopOrganizationId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ShortName = table.Column<string>(maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(maxLength: 50, nullable: true),
                    VORN = table.Column<string>(maxLength: 10, nullable: true),
                    Index = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_OrganizationLegalForm_OrganizationLegalFormId",
                        column: x => x.OrganizationLegalFormId,
                        principalTable: "OrganizationLegalForm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organization_OrganizationLegalType_OrganizationLegalTypeId",
                        column: x => x.OrganizationLegalTypeId,
                        principalTable: "OrganizationLegalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationNumber",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonApplicationTypeId = table.Column<int>(nullable: false),
                    PeriodId = table.Column<int>(nullable: false),
                    Prefix = table.Column<string>(nullable: true),
                    LastNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationNumber_Period_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Period",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationNumber_PersonApplicationType_PersonApplicationTypeId",
                        column: x => x.PersonApplicationTypeId,
                        principalTable: "PersonApplicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeNumber = table.Column<string>(nullable: true),
                    JobNumber = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    AdditionalNumber = table.Column<string>(nullable: true),
                    PersonPhoneId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneType_PersonPhone_PersonPhoneId",
                        column: x => x.PersonPhoneId,
                        principalTable: "PersonPhone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonTabel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartmentPositionId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    BeginTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTabel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonTabel_DepartmentPosition_DepartmentPositionId",
                        column: x => x.DepartmentPositionId,
                        principalTable: "DepartmentPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonApplication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromDepartmentPositionId = table.Column<int>(nullable: false),
                    ToDepartmentPositionId = table.Column<int>(nullable: false),
                    PersonApplicationTypeId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    DepartmentPositionId = table.Column<int>(nullable: true),
                    PersonelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonApplication_DepartmentPosition_DepartmentPositionId",
                        column: x => x.DepartmentPositionId,
                        principalTable: "DepartmentPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonApplication_PersonApplicationType_PersonApplicationTypeId",
                        column: x => x.PersonApplicationTypeId,
                        principalTable: "PersonApplicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonApplication_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonelFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonelId = table.Column<int>(nullable: false),
                    PersonelFileTypeId = table.Column<int>(nullable: false),
                    FilePath = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonelFile_PersonelFileType_PersonelFileTypeId",
                        column: x => x.PersonelFileTypeId,
                        principalTable: "PersonelFileType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelFile_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PersonelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialStatus_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonelId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VacationTypeId = table.Column<int>(nullable: false),
                    DepartmentPositionId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    ReplacementPersonId = table.Column<int>(nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    PersonelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacation_DepartmentPosition_DepartmentPositionId",
                        column: x => x.DepartmentPositionId,
                        principalTable: "DepartmentPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vacation_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vacation_VacationType_VacationTypeId",
                        column: x => x.VacationTypeId,
                        principalTable: "VacationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkBook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PositionId = table.Column<int>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkBook_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkBook_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkPlace",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    DepartmentPositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPlace_DepartmentPosition_DepartmentPositionId",
                        column: x => x.DepartmentPositionId,
                        principalTable: "DepartmentPosition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkPlace_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Gence" },
                    { 1, "Baki" },
                    { 2, "Naxcivan" }
                });

            migrationBuilder.InsertData(
                table: "ContractType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Muqavile" },
                    { 2, "Daimi" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "DepartmentId", "Index", "Name", "ShortName" },
                values: new object[] { 1, null, 123456, "Baki Dovlet Universiteti", "BDU" });

            migrationBuilder.InsertData(
                table: "FamilyStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Subay" },
                    { 1, "Evli" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Qadin" },
                    { 2, "Kisi" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationLegalForm",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Korporativ Strategiya" },
                    { 2, "Biznes Fokus" }
                });

            migrationBuilder.InsertData(
                table: "OrganizationLegalType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sehmdarlarin Hedefleri" },
                    { 2, "Maliyye Sektoru" }
                });

            migrationBuilder.InsertData(
                table: "Period",
                columns: new[] { "Id", "BeginDate", "EndDate", "Name" },
                values: new object[] { 1, new DateTime(2019, 7, 16, 15, 48, 46, 994, DateTimeKind.Local).AddTicks(1950), new DateTime(2019, 7, 16, 11, 48, 46, 995, DateTimeKind.Utc).AddTicks(5638), "1-ci sessiya" });

            migrationBuilder.InsertData(
                table: "PersonApplicationType",
                columns: new[] { "Id", "FilePath", "Name" },
                values: new object[] { 1, "C:\\Users\\User\\Downloads\\ERP-master\\ERP-master", "Isden Cixarilma" });

            migrationBuilder.InsertData(
                table: "PersonelFileType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Diplomun kopyasi" });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Web Developer" });

            migrationBuilder.InsertData(
                table: "VacationType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Ezamiyyet" });

            migrationBuilder.InsertData(
                table: "DepartmentPosition",
                columns: new[] { "Id", "ContractTypeId", "DepartmentId", "MaterialResponsibilityFile", "Name", "VacationDayCount" },
                values: new object[] { 1, 1, 1, "File2", "Fexri Doktorlar", "3" });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "Email", "Fax", "Index", "MobileNumber", "Name", "OrganizationLegalFormId", "OrganizationLegalTypeId", "ShortName", "TopOrganizationId", "VORN" },
                values: new object[] { 1, "office@pasha-holding.az", "(+994 12) 505 15 35 ", "5055000", "(+994 12) 505 50 00", "Pasha Holding", 1, 1, "PH", null, "MMC1234" });

            migrationBuilder.InsertData(
                table: "Personel",
                columns: new[] { "Id", "Birthdate", "CityId", "Email", "FamilyStatusId", "FatherName", "Firstname", "GenderId", "Lastname", "PinCode", "Residence", "SerialNumber" },
                values: new object[] { 1, new DateTime(2019, 7, 16, 11, 48, 46, 981, DateTimeKind.Utc).AddTicks(3780), 3, "parviz@gmail.com", 2, "Rovsen", "Parviz", 2, "Aliyev", "123456", "Baki", "123456" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Password", "PersonelId", "Status", "Username" },
                values: new object[] { 1, "01c7cd0d4588b883210ec250a34c06ac", 1, true, "ParvizRA" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationNumber_PeriodId",
                table: "ApplicationNumber",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationNumber_PersonApplicationTypeId",
                table: "ApplicationNumber",
                column: "PersonApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentId",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentPosition_ContractTypeId",
                table: "DepartmentPosition",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentPosition_DepartmentId",
                table: "DepartmentPosition",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_OrganizationLegalFormId",
                table: "Organization",
                column: "OrganizationLegalFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_OrganizationLegalTypeId",
                table: "Organization",
                column: "OrganizationLegalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonApplication_DepartmentPositionId",
                table: "PersonApplication",
                column: "DepartmentPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonApplication_PersonApplicationTypeId",
                table: "PersonApplication",
                column: "PersonApplicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonApplication_PersonelId",
                table: "PersonApplication",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_CityId",
                table: "Personel",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_FamilyStatusId",
                table: "Personel",
                column: "FamilyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_GenderId",
                table: "Personel",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelFile_PersonelFileTypeId",
                table: "PersonelFile",
                column: "PersonelFileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelFile_PersonelId",
                table: "PersonelFile",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPhone_CountryId",
                table: "PersonPhone",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonTabel_DepartmentPositionId",
                table: "PersonTabel",
                column: "DepartmentPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneType_PersonPhoneId",
                table: "PhoneType",
                column: "PersonPhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialStatus_PersonelId",
                table: "SocialStatus",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_StuctureType_DepartmentId",
                table: "StuctureType",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonelId",
                table: "User",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacation_DepartmentPositionId",
                table: "Vacation",
                column: "DepartmentPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacation_PersonelId",
                table: "Vacation",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacation_VacationTypeId",
                table: "Vacation",
                column: "VacationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkBook_OrganizationId",
                table: "WorkBook",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkBook_PositionId",
                table: "WorkBook",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlace_DepartmentPositionId",
                table: "WorkPlace",
                column: "DepartmentPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlace_UserId",
                table: "WorkPlace",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationNumber");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "PersonApplication");

            migrationBuilder.DropTable(
                name: "PersonelFile");

            migrationBuilder.DropTable(
                name: "PersonTabel");

            migrationBuilder.DropTable(
                name: "PhoneType");

            migrationBuilder.DropTable(
                name: "SocialStatus");

            migrationBuilder.DropTable(
                name: "StuctureType");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "WorkBook");

            migrationBuilder.DropTable(
                name: "WorkPlace");

            migrationBuilder.DropTable(
                name: "Period");

            migrationBuilder.DropTable(
                name: "PersonApplicationType");

            migrationBuilder.DropTable(
                name: "PersonelFileType");

            migrationBuilder.DropTable(
                name: "PersonPhone");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "VacationType");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "DepartmentPosition");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "OrganizationLegalForm");

            migrationBuilder.DropTable(
                name: "OrganizationLegalType");

            migrationBuilder.DropTable(
                name: "ContractType");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "FamilyStatus");

            migrationBuilder.DropTable(
                name: "Gender");
        }
    }
}
