using CharityDonation.Service.Models.UserModels;

namespace CharityDonation.Service.Service.User;

public interface IUserService
{
    Task<UserViewModel> CreateAsync(UserCreateModel createModel);
    Task<UserViewModel> UpdateAsync(long id ,UserUpdateModel updateModel);
    Task<bool> DeleteAsync(long id);
    Task<UserViewModel> GetByIdAsync(long id);
    Task<IEnumerable<UserViewModel>> GetAllAsync();
}