using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppCSC660.Models
{
    /// <summary>
    /// the first thing I need to do is change my class from internal to public 
    /// </summary>
    public class PrimaryDirectorModel
    {
        /// <summary>
        /// this is the id of each director, important because the same director could direct more than one movie
        /// </summary>
        public int DirectorId { get; set; }
        /// <summary>
        /// the first name of each primary director, important because different people could have the 
        /// same last name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// the last name of each primary director, important because different people could have the 
        /// same first name
        /// </summary>
        public string LastName { get; set; }

        public string createdDirector { get { return FirstName + " " + LastName; } }
        public PrimaryDirectorModel()
        {

        }

        public PrimaryDirectorModel(string primDirectTextBox)
        {
            FirstName = primDirectTextBox.Split()[0];
            LastName = primDirectTextBox.Split()[1]; //what if they don't put a last name?
        } //the split allows the first input = FirstName and the second input = LastName
    }
}
