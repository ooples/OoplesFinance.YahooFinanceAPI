using NSubstitute;
using OoplesFinance.YahooFinanceAPI.Models;

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

    [Fact]
    public async Task GetMajorHoldersBreakdown_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetMajorHoldersBreakdownAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetMajorHoldersBreakdown_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetMajorHoldersBreakdownAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetUpgradeDowngradeHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetUpgradeDowngradeHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetUpgradeDowngradeHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetUpgradeDowngradeHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEsgScores_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetEsgScoresAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEsgScores_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetEsgScoresAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetRecommendationTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetRecommendationTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetRecommendationTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetRecommendationTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetIndexTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetIndexTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetIndexTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetIndexTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSectorTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetSectorTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSectorTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetSectorTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEarningsTrend_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetEarningsTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEarningsTrend_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetEarningsTrendAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetAssetProfile_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetAssetProfileAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetAssetProfile_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetAssetProfileAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetFundProfile_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetFundProfileAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetFundProfile_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetFundProfileAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetCalendarEvents_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetCalendarEventsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCalendarEvents_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetCalendarEventsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEarnings_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetEarningsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEarnings_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetEarningsAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetBalanceSheetHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetBalanceSheetHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetCashflowStatementHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCashflowStatementHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetIncomeStatementHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetIncomeStatementHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetEarningsHistory_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetEarningsHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetEarningsHistory_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetEarningsHistoryAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetQuoteType_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetQuoteTypeAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetQuoteType_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetQuoteTypeAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetPriceInfo_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetPriceInfoAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetPriceInfo_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetPriceInfoAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetNetSharePurchaseActivity_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetNetSharePurchaseActivityAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetNetSharePurchaseActivity_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetNetSharePurchaseActivityAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetIncomeStatementHistoryQuarterly_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryQuarterlyAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetIncomeStatementHistoryQuarterly_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetIncomeStatementHistoryQuarterlyAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetCashflowStatementHistoryQuarterly_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryQuarterlyAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetCashflowStatementHistoryQuarterly_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetCashflowStatementHistoryQuarterlyAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetBalanceSheetHistoryQuarterly_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryQuarterlyAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetBalanceSheetHistoryQuarterly_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetBalanceSheetHistoryQuarterlyAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetChartInfo_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetChartInfoAsync(symbol, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetChartInfo_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetChartInfoAsync(symbol, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<ArgumentException>().WithMessage("Symbol Parameter Can't Be Empty Or Null");
    }

    [Fact]
    public async Task GetSparkChartInfo_ThrowsException_WhenNoSymbolIsFound()
    {
        // Arrange
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetSparkChartInfoAsync(symbol, TimeRange._1Day, TimeInterval._1Minute);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetSparkChartInfo_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetSparkChartInfoAsync(symbol, TimeRange._1Day, TimeInterval._1Minute);

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
        var symbol = "OOPLES";

        // Act
        var result = async () => await _sut.GetRealTimeQuotesAsync(symbol);

        // Assert
        await result.Should().ThrowAsync<InvalidOperationException>().WithMessage("Requested Information Not Available On Yahoo Finance");
    }

    [Fact]
    public async Task GetRealTimeQuotes_ThrowsException_WhenEmptySymbolIsUsed()
    {
        // Arrange
        var symbol = "";

        // Act
        var result = async () => await _sut.GetRealTimeQuotesAsync(symbol);

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