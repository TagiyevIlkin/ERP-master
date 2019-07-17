using System;
using System.Collections.Generic;
using System.Text;
using ERP.Shared.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;

namespace ERP.HRM.UnitTest.Repositories.SharedEntitiesRepositoriesUnitTest
{
    [TestClass]
    public class OrganizationRepositoryUnitTest
    {
        private IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            _unitOfWork = new UnitOfWork(new HRMContext());
        }

        [TestMethod]
        public void Add()
        {
            Organization organization = new Organization()
            {
                Name = "Pasha Holding",
                ShortName = "PH",
                MobileNumber = "(+994 12) 505 50 00",
                Email = "office@pasha-holding.az",
                Fax = "(+994 12) 505 15 35 ",
                Index = "5005000",
                VORN = "MMC1234",
                OrganizationLegalFormId = 2,
                OrganizationLegalTypeId = 2,
                TopOrganizationId = 1
            };

            var result = _unitOfWork.Repository<Organization>().Add(organization);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
