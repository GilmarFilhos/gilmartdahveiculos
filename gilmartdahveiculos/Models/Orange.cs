using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gilmartdahveiculos.Models
{
    [Table("Orange")]
    public class Orange
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        public string data  { get; set;}
    }
}
