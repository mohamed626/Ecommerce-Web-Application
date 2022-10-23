using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is reqiured")]
        public String ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full name is reqiured")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="length must be between 3 and 50")]

        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = " Bio is reqiured")]

        public string Bio { get; set; }


        //Relation between actor and movie  (one to many  )
        public List<Actor_Movie> Actors_Movies { get; set; }


    }
}
