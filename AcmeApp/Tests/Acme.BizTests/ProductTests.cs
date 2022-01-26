using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void Say_Hello_Test()
        {
            // Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Bog";
            currentProduct.ProductId = 1;
            currentProduct.Description = "Use it in the bathroom";
            var expected = "Hello Bog (1): Use it in the bathroom";
            
            // Act
            var actual = currentProduct.SayHello();

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}