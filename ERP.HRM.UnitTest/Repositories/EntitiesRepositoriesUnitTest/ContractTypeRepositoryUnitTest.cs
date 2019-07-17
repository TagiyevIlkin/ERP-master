using System;
using System.Collections.Generic;
using System.Text;
using ERP.HRM.Entities;
using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ERP.HRM.UnitTest.Repositories.EntitiesRepositoriesUnitTest
{
    [TestClass]
    public class ContractTypeRepositoryUnitTest
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
            ContractType contractType = new ContractType()
            {
                Name = "Muveqqeti"
            };
            var result = _unitOfWork.Repository<ContractType>().Add(contractType);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
