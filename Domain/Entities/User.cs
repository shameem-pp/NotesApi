﻿using Domain.Entities.Base;

namespace Domain.Entities;

public class User : EntityBase
{
    public string AppUserId { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string FirstName { get; set; } = default!;
    public string? LastName { get; set; }
    public string? About { get; set; }
    public string? Phone { get; set; }
    public string? TwitterUrl { get; set; }
    public string? FacebookUrl { get; set; }
    public string? InstagamUrl { get; set; }
}
