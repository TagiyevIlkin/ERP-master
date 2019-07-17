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
    public class PersonTabelRepositoryUnitTest
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
            PersonTabel personTabel = new PersonTabel()
            {
                DepartmentPositionId = 1,
                Date = DateTime.Now,
                BeginTime = DateTime.Today,
                EndTime = DateTime.UtcNow
            };

            var result = _unitOfWork.Repository<PersonTabel>().Add(personTabel);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
