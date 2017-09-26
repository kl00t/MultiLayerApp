using Core.Interfaces;
using Core.Models;
using Kernel;
using Moq;
using Ninject;
using NUnit.Framework;
using Repository;

namespace Core.Tests
{
    [TestFixture]
    public class TopClassTests
    {
        private IKernel _kernel;

        private TopClass _topClass;

        private Mock<IMiddleClass> _mockMiddleClass;

        [SetUp]
        public void TextFixtureSetUp()
        {
            _kernel = new StandardKernel(new ServiceModule());

            _mockMiddleClass = new Mock<IMiddleClass>();

            _topClass = new TopClass(_mockMiddleClass.Object);
        }

        [Test]
        public void VerifyGetMessageFromBottomClass()
        {
            _mockMiddleClass.Setup(x => x.GetMessage(It.IsAny<string>())).Returns("result");
            var result = _topClass.GetMessage("result");
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<string>(result);
        }
    }
}