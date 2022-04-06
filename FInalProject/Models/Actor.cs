﻿using System.ComponentModel.DataAnnotations;

namespace FInalProject.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
