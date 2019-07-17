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
    public class PersonelFileRepositoryUnitTest
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
            PersonelFile personelFile = new PersonelFile()
            {
                PersonelId = 1,
                PersonelFileTypeId = 1,
                FilePath = @"C:\Users\User\Downloads",
                FileName = "PersonelFile"
            };

            var result = _unitOfWork.Repository<PersonelFile>().Add(personelFile);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
