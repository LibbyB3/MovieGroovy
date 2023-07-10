using MovieAppCSC660.Models;
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
        /// this is creating our title for the movie, saving to the database, 
        /// </summary>
        /// <param name="model"></param> and model will be how we can retrieve it from the DB
        /// <returns></returns>
        TitleModel CreateTitle(TitleModel model);
        /// <summary>
        /// this is creating the release year for our movie and saving to the database
        /// </summary>
        /// <param name="modelY"></param>
        /// <returns></returns>
        ReleaseYearModel CreateYear(ReleaseYearModel modelY);
        /// <summary>
        /// this is creating the Primary Director's name and saving it to the database
        /// </summary>
        /// <param name="modelPD"></param>
        /// <returns></returns>
        PrimaryDirectorModel CreatePrimaryDirector(PrimaryDirectorModel modelPD);
        /// <summary>
        /// this is how to create the genre that the movie is in and save to the DB
        /// </summary>
        /// <param name="modelG"></param>
        /// <returns></returns>
        GenreModel CreateGenre(GenreModel modelG);
        /// <summary>
        /// finally, this is creating the synopsis and storing it to the database
        /// </summary>
        /// <param name="modelS"></param>
        /// <returns></returns>
        SynopsisModel CreateSynopsis(SynopsisModel modelS);
        /// <summary>
        /// all of the following lists are used to populate the dropdowns on the search movie form
        /// </summary>
        /// <returns></returns>
        List<TitleModel> GetAllTitles();
        List<ReleaseYearModel> GetAllYears();
        List<PrimaryDirectorModel> GetAllDirectors();
        List<GenreModel> GetAllGenres();

    }
}
