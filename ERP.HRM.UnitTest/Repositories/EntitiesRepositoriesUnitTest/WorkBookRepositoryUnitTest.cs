using System;
using System.Collections.Generic;
using System.Text;
using ERP.HRM.Entities;
using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP.HRM.UnitTest.Repositories.EntitiesRepositoriesUnitTest
{
    [TestClass]
    public class WorkBookRepositoryUnitTest
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
            WorkBook workBook = new WorkBook ()
            {
                PositionId = 1,
                OrganizationId = 1,
                BeginDate = DateTime.Now,
                EndDate = DateTime.Now
            };
            var result = _unitOfWork.Repository<WorkBook>().Add(workBook);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
