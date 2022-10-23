using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace eTickets.Models
{
    public class Producer
    {

        [Key]
        public int Id { get; set; }
        
        [Display(Name ="Profile Picture")]
        public String ProfilePictureURL { get; set; }
        
        [Display(Name ="FullName")]
        public string FullName { get; set; }
       
        [Display(Name ="Biography")]
        public string Bio { get; set; }

        //Relation between movie  (one to many)
        public List<Movie> Movies { get; set; }

    }
}
