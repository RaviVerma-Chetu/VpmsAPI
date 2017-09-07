namespace Vpms.Data
{
    using Vpms.Model;
    public interface IAccountRepository
    {
        int Register(RegisterRequest registerRequest);

        int Login(LoginRequest loginRequest);

        string AssignedToken(string tokenId,string userName);
    }
}
