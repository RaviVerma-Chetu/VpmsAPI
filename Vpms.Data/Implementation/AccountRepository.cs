namespace Vpms.Data.Implementation
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Vpms.Model;
    using Vpms.Model.Entities;
    public class AccountRepository : IAccountRepository
    {
        private ApplicationDbContext context;

        public AccountRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public int Register(RegisterRequest registerRequest)
        {
            User user = new User();
            user.Username = registerRequest.Username;
            user.Email = registerRequest.Email;
            user.Password = registerRequest.Password;
            user.MobileNumber = registerRequest.PhoneNumber;

            context.User.Add(user);
            return context.SaveChanges();
        }
    }
}
