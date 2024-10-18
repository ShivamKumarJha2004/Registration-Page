using static System.Object;
using RegistrationPage.services.Interface;
using MySql.Data.MySqlClient;
using RegistrationPage.Models;
using System.Data;
namespace RegistrationPage.services
{
    public class UserService: IUserService
    {
        private MySqlConnection con;
        public UserService(IDataConnection dataConnection)
        {
            con = new MySqlConnection(dataConnection.ConnectionString);
        }
        public User registerUser(User userRegistrationModel)
        {
            try
            {
                con.Open();
              
                MySqlCommand cmd = new MySqlCommand("InsertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_Username", userRegistrationModel.Username);
                cmd.Parameters.AddWithValue("@p_Email", userRegistrationModel.Email);
                cmd.Parameters.AddWithValue("@p_Password", userRegistrationModel.Password);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                throw new Exception("Error in registerUser" + ex.Message);
            }
            con.Close();
            return userRegistrationModel;
        }


    }
}
