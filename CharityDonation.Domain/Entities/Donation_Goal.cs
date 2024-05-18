namespace CharityDonation.Domain.Entities;

public class Donation_Goal:Auditable
{
    public long UserId { get; set; }
    public long Donation_GoalId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal PlanAmount { get; set; }
    public decimal FactAmoun { get; set; }

}
