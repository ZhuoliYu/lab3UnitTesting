using lab3UnitTesting.Data;
using lab3UnitTesting.Data.BLL;
using lab3UnitTesting.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestingLab3
{
    [TestClass]
    public class UnitTest1
    {
        Mock<Irespiratory<ParkingSpace>> ParkingSapceMRepo;
        Mock<Irespiratory<Pass>> PassMRepo;
        BLLPass PassBl;
        BLLParking ParkingSpaceBl;

        [TestInitialize]
        public void InitializedTest()
        {
            ParkingSapceMRepo = new Mock<Irespiratory<ParkingSpace>>();
            PassMRepo = new Mock<Irespiratory<Pass>>();


            PassBl = new BLLPass(PassMRepo.Object);
            ParkingSpaceBl = new BLLParking(ParkingSapceMRepo.Object);
        }
        [TestMethod]
        public void PassPurchaserLessThanThreeLetter()
        {
            //Arrange
            string purchase = "CC";
            var newPass = new Pass(purchase);
            //Act&Assert
            Assert.ThrowsException<Exception>(() => PassBl.CreatePass(newPass));
        }

        [TestMethod]
        public void ParkedSpaceLessThanOne()
        {
            //Arrange
            int number = 0;
            var newparkingSpace = new ParkingSpace(number);

            //Act&Assert
            Assert.ThrowsException<Exception>(() => ParkingSpaceBl.CreateParkingSpace(newparkingSpace));

        }
    }
}