using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebServiceClient.Core.Data;

namespace WebServiceClient.Core.Tests
{
    [TestClass]
    public class GeoNamesCountryRepositoryTests
    {
        [TestMethod]
        public void CanGetAll()
        {
            // Arrange
            var provider = new GeoNamesCountryRepository();

            // Act
            var result = provider.GetAll();

            // Assert
            Assert.IsTrue(result.Count() > 0, "No countries returned");

            //Assert.IsTrue(result.Any(x => x.IsoCode == "US"));
        }


    }
}
