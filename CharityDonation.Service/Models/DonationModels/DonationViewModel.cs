using CharityDonation.Domain.Entities;
using CharityDonation.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityDonation.Service.Models.DonationModels;

public class DonationViewModel
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public DonationType donationType { get; set; }
    public decimal Ammount { get; set; }
}
