using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityDonation.Service.Models.DonationGoalModels;

public class DonationGoalCreateModel
{

    public long UserId { get; set; }
    public long Donation_GoalId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public decimal Plan_Ammount { get; set; }
    public decimal Fact_Ammoun { get; set; }
}
