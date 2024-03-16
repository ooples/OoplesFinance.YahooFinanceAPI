namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class CalendarEventsHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Calendar Events data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var calendarEvents = JsonConvert.DeserializeObject<CalendarEventsData>(jsonData);

        return calendarEvents != null ? (IEnumerable<T>)calendarEvents.QuoteSummary.Results.Select(x => x.CalendarEvents) : [];
    }
}
