namespace Vpms.Model
{
    public class AuthResponse : BaseSecureRequest
    {
        public bool IsAuthenticated { get; set; }

        //public string Password { get; set; }
    }
}