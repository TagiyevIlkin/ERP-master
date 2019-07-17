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
    public class PhoneTypeRepositoryUnitTest
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
            PhoneType phoneType = new PhoneType()
            {
                HomeNumber = "0125647896",
                MobileNumber = "0554896712",
                JobNumber ="0123654789",
                AdditionalNumber = "0779654123"
            };

            var result = _unitOfWork.Repository<PhoneType>().Add(phoneType);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
