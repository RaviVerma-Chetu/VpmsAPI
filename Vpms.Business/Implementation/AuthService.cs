using System;
using Vpms.Data;
using Vpms.Model;

namespace Vpms.Business.Implementation
{
    public class AuthService : IAuthService
    {
        private IAccountRepository accountRepository;
        public AuthService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public int Register(RegisterRequest registerRequest)
        {
            return accountRepository.Register(registerRequest);
        }

        public int Login(LoginRequest loginRequest,out string tokenId)
        {            
            if( accountRepository.Login(loginRequest)==1)
            {
               tokenId= accountRepository.AssignedToken(Guid.NewGuid().ToString(),loginRequest.Username);
               return 1;
            }
            else
            {
                tokenId=string.Empty;
                return 0;
            }
            // Check if login successful, then create a new token and save it DB and return it to user
        }
    }
}
