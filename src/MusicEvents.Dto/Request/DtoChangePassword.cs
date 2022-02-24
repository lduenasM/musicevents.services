using System.ComponentModel.DataAnnotations;
namespace MusicEvents.Dto.Request;

public record DtoChangePassword
{
    [Required]
    public string Email { get; init; }

    [Required]
    public string OldPassword { get; init; }

    [Required]
    public string NewPassword { get; init; }
}