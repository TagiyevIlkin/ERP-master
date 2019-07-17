using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.HRM.UnitTest.Repositories.SharedEntitiesRepositoriesUnitTest
{
    [TestClass]
    public class CityRepositoryUnitTest
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
            City city = new City()
            {
                Name = "Sirvan"
            };
            var result = _unitOfWork.Repository<City>().Add(city);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
