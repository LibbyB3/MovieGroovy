using AppLibrary.Models;
using Dapper;
//using MovieAppCSC660.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public UsersModel CreateUser(UsersModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                var p = new DynamicParameters();
                p.Add("@Username", model.Username);
                p.Add("@Email", model.Email);
                p.Add("@Password", model.Password);
                //p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("InsertUser", p, commandType: CommandType.StoredProcedure);

                //model.UserID = p.Get<int>("@id");

                return model;
            }
        }
    }
}
