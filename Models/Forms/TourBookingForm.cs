using System.ComponentModel.DataAnnotations;

namespace QAZAQ.Models;

/// <summary>
/// Validated form model for booking a Kazakhstan tourist spot expedition.
/// </summary>
public class TourBookingForm
{
    [Required(ErrorMessage = "Please select a destination spot.")]
    [Range(1, int.MaxValue, ErrorMessage = "Please select a valid destination.")]
    public int SpotId { get; set; }

    [Required(ErrorMessage = "Your full name is required.")]
    [StringLength(70, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 70 characters.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email address is required for expedition confirmation.")]
    [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required for dispatch communication.")]
    [RegularExpression(@"^(\+?[0-9\s\-\(\)]{8,20})$", ErrorMessage = "Please enter a valid phone number (e.g. +7 701 555 0192).")]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select your arrival or start date.")]
    public DateTime? TravelDate { get; set; } = DateTime.Today.AddDays(14);

    [Range(1, 20, ErrorMessage = "Expedition party must be between 1 and 20 travelers.")]
    public int Travelers { get; set; } = 2;

    public bool IncludeGuide { get; set; } = true;

    public bool IncludeYurtExperience { get; set; } = true;

    [StringLength(400, ErrorMessage = "Special requests must not exceed 400 characters.")]
    public string? SpecialRequests { get; set; }

    /// <summary>
    /// Computes the dynamic pricing estimate based on selected spot attributes.
    /// </summary>
    public decimal ComputeEstimate(decimal baseSpotPrice, int durationDays)
    {
        int count = Math.Max(1, Travelers);
        decimal subtotal = baseSpotPrice * count;

        if (count >= 4)
        {
            subtotal *= 0.88m; // 12% group discount
        }

        if (IncludeGuide)
        {
            subtotal += 65m * Math.Max(1, durationDays);
        }

        if (IncludeYurtExperience)
        {
            subtotal += 45m * count;
        }

        return Math.Round(subtotal, 2);
    }
}
