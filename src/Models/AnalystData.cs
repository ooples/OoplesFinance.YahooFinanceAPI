namespace OoplesFinance.YahooFinanceAPI.Models;

public record AnalystCriteriaMeta(
        [property: JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)] int? Size,
        [property: JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)] int? Offset,
        [property: JsonProperty("sortField", NullValueHandling = NullValueHandling.Ignore)] string SortField,
        [property: JsonProperty("sortType", NullValueHandling = NullValueHandling.Ignore)] string SortType,
        [property: JsonProperty("entityIdType", NullValueHandling = NullValueHandling.Ignore)] string EntityIdType,
        [property: JsonProperty("criteria", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<AnalystCriterion> Criteria,
        [property: JsonProperty("topOperator", NullValueHandling = NullValueHandling.Ignore)] string TopOperator
    );

public record AnalystCriterion(
    [property: JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)] string Field,
    [property: JsonProperty("operators", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<string> Operators,
    [property: JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int?> Values,
    [property: JsonProperty("labelsSelected", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<int?> LabelsSelected,
    [property: JsonProperty("dependentValues", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<object> DependentValues
);

public record AnalystFinance(
    [property: JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<AnalystResult> Results,
    [property: JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)] object Error
);

public record AnalystRecord(
    [property: JsonProperty("marketCap", NullValueHandling = NullValueHandling.Ignore)] double? MarketCap,
    [property: JsonProperty("dayVolume", NullValueHandling = NullValueHandling.Ignore)] int? DayVolume,
    [property: JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)] double? Price,
    [property: JsonProperty("pricePercentChange", NullValueHandling = NullValueHandling.Ignore)] double? PricePercentChange,
    [property: JsonProperty("intradayPriceChange", NullValueHandling = NullValueHandling.Ignore)] double? IntradayPriceChange,
    [property: JsonProperty("ratingDate", NullValueHandling = NullValueHandling.Ignore)] string RatingDate,
    [property: JsonProperty("ratingPrior", NullValueHandling = NullValueHandling.Ignore)] string RatingPrior,
    [property: JsonProperty("ratingCurrent", NullValueHandling = NullValueHandling.Ignore)] string RatingCurrent,
    [property: JsonProperty("ratingAction", NullValueHandling = NullValueHandling.Ignore)] string RatingAction,
    [property: JsonProperty("priceTargetCurrent", NullValueHandling = NullValueHandling.Ignore)] double? PriceTargetCurrent,
    [property: JsonProperty("priceTargetAction", NullValueHandling = NullValueHandling.Ignore)] string PriceTargetAction,
    [property: JsonProperty("upsideDownsidePercent", NullValueHandling = NullValueHandling.Ignore)] double? UpsideDownsidePercent,
    [property: JsonProperty("averageRating", NullValueHandling = NullValueHandling.Ignore)] string AverageRating,
    [property: JsonProperty("averagePriceTarget", NullValueHandling = NullValueHandling.Ignore)] double? AveragePriceTarget,
    [property: JsonProperty("analystFirm", NullValueHandling = NullValueHandling.Ignore)] string AnalystFirm,
    [property: JsonProperty("ticker", NullValueHandling = NullValueHandling.Ignore)] string Ticker,
    [property: JsonProperty("companyName", NullValueHandling = NullValueHandling.Ignore)] string CompanyName,
    [property: JsonProperty("delayedPrice", NullValueHandling = NullValueHandling.Ignore)] double? DelayedPrice,
    [property: JsonProperty("fiftyTwoWeekRange", NullValueHandling = NullValueHandling.Ignore)] string FiftyTwoWeekRange,
    [property: JsonProperty("logoUrl", NullValueHandling = NullValueHandling.Ignore)] string LogoUrl,
    [property: JsonProperty("priceTargetPrior", NullValueHandling = NullValueHandling.Ignore)] double? PriceTargetPrior
);

public record AnalystResult(
    [property: JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] string Id,
    [property: JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)] string Title,
    [property: JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)] string Description,
    [property: JsonProperty("canonicalName", NullValueHandling = NullValueHandling.Ignore)] string CanonicalName,
    [property: JsonProperty("criteriaMeta", NullValueHandling = NullValueHandling.Ignore)] AnalystCriteriaMeta CriteriaMeta,
    [property: JsonProperty("rawCriteria", NullValueHandling = NullValueHandling.Ignore)] string RawCriteria,
    [property: JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)] int? Start,
    [property: JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)] int? Count,
    [property: JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)] int? Total,
    [property: JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)] IReadOnlyList<AnalystRecord> Records,
    [property: JsonProperty("userHasReadRecord", NullValueHandling = NullValueHandling.Ignore)] bool? UserHasReadRecord,
    [property: JsonProperty("useRecords", NullValueHandling = NullValueHandling.Ignore)] bool? UseRecords,
    [property: JsonProperty("predefinedScr", NullValueHandling = NullValueHandling.Ignore)] bool? PredefinedScr,
    [property: JsonProperty("versionId", NullValueHandling = NullValueHandling.Ignore)] int? VersionId,
    [property: JsonProperty("isPremium", NullValueHandling = NullValueHandling.Ignore)] bool? IsPremium,
    [property: JsonProperty("iconUrl", NullValueHandling = NullValueHandling.Ignore)] string IconUrl
);

public record AnalystData(
    [property: JsonProperty("finance", NullValueHandling = NullValueHandling.Ignore)] AnalystFinance Finance
);