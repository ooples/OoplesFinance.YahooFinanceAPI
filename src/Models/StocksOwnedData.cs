namespace OoplesFinance.YahooFinanceAPI.Models;

public record StocksOwnedCriteriaMeta(
        [property: JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)] int? Size,
        [property: JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)] int? Offset,
        [property: JsonProperty("sortField", NullValueHandling = NullValueHandling.Ignore)] string SortField,
        [property: JsonProperty("sortType", NullValueHandling = NullValueHandling.Ignore)] string SortType,
        [property: JsonProperty("entityIdType", NullValueHandling = NullValueHandling.Ignore)] string EntityIdType,
        [property: JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<StocksOwnedCriterion> Criteria,
        [property: JsonProperty("topOperator", NullValueHandling = NullValueHandling.Ignore)] string TopOperator
    );

public record StocksOwnedCriterion(
    [property: JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)] string Field,
    [property: JsonProperty("operators", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<string> Operators,
    [property: JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<string> Values,
    [property: JsonProperty("labelsSelected", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int?> LabelsSelected,
    [property: JsonProperty("dependentValues", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<object> DependentValues
);

public record StocksOwnedFinance(
    [property: JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<StocksOwnedResult> Results,
    [property: JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)] object Error
);

public record StocksOwnedRecord(
    [property: JsonProperty("formType", NullValueHandling = NullValueHandling.Ignore)] string FormType,
    [property: JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)] string Ticker,
    [property: JsonProperty("companyName", NullValueHandling = NullValueHandling.Ignore)] string CompanyName,
    [property: JsonProperty("fileDate", NullValueHandling = NullValueHandling.Ignore)] object FileDate,
    [property: JsonProperty("fundName", NullValueHandling = NullValueHandling.Ignore)] string FundName,
    [property: JsonProperty("fundType", NullValueHandling = NullValueHandling.Ignore)] string FundType,
    [property: JsonProperty("prevShares", NullValueHandling = NullValueHandling.Ignore)] int? PrevShares,
    [property: JsonProperty("currentShares", NullValueHandling = NullValueHandling.Ignore)] int? CurrentShares,
    [property: JsonProperty("percentChangeInShares", NullValueHandling = NullValueHandling.Ignore)] double? PercentChangeInShares,
    [property: JsonProperty("ownershipPercent", NullValueHandling = NullValueHandling.Ignore)] double? OwnershipPercent,
    [property: JsonProperty("percentChangeInOwnership", NullValueHandling = NullValueHandling.Ignore)] double? PercentChangeInOwnership,
    [property: JsonProperty("percentOfSharesOutstanding", NullValueHandling = NullValueHandling.Ignore)] double? PercentOfSharesOutstanding,
    [property: JsonProperty("fundAum", NullValueHandling = NullValueHandling.Ignore)] object FundAum,
    [property: JsonProperty("logoUrl", NullValueHandling = NullValueHandling.Ignore)] string LogoUrl
);

public record StocksOwnedResult(
    [property: JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] string Id,
    [property: JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)] string Title,
    [property: JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)] string Description,
    [property: JsonProperty("canonicalName", NullValueHandling = NullValueHandling.Ignore)] string CanonicalName,
    [property: JsonProperty("criteriaMeta", NullValueHandling = NullValueHandling.Ignore)] StocksOwnedCriteriaMeta CriteriaMeta,
    [property: JsonProperty("rawCriteria", NullValueHandling = NullValueHandling.Ignore)] string RawCriteria,
    [property: JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)] int? Start,
    [property: JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)] int? Count,
    [property: JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)] int? Total,
    [property: JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<StocksOwnedRecord> Records,
    [property: JsonProperty("userHasReadRecord", NullValueHandling = NullValueHandling.Ignore)] bool? UserHasReadRecord,
    [property: JsonProperty("useRecords", NullValueHandling = NullValueHandling.Ignore)] bool? UseRecords,
    [property: JsonProperty("predefinedScr", NullValueHandling = NullValueHandling.Ignore)] bool? PredefinedScr,
    [property: JsonProperty("versionId", NullValueHandling = NullValueHandling.Ignore)] int? VersionId,
    [property: JsonProperty("isPremium", NullValueHandling = NullValueHandling.Ignore)] bool? IsPremium,
    [property: JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)] string IconUrl
);

public record StocksOwnedData(
    [property: JsonProperty("finance", NullValueHandling = NullValueHandling.Ignore)] StocksOwnedFinance Finance
);
