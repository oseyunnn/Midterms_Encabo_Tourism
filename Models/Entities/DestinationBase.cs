namespace QAZAQ.Models;

/// <summary>
/// Abstract base class illustrating OOP inheritance, encapsulation, and polymorphism.
/// </summary>
public abstract class DestinationBase
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string KazakhName { get; set; } = string.Empty;
    public Region Region { get; set; }
    public SpotCategory Category { get; set; }
    public string ShortDescription { get; set; } = string.Empty;
    public string FullDescription { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public decimal BasePriceUsd { get; set; }
    public double Rating { get; set; }
    public int ReviewCount { get; set; }
    public string BestSeason { get; set; } = string.Empty;

    /// <summary>
    /// Polymorphic cost calculation customized by subclasses.
    /// </summary>
    public abstract decimal CalculatePackageCost(int travelers, bool includeNomadicGuide);

    /// <summary>
    /// Formatted location tag for visual cards.
    /// </summary>
    public virtual string GetFormattedRegion()
    {
        return Region switch
        {
            Region.AlmatyRegion => "Almaty Region",
            Region.Mangystau => "Mangystau Peninsula",
            Region.Turkistan => "Turkistan Silk Road",
            Region.AstanaCapital => "Astana Capital",
            Region.EastKazakhstan => "East Kazakhstan / Altai",
            _ => Region.ToString()
        };
    }
}
