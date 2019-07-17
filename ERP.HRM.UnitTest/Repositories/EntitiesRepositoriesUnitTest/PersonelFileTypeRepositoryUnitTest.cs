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
    public class PersonelFileTypeRepositoryUnitTest
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
            PersonelFileType personelFileType = new PersonelFileType()
            {
                Name = "Emek kitabcasi (scan)"
            };

            var result = _unitOfWork.Repository<PersonelFileType>().Add(personelFileType);
            Assert.IsTrue(result.IsSuccess);
        }
    }
}
