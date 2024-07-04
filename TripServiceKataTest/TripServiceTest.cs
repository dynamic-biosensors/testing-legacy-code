using Xunit;
using FluentAssertions;
using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    public class TripServiceTest
    {
        [Fact]
        public void Foo()
        {
            new TripService();
            true.Should().Be(false);
        }
    }
}
