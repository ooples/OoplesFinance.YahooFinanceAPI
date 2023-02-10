namespace OoplesFinance.YahooFinanceAPI.Models;

public record AutoCompleteResult(
        [property: JsonProperty("symbol")] string Symbol,
        [property: JsonProperty("name")] string Name,
        [property: JsonProperty("exch")] string Exch,
        [property: JsonProperty("type")] string Type,
        [property: JsonProperty("exchDisp")] string ExchDisp,
        [property: JsonProperty("typeDisp")] string TypeDisp
    );

public record ResultSet(
    [property: JsonProperty("Query")] string Query,
    [property: JsonProperty("Result")] IReadOnlyList<AutoCompleteResult> Results
);

public record AutoCompleteData(
    [property: JsonProperty("ResultSet")] ResultSet ResultSet
);
