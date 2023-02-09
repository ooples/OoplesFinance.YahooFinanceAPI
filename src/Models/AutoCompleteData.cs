namespace OoplesFinance.YahooFinanceAPI.Models;

public record AutoCompleteResult(
        [property: JsonPropertyName("symbol")] string Symbol,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("exch")] string Exch,
        [property: JsonPropertyName("type")] string Type,
        [property: JsonPropertyName("exchDisp")] string ExchDisp,
        [property: JsonPropertyName("typeDisp")] string TypeDisp
    );

public record ResultSet(
    [property: JsonPropertyName("Query")] string Query,
    [property: JsonPropertyName("Result")] IReadOnlyList<AutoCompleteResult> Results
);

public record AutoCompleteData(
    [property: JsonPropertyName("ResultSet")] ResultSet ResultSet
);
