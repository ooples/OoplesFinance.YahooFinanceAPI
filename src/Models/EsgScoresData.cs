namespace OoplesFinance.YahooFinanceAPI.Models;

public class EnvironmentPercentile
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EnvironmentScore
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EsgScores
{
    [JsonPropertyName("maxAge")]
    public int? MaxAge { get; set; }

    [JsonPropertyName("totalEsg")] 
    public TotalEsg TotalEsg { get; set; } = new();

    [JsonPropertyName("environmentScore")] 
    public EnvironmentScore EnvironmentScore { get; set; } = new();

    [JsonPropertyName("socialScore")]
    public SocialScore SocialScore { get; set; } = new();

    [JsonPropertyName("governanceScore")]
    public GovernanceScore GovernanceScore { get; set; } = new();

    [JsonPropertyName("ratingYear")]
    public int? RatingYear { get; set; }

    [JsonPropertyName("ratingMonth")]
    public int? RatingMonth { get; set; }

    [JsonPropertyName("highestControversy")]
    public double? HighestControversy { get; set; }

    [JsonPropertyName("esgPerformance")]
    public string EsgPerformance { get; set; } = string.Empty;

    [JsonPropertyName("peerCount")]
    public int? PeerCount { get; set; }

    [JsonPropertyName("peerGroup")]
    public string PeerGroup { get; set; } = string.Empty;

    [JsonPropertyName("relatedControversy")]
    public List<string> RelatedControversy { get; set; } = new();

    [JsonPropertyName("peerEsgScorePerformance")] 
    public PeerEsgScorePerformance PeerEsgScorePerformance { get; set; } = new();

    [JsonPropertyName("peerGovernancePerformance")] 
    public PeerGovernancePerformance PeerGovernancePerformance { get; set; } = new();

    [JsonPropertyName("peerSocialPerformance")] 
    public PeerSocialPerformance PeerSocialPerformance { get; set; } = new();

    [JsonPropertyName("peerEnvironmentPerformance")] 
    public PeerEnvironmentPerformance PeerEnvironmentPerformance { get; set; } = new();

    [JsonPropertyName("peerHighestControversyPerformance")] 
    public PeerHighestControversyPerformance PeerHighestControversyPerformance { get; set; } = new();

    [JsonPropertyName("percentile")] 
    public Percentile Percentile { get; set; } = new();

    [JsonPropertyName("environmentPercentile")] 
    public EnvironmentPercentile EnvironmentPercentile { get; set; } = new();

    [JsonPropertyName("socialPercentile")]
    public SocialPercentile SocialPercentile { get; set; } = new();

    [JsonPropertyName("governancePercentile")]
    public GovernancePercentile GovernancePercentile { get; set; } = new();

    [JsonPropertyName("adult")]
    public bool? Adult { get; set; }

    [JsonPropertyName("alcoholic")]
    public bool? Alcoholic { get; set; }

    [JsonPropertyName("animalTesting")]
    public bool? AnimalTesting { get; set; }

    [JsonPropertyName("catholic")]
    public bool? Catholic { get; set; }

    [JsonPropertyName("controversialWeapons")]
    public bool? ControversialWeapons { get; set; }

    [JsonPropertyName("smallArms")]
    public bool? SmallArms { get; set; }

    [JsonPropertyName("furLeather")]
    public bool? FurLeather { get; set; }

    [JsonPropertyName("gambling")]
    public bool? Gambling { get; set; }

    [JsonPropertyName("gmo")]
    public bool? Gmo { get; set; }

    [JsonPropertyName("militaryContract")]
    public bool? MilitaryContract { get; set; }

    [JsonPropertyName("nuclear")]
    public bool? Nuclear { get; set; }

    [JsonPropertyName("pesticides")]
    public bool? Pesticides { get; set; }

    [JsonPropertyName("palmOil")]
    public bool? PalmOil { get; set; }

    [JsonPropertyName("coal")]
    public bool? Coal { get; set; }

    [JsonPropertyName("tobacco")]
    public bool? Tobacco { get; set; }
}

public class GovernancePercentile
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class GovernanceScore
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class PeerEnvironmentPerformance
{
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    [JsonPropertyName("avg")]
    public double? Avg { get; set; }

    [JsonPropertyName("max")]
    public double? Max { get; set; }
}

public class PeerEsgScorePerformance
{
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    [JsonPropertyName("avg")]
    public double? Avg { get; set; }

    [JsonPropertyName("max")]
    public double? Max { get; set; }
}

public class PeerGovernancePerformance
{
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    [JsonPropertyName("avg")]
    public double? Avg { get; set; }

    [JsonPropertyName("max")]
    public double? Max { get; set; }
}

public class PeerHighestControversyPerformance
{
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    [JsonPropertyName("avg")]
    public double? Avg { get; set; }

    [JsonPropertyName("max")]
    public double? Max { get; set; }
}

public class PeerSocialPerformance
{
    [JsonPropertyName("min")]
    public double? Min { get; set; }

    [JsonPropertyName("avg")]
    public double? Avg { get; set; }

    [JsonPropertyName("max")]
    public double? Max { get; set; }
}

public class Percentile
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class EsgScoresQuoteSummary
{
    [JsonPropertyName("result")]
    public List<EsgScoresResult> Results { get; set; } = new();

    [JsonPropertyName("error")]
    public object Error { get; set; } = new();
}

public class EsgScoresResult
{
    [JsonPropertyName("esgScores")]
    public EsgScores EsgScores { get; set; } = new();
}

public class EsgScoresData
{
    [JsonPropertyName("quoteSummary")]
    public EsgScoresQuoteSummary QuoteSummary { get; set; } = new();
}

public class SocialPercentile
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class SocialScore
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}

public class TotalEsg
{
    [JsonPropertyName("raw")]
    public double? Raw { get; set; }

    [JsonPropertyName("fmt")]
    public string Fmt { get; set; } = string.Empty;
}