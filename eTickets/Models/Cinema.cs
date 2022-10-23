using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace eTickets.Models
{
    public class Cinema
    {

        [Key]
        public int Id { get; set; }
        [Display(Name="Cinema Logo")]
        public String Logo { get; set; }
        [Display(Name = "Cinema Name")]

        public string Name { get; set; }
        [Display(Name = "Description")]

        public string Discription { get; set; }

        //Relation between movie  (one to many)
        public List<Movie> Movies{ get; set; }
    }
}
