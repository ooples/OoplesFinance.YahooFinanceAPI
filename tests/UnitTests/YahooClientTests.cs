namespace OoplesFinance.YahooFinanceAPI.Tests.Unit;

public sealed class YahooClientTests
{
    private readonly YahooClient _sut;

    public YahooClientTests()
    {
        _sut = new();
    }

    [Fact]
    public async Task GetHistoricalData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await _sut.GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetStockSplitData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";
        var startDate = DateTime.Now.AddYears(-1);
        var _sut = new YahooClient();

        // Act
        var result = async () => await _sut.GetStockSplitDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetDividendData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await _sut.GetDividendDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCapitalGainData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await _sut.GetCapitalGainDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCapitalGainData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";
        var startDate = DateTime.Now.AddYears(-1);

        // Act
        var result = async () => await _sut.GetCapitalGainDataAsync(symbol, DataFrequency.Daily, startDate);

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
        var result = async () => await _sut.GetHistoricalDataAsync(symbol, DataFrequency.Daily, startDate);

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
        var result = async () => await _sut.GetDividendDataAsync(symbol, DataFrequency.Daily, startDate);

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
        var result = async () => await _sut.GetStockSplitDataAsync(symbol, DataFrequency.Daily, startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetTopTrendingStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopTrendingStocksAsync(Country.UnitedStates, -1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStockRecommendations_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetStockRecommendationsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetStockRecommendations_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetStockRecommendationsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetKeyStatistics_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetKeyStatisticsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetKeyStatistics_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetKeyStatisticsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSummaryDetails_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetSummaryDetailsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSummaryDetails_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetSummaryDetailsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInsiderHolders_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetInsiderHoldersAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInsiderHolders_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetInsiderHoldersAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInsiderTransactions_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetInsiderTransactionsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInsiderTransactions_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetInsiderTransactionsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetFinancialData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetFinancialDataAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetFinancialData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetFinancialDataAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInstitutionOwnership_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetInstitutionOwnershipAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInstitutionOwnership_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetInstitutionOwnershipAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetFundOwnership_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetFundOwnershipAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetFundOwnership_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetFundOwnershipAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetMajorDirectHolders_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetMajorDirectHoldersAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetMajorDirectHolders_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetMajorDirectHoldersAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSecFilings_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetSecFilingsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSecFilings_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetSecFilingsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInsights_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetInsightsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInsights_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetInsightsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }
}