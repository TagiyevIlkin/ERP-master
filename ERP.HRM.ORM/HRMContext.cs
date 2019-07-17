//using Microsoft.EntityFrameworkCore;
using System;
using ERP.HRM.Entities;
using ERP.Shared.Entities;
using ERP.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ERP.HRM.ORM
{
    public partial class HRMContext : DbContext
    {
       
        public HRMContext(DbContextOptions<HRMContext> options):base(options)
        {
            
        }
        public HRMContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(@"Server=10.100.140.240\\DESKTOP-QPIT99U\\SQLEXPRESS,1433;Database=ERP; User Id=ERP; Password=ERP*123; Trusted_Connection=False;MultipleActiveResultSets=true");
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=ERP; Trusted_Connection=True; MultipleActiveResultSets=true");
            }
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<DepartmentPosition> DepartmentPosition { get; set; }
        public DbSet<FamilyStatus> FamilyStatus { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<OrganizationLegalForm> OrganizationLegalForm { get; set; }
        public DbSet<OrganizationLegalType> OrganizationLegalType { get; set; }
        public DbSet<Personel> Personel { get; set; }
        public DbSet<PersonPhone> PersonPhone { get; set; }
        public DbSet<PhoneType> PhoneType { get; set; }
        public DbSet<SocialStatus> SocialStatus { get; set; }
        public DbSet<StructureType> StructureType { get; set; }
        public DbSet<WorkPlace> WorkPlace { get; set; }
        public DbSet<ApplicationNumber> ApplicationNumber { get; set; }
        public DbSet<ContractType> ContractType { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<Period> Period { get; set; }
        public DbSet<PersonApplication> PersonApplication { get; set; }
        public DbSet<PersonApplicationType> PersonApplicationType { get; set; }
        public DbSet<PersonelFile> PersonelFile { get; set; }
        public DbSet<PersonelFileType> PersonelFileType { get; set; }
        public DbSet<PersonTabel> PersonTabel { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<VacationType> VacationType { get; set; }
        public DbSet<WorkBook> WorkBook { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            modelBuilder.Entity<Personel>().HasData(
                new Personel()
                {
                    Id = 1,
                    Firstname = "Parviz",
                    Lastname = "Aliyev",
                    FatherName = "Rovsen",
                    Residence = "Baki",
                    PinCode = "123456",
                    SerialNumber = "123456",
                    CityId = 3,
                    GenderId = 2,
                    FamilyStatusId = 2,
                    Birthdate = DateTime.UtcNow,
                    Email = "parviz@gmail.com"
                });

            //modelBuilder.Entity<Role>().HasData(
            //    new Role()
            //    {
            //        Id = 1,
            //        Name = StaticRoles.AdminRole,
            //        Description = "admin vordu"
            //    });
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "ParvizRA",
                    Password = Tools.HashPassword("parviz@123"),
                    PersonelId = 1,
                    Status = true
                });

            modelBuilder.Entity<City>().HasData(
                new City() {Id = 1, Name = "Baki" },
                new City() { Id = 2, Name = "Naxcivan" },
                new City() { Id = 3, Name = "Gence" });

            modelBuilder.Entity<Gender>().HasData(
                new Gender() { Id = 1, Type = "Qadin" },
                new Gender() { Id = 2, Type = "Kisi" });

            modelBuilder.Entity<FamilyStatus>().HasData(
                new FamilyStatus() { Id = 1, Name = "Evli" },
                new FamilyStatus() { Id = 2, Name = "Subay" });

            modelBuilder.Entity<OrganizationLegalForm>().HasData(
                new OrganizationLegalForm() { Id = 1, Name = "Korporativ Strategiya" },
                new OrganizationLegalForm() { Id = 2, Name = "Biznes Fokus" });

            modelBuilder.Entity<OrganizationLegalType>().HasData(
                new OrganizationLegalType() { Id = 1, Name = "Sehmdarlarin Hedefleri" },
                new OrganizationLegalType() { Id = 2, Name = "Maliyye Sektoru" });

            modelBuilder.Entity<Organization>().HasData(
              new Organization()
              {
                  Id = 1,
                  Name = "Pasha Holding",
                  ShortName = "PH",
                  MobileNumber = "(+994 12) 505 50 00",
                  Email = "office@pasha-holding.az",
                  Fax = "(+994 12) 505 15 35 ",
                  Index = "5055000",
                  VORN = "MMC1234",
                  OrganizationLegalFormId = 1,
                  OrganizationLegalTypeId = 1,
                  //TopOrganizationsId = 0
              });

            modelBuilder.Entity<Department>().HasData(
             new Department()
             {
                 Id = 1,
                 Name = "Baki Dovlet Universiteti",
                 ShortName = "BDU",
                 Index = 123456
             });

            modelBuilder.Entity<ContractType>().HasData(
                new ContractType() { Id = 1, Name = "Muqavile" },
                new ContractType() { Id = 2, Name = "Daimi" });

            modelBuilder.Entity<DepartmentPosition>().HasData(
              new DepartmentPosition()
              {
                  Id = 1,
                  DepartmentId = 1,
                  Name = "Fexri Doktorlar",
                  MaterialResponsibilityFile = "File2",
                  ContractTypeId = 1,
                  VacationDayCount= "3"
              });

            modelBuilder.Entity<Period>().HasData(
                new Period() { Id = 1, Name = "1-ci sessiya", BeginDate = DateTime.Now, EndDate = DateTime.UtcNow });

            modelBuilder.Entity<PersonApplicationType>().HasData(
                new PersonApplicationType()
                {
                    Id = 1,
                    Name = "Isden Cixarilma",
                    FilePath = @"C:\Users\User\Downloads\ERP-master\ERP-master"
                });

            modelBuilder.Entity<PersonelFileType>().HasData(
                new PersonelFileType() { Id = 1, Name = "Diplomun kopyasi" });

            modelBuilder.Entity<VacationType>().HasData(
               new VacationType() { Id = 1, Name = "Ezamiyyet" });

            modelBuilder.Entity<Position>().HasData(
               new Position() { Id = 1, Name = "Web Developer" });
        }
    }
}
