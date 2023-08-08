using System.ComponentModel.DataAnnotations;

namespace CoreClean.BCL.Application.Requests.Identity;

public class TokenRequest
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}