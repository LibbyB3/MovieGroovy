using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLibrary.DataAccess;

namespace AppLibrary
{
    /// <summary>
    /// all elements that are in this class will be static
    /// </summary>
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; set; } //this is a property
        public static void InitializeConnection() //what is the point of being void again?
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql; //implement the IDataConnection interface
        }
        public static string CnnString(String name) //uses the connections in the createmovform
        {                                           // to save things to the DB
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
