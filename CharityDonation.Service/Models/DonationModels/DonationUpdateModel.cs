using CharityDonation.Domain.Entities;
using CharityDonation.Domain.Enum;

namespace CharityDonation.Service.Models.DonationModels;

public class DonationUpdateModel
{
    public string Name { get; set; }
    public long UserId { get; set; }
    public DonationType donationType { get; set; }
    public decimal Ammount { get; set; }
}
