using System.ComponentModel.DataAnnotations;

namespace FInalProject.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        //Relationships
        public List<Movie> Movies { get; set; } 
    }
}

