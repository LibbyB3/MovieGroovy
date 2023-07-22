using AppLibrary.Models;
//using MovieAppCSC660.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.DataAccess
{
    /// <summary>
    /// once, again, changing our interface to public
    /// </summary>
    public interface IDataConnection
    {
        /// <summary>
        /// UsersModel is the class and CreateUser is the method that we are using to set up the connection to the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns> as of right now it does not return anything</returns>
        UsersModel CreateUser(UsersModel user);
        
        MoviesModel CreateMovie(MoviesModel movie);

    }
}
