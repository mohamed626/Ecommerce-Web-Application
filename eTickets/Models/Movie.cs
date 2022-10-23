using System.ComponentModel.DataAnnotations;
using System;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace eTickets.Models
{
    public class Movie
    {

        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public string Discription { get; set; }
        public double Price  { get; set; }
        public string ImagrURL{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory Category { get; set; }



        //Relation between movie and actor  (one to many  )
        public List<Actor_Movie>  Actors_Movies { get; set; }

        //Relation between movie and Cinema  (one to one )
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Relation between movie and producer  (one to one )
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }



    }

}
