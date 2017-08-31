namespace Vpms.Model
{
    using System.ComponentModel.DataAnnotations;
    public class RegisterRequest{
        [Required(ErrorMessage="Firstname is required.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage="Lastname is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage="Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage="Password is required.")]
        public string Password { get; set; }        

        [Required(ErrorMessage="Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage="Phone number is required.")]
        public string PhoneNumber { get; set; }
    }
}