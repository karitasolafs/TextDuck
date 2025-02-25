﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TextDuck.UF;


// Entity class for srtFiles
namespace TextDuck.Models
{
    public class srtFiles
    {
        public int? Id { get; set; }
         [Display(Name = "Nafn ")]
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name = "Ástand")]
        public string Status { get; set; }

        public DateTime Date { get; set; }
        [Display(Name = "Flokkur")]
        public string Category { get; set; }
        [Display(Name = "Tegund")]
        public string Genre { get; set; }
        [Display(Name = "Tungumál")]
        public string Language { get; set; }
        public int Votes { get; set; }

    }
}