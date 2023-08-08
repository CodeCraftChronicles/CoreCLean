using System.ComponentModel.DataAnnotations;

namespace CoreClean.BCL.Application.Requests.Identity;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}