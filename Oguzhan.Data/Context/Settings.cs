namespace Oguzhan.Data.Context;

public class Settings
{
    public DatabaseConfiguration Database { get; set; }

    public class DatabaseConfiguration
    {
        public string ConnectionString { get; set; }
    }
}