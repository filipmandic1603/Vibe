using Vibe.Core.Enums;

namespace Vibe.Core.DTO;

public record AutheticationResponse(
    Guid Id,
    string? Email,
    string? Username,
    string? Password,
    string? FirstName,
    string? LastName,
    Gender? Gender,
    DateTime? DateOfBirth,
    string? City,
    byte[]? ImageUrl,
    string? Tokken,
    bool Success
    );