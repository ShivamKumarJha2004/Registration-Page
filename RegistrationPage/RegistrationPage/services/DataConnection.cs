
using RegistrationPage.services.Interface;

namespace RegistrationPage.services
{
    public class DataConnection:IDataConnection
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
