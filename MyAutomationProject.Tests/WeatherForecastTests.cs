using Xunit;
using MyAutomationProject;

namespace MyAutomationProject.Tests;

public class WeatherForecastTests
{
    [Fact]
    public void WeatherForecast_Should_Have_Summary()
    {
        var forecast = new WeatherForecast
        {
            Summary = "Hot"
        };

        Assert.NotNull(forecast.Summary);
    }
}
