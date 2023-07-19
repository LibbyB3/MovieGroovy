using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class DirectorsModel
    {
        public int DirectorID { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
