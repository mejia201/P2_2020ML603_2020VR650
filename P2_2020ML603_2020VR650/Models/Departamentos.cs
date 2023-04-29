using System.ComponentModel.DataAnnotations;
namespace P2_2020ML603_2020VR650.Models
{
    public class Departamentos
    {
        [Key]
        public int id_departamento { get; set; }

        public string? nombre_departamento { get; set; }

    }
}
