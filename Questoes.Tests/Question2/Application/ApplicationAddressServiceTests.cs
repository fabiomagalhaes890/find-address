using FluentAssertions;
using Question2.Application;

namespace Questions.Test.Question2.Application
{
    [TestClass]
    public class ApplicationAddressServiceTests
    {
        [TestMethod]
        public void Search_AddressInFileReturns670()
        {
            int result = ApplicationAddressService.SearchAddress();
            result.Should().Be(670);
        }
    }
}
