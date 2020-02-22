namespace webapiuno.Models
{
    using System.Data.Entity;
    public class DataContext :DbContext
    {
        public DataContext():base("defaultconnection")
        {

        }

        public System.Data.Entity.DbSet<webapiuno.Models.Person> People { get; set; }
    }
}