namespace Vibe.Core.DTO;

public record LoginRequest(
    string? Email,
    string? Password
    );
