namespace OoplesFinance.YahooFinanceAPI.Tests.Unit;

public sealed class YahooClientTests
{
    [Fact]
    public async Task GetHistoricalData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";
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
        var symbol = "OOPLES";
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
        var symbol = "OOPLES";
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
        var symbol = "OOPLES";
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

    [Fact]
    public async Task GetTopTrendingStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await GetTopTrendingStocksAsync(Country.UnitedStates, -1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStockRecommendations_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await GetStockRecommendationsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage($"'{symbol}' Symbol Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetStockRecommendations_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await GetStockRecommendationsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }
}