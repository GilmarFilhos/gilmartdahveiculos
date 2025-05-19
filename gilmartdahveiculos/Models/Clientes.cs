using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gilmartdahveiculos.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

    }
}
