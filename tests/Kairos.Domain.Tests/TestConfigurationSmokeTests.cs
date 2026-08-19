using Shouldly;

namespace Kairos.Domain.Tests;

public class TestConfigurationSmokeTests
{
    [Fact]
    public void Xunit_and_Shouldly_are_configured_correctly()
    {
        var result = 1 + 1;

        result.ShouldBe(2);
    }
}