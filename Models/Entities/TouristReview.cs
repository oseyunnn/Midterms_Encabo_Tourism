namespace QAZAQ.Models;

/// <summary>
/// Domain model for verified past tourist reviews and expedition journals.
/// </summary>
public class TouristReview
{
    public int Id { get; set; }
    public string AuthorName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string DestinationName { get; set; } = string.Empty;
    public int Rating { get; set; } = 5;
    public string TravelMonth { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public int HelpfulVotes { get; set; }
    public bool IsVerifiedGuest { get; set; } = true;
    public bool HasVotedHelpful { get; set; }
}
