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
    public class OrganizationLegalTypeRepositoryUnitTest
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
            OrganizationLegalType organizationLegalType = new OrganizationLegalType()
            {
                Name = "Sermayeler"
            };

            var result = _unitOfWork.Repository<OrganizationLegalType>().Add(organizationLegalType);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
