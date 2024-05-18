using CharityDonation.Domain.Enum;

namespace CharityDonation.Domain.Entities;

public class Donation:Auditable
{
    public string Name { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public DonationType donationType { get; set; }
    public decimal Amount { get; set; }
}
