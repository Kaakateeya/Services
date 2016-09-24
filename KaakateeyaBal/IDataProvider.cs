using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KaakateeyaBal
{
    // Only common generic methods exists for all derived classes. 

    public interface IDataProvider
    {
        SqlConnection OpenConnection();
        void CloseConnection();
    }
    // Implement methods specific to the respective sql derived classes 
    public interface ISqlDataProvider : IDataProvider
    {
        int ExecuteSqlCommand();
    }

    // Implement methods specific to the respective Oracle derived classes 
    //public interface IOracleDataProvider : IDataProvider
    //{
    //    int ExecuteOracleCommand();
    //}


    //public interface ICredentials
    //{
        
    //    //NetworkCredential GetCredential(Uri uri, string authType);
    //}

    //public class NetworkCredential : ICredentials
    //{
    //    public NetworkCredential(string userName, string password);
    //}


}
