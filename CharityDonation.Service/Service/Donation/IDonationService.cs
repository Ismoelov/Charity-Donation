

using CharityDonation.Service.Models.DonationModels;

namespace CharityDonation.Service.Service.Donation;

public interface IDonationService
{
    Task<DonationViewModel> CreateAsync(DonationCreateModel createModel);
    Task<DonationViewModel> UpdateAsync(long id, DonationUpdateModel updateModel);
    Task<DonationViewModel> GetAsync(long id); 
    Task<IEnumerable<DonationViewModel>> GetAllAsync();
}
