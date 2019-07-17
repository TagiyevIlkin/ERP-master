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
    public class PersonPhoneRepositoryUnitTest
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
            PersonPhone personPhone = new PersonPhone()
            {
                CountryId = 1,
                Number = "0557894561"
            };

            var result = _unitOfWork.Repository<PersonPhone>().Add(personPhone);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
