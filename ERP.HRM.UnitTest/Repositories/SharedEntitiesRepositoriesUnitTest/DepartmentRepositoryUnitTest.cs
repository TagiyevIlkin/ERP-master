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
    public class DepartmentRepositoryUnitTest
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
            Department department = new Department()
            {
                Name = "Azerbaycan Dovlet Iqtisad Universiteti",
                ShortName = "UNEC",
                Index = 123456789               
            };

            var result = _unitOfWork.Repository<Department>().Add(department);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
