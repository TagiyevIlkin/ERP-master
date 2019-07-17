using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using AutoMapper;
using ERP.HRM.DTO;
using ERP.HRM.ORM;
using ERP.HRM.Services;
using ERP.HRM.Services.Interfaces;
using ERP.HRM.WebAPI.Controllers;
using ERP.Repositories;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IConfigurationProvider = AutoMapper.IConfigurationProvider;

namespace ERP.HRM.UnitTest.Controllers
{
    [TestClass]
    public class PersonelControllerTest
    {
        ////IConfigurationBuilder _configurationbuilder;
        //private IConfiguration _configuration;
        private PersonelController _controller;
        private IUnitOfWork _unitofwork;
        private IUserService _userService;
        private IMapper _mapper;
        


        [TestInitialize]
        public void Init()
        {
            //directory.getcurrentdirectory()
            var configurationbuilder = new ConfigurationBuilder()
                .SetBasePath(@"D:\ERP\ERP.HRM.WebAPI")
                .AddJsonFile("appsettings.json", optional: true);
            var configuration = configurationbuilder.Build();

            var optionsbuilder = new DbContextOptionsBuilder<HRMContext>()
                .UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            _unitofwork = new UnitOfWork(new HRMContext(optionsbuilder.Options));
            _controller = new PersonelController(configuration, _mapper, _unitofwork, _userService);
        }

        //[TestMethod]
        //public void Getpersonlist()
        //{

        //    //act
        //    var personlist = _controller.GetPersonelForPaging();

        //    //assert
        //    Assert.IsNotNull(personlist);

        //}


        [TestMethod]
        public void GetReturnsProduct()
        {
            // Arrange
            var request=new HttpRequestMessage(HttpMethod.Get, "https://localhost:44357/api/v1/personel/create");

            // Act
            var response = _controller.GetById(1);

            // Assert
           
        }

        [TestMethod]
        public void Post()
        {
            CreatePersonelDTO personel = new CreatePersonelDTO()
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
            //Arange
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44357/api/v1/personel/create");
            

            //request.Headers("Connection", "keep-alive");
            //request.Headers("Content-Type", "application/json");
            //request.Headers("Host", "localhost:44357");

        }

        //[TestMethod]
        //public void Put()
        //{


        //    // act
        //    // _controller.edit();

        //    // assert
        //}

        //[TestMethod]
        //public void Delete()
        //{


        //    // act
        //    //_controller.delete(5);

        //    // assert
        //}
    }
}