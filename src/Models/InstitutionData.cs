namespace OoplesFinance.YahooFinanceAPI.Models;

public record InstitutionCriteriaMeta(
        [property: JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)] int? Size,
        [property: JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)] int? Offset,
        [property: JsonProperty("sortField", NullValueHandling = NullValueHandling.Ignore)] string SortField,
        [property: JsonProperty("sortType", NullValueHandling = NullValueHandling.Ignore)] string SortType,
        [property: JsonProperty("entityIdType", NullValueHandling = NullValueHandling.Ignore)] string EntityIdType,
        [property: JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<InstitutionCriterion> Criteria,
        [property: JsonProperty("topOperator", NullValueHandling = NullValueHandling.Ignore)] string TopOperator
    );

public record InstitutionCriterion(
    [property: JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)] string Field,
    [property: JsonProperty("operators", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<string> Operators,
    [property: JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<object> Values,
    [property: JsonProperty("labelsSelected", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int?> LabelsSelected,
    [property: JsonProperty("dependentValues", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<object> DependentValues
);

public record InstitutionFinance(
    [property: JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<InstitutionResult> Results,
    [property: JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)] object Error
);

public record InstitutionRecord(
    [property: JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)] string Ticker,
    [property: JsonProperty("companyName", NullValueHandling = NullValueHandling.Ignore)] string CompanyName,
    [property: JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)] double? Price,
    [property: JsonProperty("pricePercentChange", NullValueHandling = NullValueHandling.Ignore)] double? PricePercentChange,
    [property: JsonProperty("intradayPriceChange", NullValueHandling = NullValueHandling.Ignore)] double? IntradayPriceChange,
    [property: JsonProperty("marketCap", NullValueHandling = NullValueHandling.Ignore)] double? MarketCap,
    [property: JsonProperty("dayVolume", NullValueHandling = NullValueHandling.Ignore)] long? DayVolume,
    [property: JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)] string Industry,
    [property: JsonProperty("numOfInstitutionalHolders", NullValueHandling = NullValueHandling.Ignore)] int? NumOfInstitutionalHolders,
    [property: JsonProperty("numOfInstitutionalHoldersPercent", NullValueHandling = NullValueHandling.Ignore)] double? NumOfInstitutionalHoldersPercent,
    [property: JsonProperty("percentInTopTenHoldingsOfInstitutions", NullValueHandling = NullValueHandling.Ignore)] double? PercentInTopTenHoldingsOfInstitutions,
    [property: JsonProperty("numOfInstitutionalBuyers", NullValueHandling = NullValueHandling.Ignore)] int? NumOfInstitutionalBuyers,
    [property: JsonProperty("numOfInstitutionalSellers", NullValueHandling = NullValueHandling.Ignore)] int? NumOfInstitutionalSellers,
    [property: JsonProperty("changeInNumOfInstitutionalHolders", NullValueHandling = NullValueHandling.Ignore)] int? ChangeInNumOfInstitutionalHolders,
    [property: JsonProperty("percentChangeInNumOfInstitutionalHolders", NullValueHandling = NullValueHandling.Ignore)] double? PercentChangeInNumOfInstitutionalHolders,
    [property: JsonProperty("numOfSharesBoughtByInstitutions", NullValueHandling = NullValueHandling.Ignore)] long? NumOfSharesBoughtByInstitutions,
    [property: JsonProperty("numOfSharesSoldByInstitutions", NullValueHandling = NullValueHandling.Ignore)] long? NumOfSharesSoldByInstitutions,
    [property: JsonProperty("changeInSharesHeldByInstitutions", NullValueHandling = NullValueHandling.Ignore)] long? ChangeInSharesHeldByInstitutions,
    [property: JsonProperty("percentChangeInSharesHeldByInstitutions", NullValueHandling = NullValueHandling.Ignore)] double? PercentChangeInSharesHeldByInstitutions,
    [property: JsonProperty("percentOfSharesOutBoughtByInstitutions", NullValueHandling = NullValueHandling.Ignore)] double? PercentOfSharesOutBoughtByInstitutions,
    [property: JsonProperty("percentOfSharesOutSoldByInstitutions", NullValueHandling = NullValueHandling.Ignore)] double? PercentOfSharesOutSoldByInstitutions,
    [property: JsonProperty("percentOfSharesOutHeldByInstitutions", NullValueHandling = NullValueHandling.Ignore)] double? PercentOfSharesOutHeldByInstitutions,
    [property: JsonProperty("lastReportDate", NullValueHandling = NullValueHandling.Ignore)] string LastReportDate,
    [property: JsonProperty("averageRating", NullValueHandling = NullValueHandling.Ignore)] string AverageRating,
    [property: JsonProperty("fiftyTwoWeekRange", NullValueHandling = NullValueHandling.Ignore)] string FiftyTwoWeekRange,
    [property: JsonProperty("logoUrl", NullValueHandling = NullValueHandling.Ignore)] string LogoUrl
);

public record InstitutionResult(
    [property: JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] string Id,
    [property: JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)] string Title,
    [property: JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)] string Description,
    [property: JsonProperty("canonicalName", NullValueHandling = NullValueHandling.Ignore)] string CanonicalName,
    [property: JsonProperty("criteriaMeta", NullValueHandling = NullValueHandling.Ignore)] CriteriaMeta CriteriaMeta,
    [property: JsonProperty("rawCriteria", NullValueHandling = NullValueHandling.Ignore)] string RawCriteria,
    [property: JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)] int? Start,
    [property: JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)] int? Count,
    [property: JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)] int? Total,
    [property: JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<InstitutionRecord> Records,
    [property: JsonProperty("userHasReadRecord", NullValueHandling = NullValueHandling.Ignore)] bool? UserHasReadRecord,
    [property: JsonProperty("useRecords", NullValueHandling = NullValueHandling.Ignore)] bool? UseRecords,
    [property: JsonProperty("predefinedScr", NullValueHandling = NullValueHandling.Ignore)] bool? PredefinedScr,
    [property: JsonProperty("versionId", NullValueHandling = NullValueHandling.Ignore)] int? VersionId,
    [property: JsonProperty("isPremium", NullValueHandling = NullValueHandling.Ignore)] bool? IsPremium,
    [property: JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)] string IconUrl
);

public record InstitutionData(
    [property: JsonProperty("finance", NullValueHandling = NullValueHandling.Ignore)] InstitutionFinance Finance
);
