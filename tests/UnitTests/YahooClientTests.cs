namespace OoplesFinance.YahooFinanceAPI.Tests.Unit;

public sealed class YahooClientTests
{
    private readonly YahooClient _sut;
    private const string BadSymbol = "OOPLES";
    private const string EmptySymbol = "";
    private readonly DateTime _startDate;

    public YahooClientTests()
    {
        _sut = new YahooClient();
        _startDate = DateTime.Now.AddYears(-1);
    }

    [Fact]
    public async Task GetHistoricalData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetHistoricalDataAsync(BadSymbol, DataFrequency.Daily, _startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetStockSplitData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStockSplitDataAsync(BadSymbol, DataFrequency.Daily, _startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetDividendData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetDividendDataAsync(BadSymbol, DataFrequency.Daily, _startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCapitalGainData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCapitalGainDataAsync(BadSymbol, DataFrequency.Daily, _startDate);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCapitalGainData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCapitalGainDataAsync(EmptySymbol, DataFrequency.Daily, _startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetHistoricalData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetHistoricalDataAsync(EmptySymbol, DataFrequency.Daily, _startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetDividendData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetDividendDataAsync(EmptySymbol, DataFrequency.Daily, _startDate);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetStockSplitData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStockSplitDataAsync(EmptySymbol, DataFrequency.Daily, _startDate);

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

        // Act
        var result = async () => await _sut.GetStockRecommendationsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetStockRecommendations_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStockRecommendationsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetKeyStatistics_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetKeyStatisticsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetKeyStatistics_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetKeyStatisticsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSummaryDetails_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSummaryDetailsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSummaryDetails_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSummaryDetailsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInsiderHolders_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInsiderHoldersAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInsiderHolders_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInsiderHoldersAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInsiderTransactions_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInsiderTransactionsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInsiderTransactions_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInsiderTransactionsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetFinancialData_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetFinancialDataAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetFinancialData_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetFinancialDataAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInstitutionOwnership_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInstitutionOwnershipAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInstitutionOwnership_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInstitutionOwnershipAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetFundOwnership_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetFundOwnershipAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetFundOwnership_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetFundOwnershipAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetMajorDirectHolders_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMajorDirectHoldersAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetMajorDirectHolders_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMajorDirectHoldersAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSecFilings_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSecFilingsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSecFilings_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSecFilingsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetInsights_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInsightsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetInsights_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetInsightsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetMajorHoldersBreakdown_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMajorHoldersBreakdownAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetMajorHoldersBreakdown_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMajorHoldersBreakdownAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetUpgradeDowngradeHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetUpgradeDowngradeHistoryAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetUpgradeDowngradeHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetUpgradeDowngradeHistoryAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEsgScores_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEsgScoresAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEsgScores_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEsgScoresAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetRecommendationTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetRecommendationTrendAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetRecommendationTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetRecommendationTrendAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetIndexTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetIndexTrendAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetIndexTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetIndexTrendAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSectorTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSectorTrendAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSectorTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSectorTrendAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEarningsTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEarningsTrendAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEarningsTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEarningsTrendAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetAssetProfile_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetAssetProfileAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetAssetProfile_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetAssetProfileAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetFundProfile_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetFundProfileAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetFundProfile_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetFundProfileAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetCalendarEvents_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCalendarEventsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCalendarEvents_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCalendarEventsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEarnings_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEarningsAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEarnings_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEarningsAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetBalanceSheetHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetBalanceSheetHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetCashflowStatementHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCashflowStatementHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetIncomeStatementHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetIncomeStatementHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEarningsHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEarningsHistoryAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEarningsHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetEarningsHistoryAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetQuoteType_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetQuoteTypeAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetQuoteType_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetQuoteTypeAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetPriceInfo_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetPriceInfoAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetPriceInfo_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetPriceInfoAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetNetSharePurchaseActivity_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetNetSharePurchaseActivityAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetNetSharePurchaseActivity_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetNetSharePurchaseActivityAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetIncomeStatementHistoryQuarterly_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryQuarterlyAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetIncomeStatementHistoryQuarterly_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryQuarterlyAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetCashflowStatementHistoryQuarterly_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryQuarterlyAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCashflowStatementHistoryQuarterly_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryQuarterlyAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetBalanceSheetHistoryQuarterly_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryQuarterlyAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetBalanceSheetHistoryQuarterly_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryQuarterlyAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetChartInfo_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetChartInfoAsync(BadSymbol, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetChartInfo_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetChartInfoAsync(EmptySymbol, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSparkChartInfo_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSparkChartInfoAsync(BadSymbol, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSparkChartInfo_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSparkChartInfoAsync(EmptySymbol, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSparkChartInfo_ThrowsException_WhenEmptySymbolListIsUsed()
    {
        // Arrange
        var symbols = Enumerable.Empty<string>();

        // Act
        var result = async () => await _sut.GetSparkChartInfoAsync(symbols, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbols Parameter Must Contain At Least One Symbol");
    }

    [Fact]
    public async Task GetSparkChartInfo_ThrowsException_WhenTooManySymbolsAreUsed()
    {
        // Arrange
        var symbols = Enumerable.Repeat("AAPL", 255);

        // Act
        var result = async () => await _sut.GetSparkChartInfoAsync(symbols, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbols Parameter Can't Have More Than 250 Symbols");
    }

    [Fact]
    public async Task GetRealTimeQuotes_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetRealTimeQuotesAsync(BadSymbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetRealTimeQuotes_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetRealTimeQuotesAsync(EmptySymbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetRealTimeQuotes_ThrowsException_WhenEmptySymbolListIsUsed()
    {
        // Arrange
        var symbols = Enumerable.Empty<string>();

        // Act
        var result = async () => await _sut.GetRealTimeQuotesAsync(symbols);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbols Parameter Must Contain At Least One Symbol");
    }

    [Fact]
    public async Task GetRealTimeQuotes_ThrowsException_WhenTooManySymbolsAreUsed()
    {
        // Arrange
        var symbols = Enumerable.Repeat("AAPL", 255);

        // Act
        var result = async () => await _sut.GetRealTimeQuotesAsync(symbols);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbols Parameter Can't Have More Than 250 Symbols");
    }

    [Fact]
    public async Task GetMarketSummary_ReturnsInfo_WhenValidResultsAreFound()
    {
        // Arrange

        // Act
        var result = await _sut.GetMarketSummaryAsync();

        // Assert
        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GetAutoCompleteInfo_ThrowsException_WhenEmptySearchTermIsUsed()
    {
        // Arrange
        var searchTerm = "";

        // Act
        var result = async () => await _sut.GetAutoCompleteInfoAsync(searchTerm);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("The Search Term Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetTopGainers_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopGainersAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopLosers_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopLosersAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetSmallCapGainers_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSmallCapGainersAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetMostActiveStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMostActiveStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetAggressiveSmallCapStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetAggressiveSmallCapStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetConservativeForeignFunds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetConservativeForeignFundsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetGrowthTechnologyStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetGrowthTechnologyStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetHighYieldBonds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetHighYieldBondsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetMostShortedStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMostShortedStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetPortfolioAnchors_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetPortfolioAnchorsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetSolidLargeGrowthFunds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSolidLargeGrowthFundsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetSolidMidcapGrowthFunds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetSolidMidcapGrowthFundsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopMutualFunds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopMutualFundsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetUndervaluedGrowthStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetUndervaluedGrowthStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetUndervaluedLargeCapStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetUndervaluedLargeCapStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetUndervaluedWideMoatStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetUndervaluedWideMoatStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetMorningstarFiveStarStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMorningstarFiveStarStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStrongUndervaluedStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStrongUndervaluedStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetAnalystStrongBuyStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetAnalystStrongBuyStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetLatestAnalystUpgradedStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetLatestAnalystUpgradedStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetMostInstitutionallyBoughtLargeCapStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMostInstitutionallyBoughtLargeCapStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetMostInstitutionallyHeldLargeCapStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMostInstitutionallyHeldLargeCapStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetMostInstitutionallySoldLargeCapStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetMostInstitutionallySoldLargeCapStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStocksWithMostInstitutionalBuyers_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStocksWithMostInstitutionalBuyersAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStocksWithMostInstitutionalSellers_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStocksWithMostInstitutionalSellersAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStocksMostBoughtByHedgeFunds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStocksMostBoughtByHedgeFundsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStocksMostBoughtByPensionFunds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStocksMostBoughtByPensionFundsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStocksMostBoughtByPrivateEquity_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStocksMostBoughtByPrivateEquityAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetStocksMostBoughtBySovereignWealthFunds_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetStocksMostBoughtBySovereignWealthFundsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopStocksOwnedByCathieWood_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopStocksOwnedByCathieWoodAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopStocksOwnedByGoldmanSachs_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopStocksOwnedByGoldmanSachsAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopStocksOwnedByRayDalio_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopStocksOwnedByRayDalioAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopStocksOwnedByWarrenBuffet_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopStocksOwnedByWarrenBuffetAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopBearishStocksRightNow_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopBearishStocksRightNowAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopBullishStocksRightNow_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopBullishStocksRightNowAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }

    [Fact]
    public async Task GetTopUpsideBreakoutStocks_ThrowsException_WhenCountIsInvalid()
    {
        // Arrange

        // Act
        var result = async () => await _sut.GetTopUpsideBreakoutStocksAsync(-1);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Count Must Be At Least 1 To Return Any Data");
    }
}