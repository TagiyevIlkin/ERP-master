using System;
using System.Collections.Generic;
using System.Text;
using ERP.HRM.Entities;
using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP.HRM.UnitTest.Repositories.EntitiesRepositoriesUnitTest
{
    [TestClass]
    public class PeriodRepositoryUnitTest
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
            Period period = new Period()
            {
                Name = "2 - ci sessiya",
                BeginDate = DateTime.Now,
                EndDate = DateTime.UtcNow
            };
            var result = _unitOfWork.Repository<Period>().Add(period);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
