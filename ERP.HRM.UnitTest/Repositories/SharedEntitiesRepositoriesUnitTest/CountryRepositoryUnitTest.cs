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
    public class CountryRepositoryUnitTest
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
            Country mobilePinCode = new Country()
            {
                MobilePhonePin = +994
            };

            var result = _unitOfWork.Repository<Country>().Add(mobilePinCode);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
