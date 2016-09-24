using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KaakateeyaBal
{
    // So that we will derive ISqlDataProvider not IOracleDataProvider 
    public class SqlDataClient : ISqlDataProvider
    {
        public SqlConnection OpenConnection()
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["183Connection"].ToString());
        }
        public void CloseConnection()
        {
            new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["183Connection"].ToString()).Close();
        }

        // Implemeting ISqlDataProvider, we are not forcing the client to implement IOracleDataProvider 

        public int ExecuteSqlCommand()
        {
            return 1;
        }
    }

    public class Interfacedataprovider
    {
        public static void ISPDemo()
        {
            // Each client will implement their respective methods no base class forces the other client to implement the methods which dont required. 
            // From the above implementation, we are not forcing Sql client to implemnt orcale logic or Oracle client to implement sql logic. 

            ISqlDataProvider SqlDataProviderObject = new SqlDataClient();

            SqlDataProviderObject.OpenConnection();
            SqlDataProviderObject.ExecuteSqlCommand();
            SqlDataProviderObject.CloseConnection();

        }
    }

    public abstract class MovieDisplay
    {
        public abstract int MovieDisplayList();
    }

    public class Derived : MovieDisplay
    {
        public override int MovieDisplayList()
        {
            return 1;
        }

    }
   
}
