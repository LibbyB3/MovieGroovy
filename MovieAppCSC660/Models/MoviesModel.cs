﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class MoviesModel
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Duration { get; set; }
        public int GenreID { get; set; }
        public int DirectorID { get; set; }
        public MoviesModel(string titleTextBox, DateTime dateTextBox, int durationTextBox)
        {
            Title = titleTextBox;
            ReleaseDate = dateTextBox;
            Duration = durationTextBox;
        }
    }
}
