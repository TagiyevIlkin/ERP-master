using ERP.HRM.Entities;
using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ERP.HRM.UnitTest.Repositories.EntitiesRepositoriesUnitTest
{
    [TestClass]
    public class HolidayRepositoryUnitTest
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
            Holiday holiday = new Holiday()
            {
                Name = "Qurban Bayrami",
                BeginDate = DateTime.Now,
                EndDate = DateTime.Now
            };
            var result = _unitOfWork.Repository<Holiday>().Add(holiday);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
