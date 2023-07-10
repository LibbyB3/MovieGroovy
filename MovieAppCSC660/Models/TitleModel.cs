using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppCSC660.Models
{
    /// <summary>
    /// as in the other models, I must change the internal class to a public class first
    /// </summary>
    public class TitleModel
    {
        /// <summary>
        /// this is the title of the movie, important to distinguish movies from each other
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// this is the id of each movie, important because multiple movies could have the same title
        /// </summary>
        public int MovieId { get; set; }
        public string createdTitle
        {
            get { return Title; } //putting this into the dropdown on search movie
        }
        public TitleModel()
        {

        }
        // TODO - totally unsure what to do here, why is this needed?
        public TitleModel(string titleTextBox) //this is a constructor that draws from the 
        {                                      //create movie form
            Title = titleTextBox;
                
        }
    }
}
