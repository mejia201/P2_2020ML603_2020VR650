using System.ComponentModel.DataAnnotations;
namespace P2_2020ML603_2020VR650.Models
{
    public class Genero
    {
        [Key]
        public int id_genero { get; set; }

        public string? nombre { get; set; }

    }
}
