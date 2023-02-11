namespace Oguzhan.Data.Context;

public class OguzhanDb : DbContext
{
    public OguzhanDb(DbContextOptions<OguzhanDb> options) : base(options)
    {
    }
}