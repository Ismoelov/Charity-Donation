using CharityDonation.Domain.Entities;
using CharityDonation.Service.Models.DonationModels;
using CharityDonation.Service.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CharityDonation.Service
{
    #region User
    public static class Mapper
    {
       
        public static User Map(UserCreateModel createModel)
        {
            return new User
            {
                PhoneNumber = createModel.PhoneNumber,
                FirstName = createModel.FirstName,
                LastName = createModel.LastName,
                Password = createModel.Password,
                Blance = createModel.Blance,
                
            };
        }

        public static UserViewModel Map(User user)
        {
            return new UserViewModel
            {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    Blance = user.Blance,

            };
        }

        public static IEnumerable<UserViewModel> Map( List<User> user)
        {
            var result= new List<UserViewModel>();
            user.ForEach(user => result.Add(new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                Blance = user.Blance
            }));
           
            return result;
        }
    }
    #endregion

    #region Donation 

    public static Donation Map(DonationCreateModel createModel)
    {
        return new Donation
        {
            Name = createModel.Name,
            Ammount = createModel.Ammount,

            
        };
    }








    #endregion

}
