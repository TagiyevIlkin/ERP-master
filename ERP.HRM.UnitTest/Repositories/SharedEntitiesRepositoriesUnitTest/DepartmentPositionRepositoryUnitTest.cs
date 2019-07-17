﻿using System;
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
    public class DepartmentPositionRepositoryUnitTest
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
            DepartmentPosition departmentPosition = new DepartmentPosition()
            {
                DepartmentId = 1,
                Name = "Rektorlar",
                ContractTypeId = 2,
                MaterialResponsibilityFile = "File1",
                VacationDayCount = "5"
            };

            var result = _unitOfWork.Repository<DepartmentPosition>().Add(departmentPosition);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
