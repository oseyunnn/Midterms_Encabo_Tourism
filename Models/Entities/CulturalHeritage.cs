namespace QAZAQ.Models;

/// <summary>
/// Domain model representing tangible and intangible Qazaq cultural treasures.
/// </summary>
public class CulturalHeritage
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string KazakhName { get; set; } = string.Empty;
    public string KazakhTitle => KazakhName;
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CulturalSignificance { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}
