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
    public class PersonApplicationRepositoryUnitTest
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
            PersonApplication personApplication = new PersonApplication()
            {
                FromDepartmentPositionId = 1,
                ToDepartmentPositionId = 2,
                PersonApplicationTypeId = 1,
                PersonId = 1,
                Date = DateTime.Now
            };

            var result = _unitOfWork.Repository<PersonApplication>().Add(personApplication);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
