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
    }
}
