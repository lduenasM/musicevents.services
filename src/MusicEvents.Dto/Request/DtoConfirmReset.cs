namespace MusicEvents.Dto.Request;

public record DtoConfirmReset(string Email, string Token, string Password);
