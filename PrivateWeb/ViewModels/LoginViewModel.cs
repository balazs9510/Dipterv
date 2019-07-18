using System.ComponentModel.DataAnnotations;

namespace PrivateWeb.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Felhasználónév"), Required(ErrorMessage = "A felhasználónév megadása kötelező")]
        public string UserName { get; set; }
        [Display(Name = "Jelszó"), Required(ErrorMessage = "A jelszó megadása kötelező"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Maradjak belépve")]
        public bool KeepMeSignedIn { get; set; }
    }
}
