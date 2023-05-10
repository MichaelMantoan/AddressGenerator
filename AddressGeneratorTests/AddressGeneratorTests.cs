using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressGenerator.Tests
{
    [TestClass()]
    public class AddressGeneratorTests
    {
        [TestMethod]
        public void TestGenerateIPv4()
        {
            // Arrange
            int[] bits = { 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            int subnetBits = 18;
            AddressGenerator addressGenerator = new AddressGenerator(bits , subnetBits);

            // Act
            string ipv4 = addressGenerator.generateIPV4();

            // Assert
            Assert.AreEqual("192.168.206.4", ipv4);
        }

        [TestMethod]
        public void TestGenerateSubnet()
        {
            // Arrange
            int[] bits = { 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            int subnetBits = 18;
            AddressGenerator addressGenerator = new AddressGenerator(bits, subnetBits);

            // Act
            string subnet = addressGenerator.generateSubnet();

            // Assert
            Assert.AreEqual("255.255.192.0", subnet);
        }
    }
}