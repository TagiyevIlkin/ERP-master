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
    public class VacationRepositoryUnitTest
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
            Vacation vacation = new Vacation()
            {
                VacationTypeId = 1,
                DepartmentPositionId = 2,
                PersonId = 1,
                ReplacementPersonId = 2,
                BeginDate = DateTime.Now,
                EndDate = DateTime.UtcNow,
                Status = false
            };

            var result = _unitOfWork.Repository<Vacation>().Add(vacation);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
