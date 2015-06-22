using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace WebServiceClient.Service.Tests
{
    [TestClass]
    public class CountryServiceTests
    {
        [TestMethod]
        public void CanGetAll()
        {
            // Arrange
            var service = new CountryService(new FakeCountryRepository());

            // Act
            var result = service.GetAll();

            // Assert
            Assert.AreEqual(5, result.Count());
        }

        [TestMethod]
        public void CanGetByIsoCode()
        {
            // Arrange
            var service = new CountryService(new FakeCountryRepository());

            // Act
            var result = service.FindByIsoCode("CN");

            // Assert
            Assert.AreEqual("China", result.Name);
            Assert.AreEqual("CN", result.IsoCode);
            Assert.AreEqual(156, result.CountryId);
        }

        [TestMethod]
        public void CanCountriesByContinent()
        {
            // Arrange 
            var service = new CountryService(new FakeCountryRepository());

            // Act
            var result = service.GetCountriesByContinent();

            // Assert
            Assert.AreEqual(4, result.Count());
        }

        [TestMethod]
        public void CanGetCountriesByLanguage()
        {
            // Arrange 
            var service = new CountryService(new FakeCountryRepository());

            // Act
            var result = service.GetCountriesByLanguage("en");

            // Assert
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void CanGetCountryByCountryId()
        {
            // Arrange
            var service = new CountryService(new FakeCountryRepository());

            // Act
            var result = service.FindByCountryId(156);

            // Assert
            Assert.AreEqual("China", result.Name);
            Assert.AreEqual("CN", result.IsoCode);
            Assert.AreEqual(156, result.CountryId);
        }
    }
}
