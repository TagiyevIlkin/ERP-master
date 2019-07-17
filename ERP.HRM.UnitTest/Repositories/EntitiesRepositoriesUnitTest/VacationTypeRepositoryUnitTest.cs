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
    public class VacationTypeRepositoryUnitTest
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
            VacationType vacationType = new VacationType()
            {
                Name = "Ataliq Mezuniyyeti"
            };
            var result = _unitOfWork.Repository<VacationType>().Add(vacationType);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
