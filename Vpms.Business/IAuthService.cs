using System;
using Vpms.Model;

namespace Vpms.Business
{
    public interface IAuthService
    {
        int Register(RegisterRequest registerRequest);
    }
}
