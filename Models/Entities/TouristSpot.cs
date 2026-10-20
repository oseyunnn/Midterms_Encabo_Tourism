namespace QAZAQ.Models;

/// <summary>
/// Domain model for Kazakhstan tourist spot destinations inheriting from DestinationBase.
/// </summary>
public class TouristSpot : DestinationBase
{
    public List<string> Highlights { get; set; } = new();
    public DifficultyLevel Difficulty { get; set; } = DifficultyLevel.Easy;
    public int DurationDays { get; set; } = 1;
    public int AltitudeMeters { get; set; }
    public bool IsUnescoHeritage { get; set; }
    public bool IsPopular { get; set; }
    public bool IsSaved { get; set; }

    /// <summary>
    /// Overridden polymorphic pricing logic with group discounting and optional guide surcharge.
    /// </summary>
    public override decimal CalculatePackageCost(int travelers, bool includeNomadicGuide)
    {
        int validTravelers = Math.Max(1, travelers);
        decimal baseCost = BasePriceUsd * validTravelers;

        // Group incentive: 12% discount for groups of 4 or more
        if (validTravelers >= 4)
        {
            baseCost *= 0.88m;
        }

        // Daily guide fee
        if (includeNomadicGuide)
        {
            baseCost += 65m * Math.Max(1, DurationDays);
        }

        return Math.Round(baseCost, 2);
    }
}
