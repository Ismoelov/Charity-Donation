using CharityDonation.DataAccess.Context;
using CharityDonation.Service.Models.DonationModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityDonation.Service.Service.Donation;

public class DonationService : IDonationService
{
   
    private readonly AppDbContext context;
    public DonationService(AppDbContext context)
    {
        this.context = context;
    }
    public async Task<DonationViewModel> CreateAsync(DonationCreateModel createModel)
    {
        var existDonation = await context.Donations.FirstOrDefaultAsync(donation => donation.Id == createModel.UserId);
        if (existDonation is not null)
        {
            throw new Exception($"this Donation is already with this Id {createModel.UserId} ");
        }
       
    }
    public Task<DonationViewModel> UpdateAsync(long id, DonationUpdateModel updateModel)
    {
        throw new NotImplementedException();
    }
    public Task<IEnumerable<DonationViewModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DonationViewModel> GetAsync(long id)
    {
        throw new NotImplementedException();
    }

    
}
