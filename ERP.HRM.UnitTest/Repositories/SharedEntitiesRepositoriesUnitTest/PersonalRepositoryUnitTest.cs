using ERP.HRM.ORM;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.HRM.UnitTest.Repositories.SharedEntitiesRepositoriesUnitTest
{
    [TestClass]
    public class PersonalRepositoryUnitTest
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
            Personel personel = new Personel()
            {
                Firstname = "Leyla",
                Lastname = "Agazade",
                FatherName = "Cavid",
                Birthdate = DateTime.Now,
                Email = "leylah.agazadeh@gmail.com",
                Residence = "Baki, Azerbaycan",
                PinCode = "123456789",
                SerialNumber = "123456789",
                CityId = 2,
                GenderId = 1,
                FamilyStatusId = 2                
            };
            var result = _unitOfWork.Repository<Personel>().Add(personel);

            Assert.IsTrue(result.IsSuccess);
        }
    }
}
