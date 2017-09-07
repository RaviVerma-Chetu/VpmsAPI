using System;
using Vpms.Model;

namespace Vpms.Business
{
    public interface IAuthService
    {
        int Register(RegisterRequest registerRequest);

        int Login(LoginRequest loginRequest,out string tokenId);
    }
}
