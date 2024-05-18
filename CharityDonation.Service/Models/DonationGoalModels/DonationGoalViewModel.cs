namespace CharityDonation.Service.Models.DonationGoalModels;

public class DonationGoalViewModel
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long Donation_GoalId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal Plan_Ammount { get; set; }
    public decimal Fact_Ammoun { get; set; }
}
