using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppCSC660.Models
{
    /// <summary>
    /// firstly, I change the internal class to public class
    /// </summary>
    public class ReleaseYearModel
    {
        /// <summary>
        /// the id associated with each release year; important because different movies could have the 
        /// same release year
        /// </summary>
        public int ReleaseYearId { get; set; }
        /// <summary>
        /// the release year for each movie
        /// </summary>
        public int Year { get; set; }
        public ReleaseYearModel()
        {

        }
        public ReleaseYearModel(string yearTextBox) 
        {
            int.TryParse(yearTextBox, out int year);
            Year = year;
        }
    }
}
