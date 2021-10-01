using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1;

namespace TestFootBallPlayer
{
    [TestClass]
    public class TestPlayer
    {
        private FootBallPlayer _footBallPlayer;

        [TestInitialize]
        public void SetUp()
        {
            _footBallPlayer = new FootBallPlayer(1, "Anders", 3000, 50);
        }

        [TestMethod]
        public void TestNameConstructor()
        {
            FootBallPlayer fbp = new FootBallPlayer(1, "Anders", 3000, 50);
            //Assert.AreEqual(1, fbp.Id);
            Assert.AreEqual("Anders", fbp.Name);
            Assert.AreEqual(3000, fbp.Price);
            Assert.AreEqual(50, fbp.ShirtNumber);
        }

        [TestMethod]
        public void TestName()
        {
            _footBallPlayer.Name = "Anders";
            Assert.AreEqual("Anders", _footBallPlayer.Name);
            Assert.ThrowsException<ArgumentNullException>(() => _footBallPlayer.Name = null);
            Assert.ThrowsException<ArgumentException>(() => _footBallPlayer.Name = "Bob");
        }

        [TestMethod]
        public void TestPrice()
        {
            _footBallPlayer.Price = 100;
            Assert.AreEqual(100, _footBallPlayer.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footBallPlayer.Price = 0);

        }

        [TestMethod]
        public void TestShirtNumbers()
        {
            _footBallPlayer.ShirtNumber = 42;
            Assert.AreEqual(42, _footBallPlayer.ShirtNumber);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footBallPlayer.ShirtNumber = 200);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footBallPlayer.ShirtNumber = 0);

        }
    }














}