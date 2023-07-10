using Dapper;
using MovieAppCSC660.Models;
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
        // TODO - make create title method actually save to the database
        /// <summary>
        /// this is the correction given to us, save a new title to the DB
        /// </summary>
        /// <param name="model">
        /// the title info
        /// </param>
        /// <returns>
        /// the title info with the unique identifiere
        /// </returns>
        /// <exception cref="NotImplementedException"></exception>
        public TitleModel CreateTitle(TitleModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                var p = new DynamicParameters();
                p.Add("@Title", model.Title);
                p.Add("@id", 0, dbType: DbType.Int32,direction:ParameterDirection.Output);

                connection.Execute("spTitle_Insert", p, commandType: CommandType.StoredProcedure);

                model.MovieId = p.Get<int>("@id");

                return model;
            }
        }
        /// <summary>
        /// this creates and saves the primary director's name back to the database 
        /// </summary>
        /// <param name="modelPD">
        /// primary director's info
        /// </param>
        /// <returns>
        /// the primary director's name with unique id
        /// </returns>
        public PrimaryDirectorModel CreatePrimaryDirector(PrimaryDirectorModel modelPD)
        {
            //using this makes sure the conn is clearly disconnected w/out memory leaking
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                var p = new DynamicParameters();
                p.Add("@firstName", modelPD.FirstName);
                p.Add("@lastName",modelPD.LastName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spPrimaryDirector_Insert", p, commandType: CommandType.StoredProcedure);

                modelPD.DirectorId = p.Get<int>("@id");

                return modelPD; //DO NOT FORGET TO RETURN
            }
        }
        /// <summary>
        /// this will create a genre and save it to the database
        /// </summary>
        /// <param name="modelG">
        /// genre info
        /// </param>
        /// <returns>
        /// the genre and id 
        /// </returns>
        public GenreModel CreateGenre(GenreModel modelG)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                var p = new DynamicParameters();
                p.Add("@genre", modelG.Genre);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spGenre_Insert", p, commandType: CommandType.StoredProcedure);

                modelG.GenreId = p.Get<int>("@id");

                return modelG;
            }
        }
        /// <summary>
        /// this saves the description of the movie to the database
        /// </summary>
        /// <param name="modelS">
        /// the info/description of the movie
        /// </param>
        /// <returns>
        /// the movie's description and synopsis id
        /// </returns>
        public SynopsisModel CreateSynopsis(SynopsisModel modelS)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                var p = new DynamicParameters();
                p.Add("@description", modelS.Description);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spSynopsis_Insert", p, commandType: CommandType.StoredProcedure);

                modelS.SynopsisId = p.Get<int>("@id");

                return modelS;
            }
        }
        /// <summary>
        /// saving the year a movie was made to the database
        /// </summary>
        /// <param name="modelY">
        /// the year info
        /// </param>
        /// <returns>
        /// the year a movie was made and the year id
        /// </returns>
        public ReleaseYearModel CreateYear(ReleaseYearModel modelY)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                var p = new DynamicParameters();
                p.Add("@year", modelY.Year);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spReleaseYear_Insert", p, commandType: CommandType.StoredProcedure);

                modelY.ReleaseYearId = p.Get<int>("@id");

                return modelY;
            }// do not forget to return model
        }
        /// <summary>
        /// this is how we put all of the movie titles from the DB into the title dropdown
        /// on the search movie form
        /// </summary>
        /// <returns></returns>
        public List<TitleModel> GetAllTitles()
        {
            List<TitleModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                output = connection.Query<TitleModel>("spTitle_GetAll").ToList();
            }
            return output;
        }
        /// <summary>
        /// this is how we put in all of the release years of the movies into the release year
        /// dropdown from the DB
        /// </summary>
        /// <returns></returns>
        public List<ReleaseYearModel> GetAllYears()
        {
            List<ReleaseYearModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                output = connection.Query<ReleaseYearModel>("spYear_GetAll").ToList();
            }
            return output;
        }
        /// <summary>
        /// populates the Primary director dropdown on the search movie form w/all PD data from the DB
        /// </summary>
        /// <returns></returns>
        public List<PrimaryDirectorModel> GetAllDirectors()
        {
            List<PrimaryDirectorModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                output = connection.Query<PrimaryDirectorModel>("spDirector_GetAll").ToList();
            }
            return output;
        }
        /// <summary>
        /// populates the genre dropdown on the search movie form w/data from DB
        /// </summary>
        /// <returns></returns>
        public List<GenreModel> GetAllGenres()
        {
            List<GenreModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("MovieAppCSC660")))
            {
                output = connection.Query<GenreModel>("spGenre_GetAll").ToList();
            }
            return output;
        }
    }
}
