using Microsoft.EntityFrameworkCore;

namespace EFCoreSession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Open Connection
           using ApplicationDBContext DBContext = new ApplicationDBContext();
            // Connection UnManged Resource 
            // Solution => use  Using keyword 

            DBContext.Database.MigrateAsync();
            DBContext.SaveChangesAsync();

        }
    }
}
