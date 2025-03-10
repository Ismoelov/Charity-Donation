﻿
namespace CharityDonation.Domain.Entities;

public abstract class Auditable
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set;} 
    public DateTime Deleted {  get; set; }
    public bool IsDelete { get; set; }
}
