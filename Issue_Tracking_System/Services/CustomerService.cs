using Issue_Tracking_System.Models.Entities;
using Issue_Tracking_System.Models.Forms;
using Issue_Tracking_System.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Issue_Tracking_System.Services
{
    internal class CustomerService
    {
        public static IssueTrackingDataContext _context = new IssueTrackingDataContext();
        public static async Task<int> SaveAsync(Customer customer)
        {
            var _customerEntity = new CustomerEntity
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber ?? "",
            };

            var _addressEntity = await _context.Addresses.FirstOrDefaultAsync(x => x.StreetName == customer.StreetName && x.PostalCode == customer.PostalCode && x.City == customer.City);

            if (_addressEntity != null)
            {
                _customerEntity.AddressId = _addressEntity.Id;
            }
            else
                _customerEntity.Address = new AddressEntity
                {
                    StreetName = customer.StreetName,
                    PostalCode = customer.PostalCode,
                    City = customer.City,
                };

            _context.Add(_customerEntity);
            await _context.SaveChangesAsync();
            return _customerEntity.Id;
        }
    }
}