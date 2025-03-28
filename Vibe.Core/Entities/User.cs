﻿using Vibe.Core.Enums;

namespace Vibe.Core.Entities;

public class User
{
    public Guid UserId { get; set; }
    public string? Email { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Gender? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? City { get; set; }
    public byte[]? ImageUrl { get; set; }

}
