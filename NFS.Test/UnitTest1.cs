using NUnit.Framework;
using NFS.WEB.Controllers;

namespace NFS.Test
{
    public class Tests
    {
        private WelcomeController _welcomeController { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _welcomeController = new WelcomeController();

        }

        [Test]
        public void Test1()
        {
            //assign
            int a = 2; int b = 3;
            int expectedResult = 5;

            //act
            var result = _welcomeController.Addition(a, b);

            //assert
            Assert.AreEqual(expectedResult, result);



            Assert.Pass();
        }
    }
}