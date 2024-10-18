using RegistrationPage.Models;


namespace RegistrationPage.services.Interface

{
    public interface IUserService
    {
        public User registerUser(User userRegistrationModel);
    }
}
