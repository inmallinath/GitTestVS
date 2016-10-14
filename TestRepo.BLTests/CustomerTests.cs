using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRepo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo.BL.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void FullNameTest()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "FullName";
            customer.LastName = "Test";
            var expected = "Test, FullName";
            //Act
            var actual = customer.FullName();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}