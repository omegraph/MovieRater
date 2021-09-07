﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models.TVShowModels
{
    public class TVShowEdit
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ParentalGuidance { get; set; }

        public string Genre { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

        public string MainCharacters { get; set; }

        public int Seasons { get; set; }
    }
}
