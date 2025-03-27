using Vibe.Core.Enums;

namespace Vibe.Core.DTO;

public record RegisterRequest(
    string? Email,
    string? Username,
    string? Password,
    string? FirstName,
    string? LastName,
    Gender? Gender,
    DateTime? DateOfBirth,
    string? City,
    byte[]? ImageUrl
    );
