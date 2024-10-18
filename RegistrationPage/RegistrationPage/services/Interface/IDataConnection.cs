namespace RegistrationPage.services.Interface
{
    public interface IDataConnection
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

    }
}
