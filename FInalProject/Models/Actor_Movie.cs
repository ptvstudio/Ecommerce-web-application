using System.ComponentModel.DataAnnotations;

namespace FInalProject.Models
{
    public class Actor_Movie
    {
        [Key]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorID { get; set; }
        public Actor Actor { get; set; }
    }
}
 