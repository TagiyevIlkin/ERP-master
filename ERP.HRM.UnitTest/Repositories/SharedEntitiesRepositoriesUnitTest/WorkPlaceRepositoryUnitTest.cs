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
    public class WorkPlaceRepositoryUnitTest
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
            WorkPlace workPlace = new WorkPlace()
            {
                UserId = 1,
                DepartmentPositionId = 1
            };

            var result = _unitOfWork.Repository<WorkPlace>().Add(workPlace);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
