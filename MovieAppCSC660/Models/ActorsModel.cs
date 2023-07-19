using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class ActorsModel
    {
        public int ActorID { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }
}
