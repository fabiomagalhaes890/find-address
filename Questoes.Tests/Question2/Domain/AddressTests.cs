using FluentAssertions;
using Moq;
using Question2.Domain;

namespace Questions.Test.Question2.Domain
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void Create_WithInstruction25ReturnsConstructedAddressWithZero()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(0);
            expected.SetupGet(x => x.Position).Returns(0);

            var actual = new Address();
            actual.Increment("25");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction52ReturnsConstructedAddressWithValue0AndPosition1()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(0);
            expected.SetupGet(x => x.Position).Returns(1);

            var actual = new Address();
            actual.Increment("52");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction53ReturnsConstructedAddressWithValue0AndPosition2()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(0);
            expected.SetupGet(x => x.Position).Returns(2);

            var actual = new Address();
            actual.Increment("53");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction202ReturnsConstructedAddressWithValue2AndPosition0()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(2);
            expected.SetupGet(x => x.Position).Returns(0);

            var actual = new Address();
            actual.Increment("202");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction54ReturnsConstructedAddressWithValue0AndPosition3()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(0);
            expected.SetupGet(x => x.Position).Returns(3);

            var actual = new Address();
            actual.Increment("54");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction402ReturnsConstructedAddressWithValueZero()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(0);
            expected.SetupGet(x => x.Position).Returns(0);

            var actual = new Address();
            actual.Increment("402");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction203ReturnsConstructedAddressWithValue3AndPosition0()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(3);
            expected.SetupGet(x => x.Position).Returns(0);

            var actual = new Address();
            actual.Increment("203");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction510ReturnsConstructedAddressWithValue0AndPosition9()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(0);
            expected.SetupGet(x => x.Position).Returns(9);

            var actual = new Address();
            actual.Increment("510");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Create_WithInstruction201ReturnsConstructedAddressWithValue1AndPosition0()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(1);
            expected.SetupGet(x => x.Position).Returns(0);

            var actual = new Address();
            actual.Increment("201");

            actual.Should().BeEquivalentTo(expected.Object);
        }

        [TestMethod]
        public void Search_AddressInCoupleOfValuesReturnsAddressValue3()
        {
            var expected = new Mock<Address>();
            expected.SetupGet(x => x.Value).Returns(3);

            var actual = new Address();
            actual.Increment("25");
            actual.Increment("52");
            actual.Increment("202");
            actual.Increment("54");
            actual.Increment("402");
            actual.Increment("510");
            actual.Increment("201");

            actual.Should().BeEquivalentTo(expected.Object,
                opt => opt.Excluding(x => x.Position));
        }
    }
}
