using FluentAssertions;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace OoplesFinance.YahooFinanceAPI.Tests.Unit;

public sealed class YahooClientTests
{
    [Fact]
    public async Task GetHistoricalData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "GOOGLECOINS";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage($"'{symbol}' Symbol Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetStockSplitData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "GOOGLECOINS";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetStockSplitDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage($"'{symbol}' Symbol Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetDividendData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "GOOGLECOINS";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetDividendDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage($"'{symbol}' Symbol Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCapitalGainData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "GOOGLECOINS";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetCapitalGainDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage($"'{symbol}' Symbol Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCapitalGainData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetCapitalGainDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetHistoricalData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetDividendData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetDividendDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetStockSplitData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await GetStockSplitDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }
}