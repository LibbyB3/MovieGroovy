using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppCSC660.Models
{
    /// <summary>
    /// change the internal class to public
    /// </summary>
    public class SynopsisModel
    {
        /// <summary>
        /// the id for each synopsis entered
        /// </summary>
        public int SynopsisId { get; set; }
        /// <summary>
        /// the typed discription of a movie entry
        /// </summary>
        public string Description { get; set; }

        public SynopsisModel(string synopsisTextBox)
        {
            Description = synopsisTextBox;
        }
    }
}
