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
    public class PersonApplicationTypeRepositoryUnitTest
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
            PersonApplicationType personApplicationType = new PersonApplicationType()
            {
                Name = "Ise daxilolma",
                FilePath = @"C:\Users\User\Downloads\ERP-master"
            };

            var result = _unitOfWork.Repository<PersonApplicationType>().Add(personApplicationType);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
