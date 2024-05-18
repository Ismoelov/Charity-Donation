
namespace CharityDonation.Domain.Entities;

public class User:Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public decimal Balance { get; set; }
    public IEnumerable<Donation> donations { get; set; }
}
