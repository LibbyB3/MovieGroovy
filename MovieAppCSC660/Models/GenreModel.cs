using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppCSC660.Models
{
    /// <summary>
    /// the internal class must be changed to a public class
    /// </summary>
    public class GenreModel
    {
        /// <summary>
        /// the id associated with each movie's genre, important because multiple movies could be listed
        /// under the same genre
        /// </summary>
        public int GenreId { get; set; }
        /// <summary>
        /// the name of each genre associated with a movie
        /// </summary>
        public string Genre { get; set; }
        public GenreModel()
        {

        }

        public GenreModel(string genreTextBox)
        {
            Genre = genreTextBox;
        }
    }
}
