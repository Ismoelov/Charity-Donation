using CharityDonation.DataAccess.Context;
using CharityDonation.Domain.Entities;
using CharityDonation.Service.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace CharityDonation.Service.Service.User;

public class UserService : IUserService
{
    
    private readonly AppDbContext context;
    public UserService(AppDbContext context)
    {
        this.context = context;
    }
    public async Task<UserViewModel> CreateAsync(UserCreateModel createModel)
    {
       var existUser = await context.Users.FirstOrDefaultAsync(user=> user.PhoneNumber == createModel.PhoneNumber);
        if (existUser is not null)
            throw new Exception($"This User is alaready exist with this phone {createModel.PhoneNumber}");

        var createUser = (await context.Users.AddAsync(Mapper.Map(createModel))).Entity;
        await context.SaveChangesAsync();
        return Mapper.Map(createUser);

    }
    public async Task<UserViewModel> UpdateAsync(long id,UserUpdateModel updateModel)
    {
        var existUser = await context.Users.FirstOrDefaultAsync(user => user.Id == id)
         ?? throw new Exception($"User is not found with this Id={id}");
        var AlreadyexistUser = await context.Users.FirstOrDefaultAsync(user => user.PhoneNumber == updateModel.PhoneNumber);
        if (existUser is not null)
            throw new Exception($"This User is already exist with this phone {updateModel.PhoneNumber}");
        existUser.PhoneNumber = updateModel.PhoneNumber;
        existUser.FirstName = updateModel.FirstName;
        existUser.LastName = updateModel.LastName;
        existUser.UpdatedAt= DateTime.UtcNow;

        context.Users.Update(existUser);
        await context.SaveChangesAsync();
        return Mapper.Map(existUser);

    }
    public async Task<bool> DeleteAsync(long id)
    {
        var existUser = await context.Users.FirstOrDefaultAsync(u => u.Id == id)
            ?? throw new Exception($"User is not found with this Id={id}");
        existUser.IsDelete = true;
        existUser.Deleted = DateTime.UtcNow;
        
        return true;
    }
    public async Task<UserViewModel> GetByIdAsync(long id)
    {
        var existUser =  await context.Users.FirstOrDefaultAsync(u => u.Id == id)
            ?? throw new Exception($"User is not found with this Id={id}");
        return Mapper.Map(existUser);
    }

    public async Task<IEnumerable<UserViewModel>> GetAllAsync()
    {
        var users= await context.Users.ToListAsync();
        return Mapper.Map(users)
    }

   
  
}

