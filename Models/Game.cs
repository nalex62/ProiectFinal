using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Game
    {
        public int ID { get; set; }
        [Display(Name = "Game Name")]

        public string GameName { get; set; }
        public string Company { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
    }
}
