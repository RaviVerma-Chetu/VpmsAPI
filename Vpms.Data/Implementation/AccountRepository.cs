namespace Vpms.Data.Implementation
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
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
            user.FirstName=registerRequest.Firstname;
            user.LastName=registerRequest.Lastname;
            user.Username = registerRequest.Username;
            user.Email = registerRequest.Email;
            user.Password = registerRequest.Password;
            user.MobileNumber = registerRequest.PhoneNumber;

            context.User.Add(user);
            return context.SaveChanges();
        }

        public int Login(LoginRequest loginRequest){
            var user = context.User.Where(u => u.Username == loginRequest.Username && u.Password == loginRequest.Password)
            .FirstOrDefault();
            if(user != null){
                return 1;
            }
            return 0;
        }
    }
}
