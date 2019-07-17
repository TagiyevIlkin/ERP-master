using ERP.HRM.Entities;
using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.HRM.UnitTest.Repositories.EntitiesRepositoriesUnitTest
{
    [TestClass]
    public class ApplicationNumberRepositoryUnitTest
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
            ApplicationNumber applicationNumber = new ApplicationNumber()
            {
                PersonApplicationTypeId = 1,
                PeriodId = 1,
                Prefix = "A",
                LastNumber = "12"
            };
            var result = _unitOfWork.Repository<ApplicationNumber>().Add(applicationNumber);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
