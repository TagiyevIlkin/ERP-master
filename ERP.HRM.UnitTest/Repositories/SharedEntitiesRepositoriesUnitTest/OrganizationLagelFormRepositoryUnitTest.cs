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
    public class OrganizationLagelFormRepositoryUnitTest
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
            OrganizationLegalForm organizationLegalForm = new OrganizationLegalForm()
            {
                Name = "Metbuat Merkezi"
            };

            var result = _unitOfWork.Repository<OrganizationLegalForm>().Add(organizationLegalForm);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
