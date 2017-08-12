namespace Vpms.Data
{
    using Vpms.Model;
    public interface IAccountRepository
    {
        int Register(RegisterRequest registerRequest);
    }
}
