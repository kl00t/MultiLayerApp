using Core.Models;
using Kernel;
using Moq;
using Ninject;
using NUnit.Framework;
using Repository;

namespace Core.Tests
{
    [TestFixture]
    public class MiddleClassTests
    {
        private IKernel _kernel;

        private MiddleClass _middleClass;

        private Mock<IBottomClass> _mockBottomClass;

        [SetUp]
        public void TextFixtureSetUp()
        {
            _kernel = new StandardKernel(new ServiceModule());

            _mockBottomClass = new Mock<IBottomClass>();

            _middleClass = new MiddleClass(_mockBottomClass.Object);
        }

        [Test]
        public void VerifyGetMessageFromBottomClass()
        {
            _mockBottomClass.Setup(x => x.GetMessage(It.IsAny<string>())).Returns("result");
            var result = _middleClass.GetMessage("result");
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<string>(result);
        }
    }
}