using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MyToDoList.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }

        public string Banner { get; set; }
    }
}
