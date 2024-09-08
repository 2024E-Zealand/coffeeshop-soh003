using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleAppNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60;

namespace CoffeeShopConsoleAppNet60.Tests
{
    [TestClass()]
    public class CoffeeTests
    {
       //HER OK TEST

        [TestMethod]
        public void SetDiscount_WithValidDiscount_SetsDiscountCorrectly()
        {
            // Arrange
            var cortado = new Cortado(3); // Gyldig rabat på 3 DKK

            // Act
            var result = cortado.Discount;

            // Assert
            Assert.AreEqual(3, result); // Tjek at rabatten er sat korrekt
        }

        //HER IKKE OK TEST
        [TestMethod]
        public void SetDiscount_WithInvalidDiscount_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            // Handling af undtagelsen sker under Act/Assert

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Cortado(6)); // 6 DKK er ugyldig rabat
        }


        [TestMethod]
        public void SetDiscount_WithZeroDiscount_SetsDiscountCorrectly()
        {
            // Arrange
            var cortado = new Cortado(0); // 0 DKK rabat

            // Act
            var result = cortado.Discount;

            // Assert
            Assert.AreEqual(0, result); // Tjek at 0 rabat accepteres
        }
    }
}