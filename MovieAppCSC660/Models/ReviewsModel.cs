using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class ReviewsModel
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int MovieID { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
