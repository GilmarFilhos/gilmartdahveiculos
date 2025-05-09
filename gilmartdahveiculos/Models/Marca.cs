
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gilmartdahveiculos.Models
{

    [Table("Marca")]
    public class Marca
    {
        [Key]
  public int Id { get; set; }

  [Required]
  [StringLength(40)]

  public string Nome { get; set; }
  
  

    }
}