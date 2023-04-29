using System.ComponentModel.DataAnnotations;
namespace P2_2020ML603_2020VR650.Models
{
    public class Casos
    {
        [Key]
        public int id_caso { get; set; }
        public int id_departamento { get; set; }

        public int id_genero { get; set; }
        public int? casos_confirmados { get; set; }
        public int? casos_recuperados { get; set; }
        public int? fallecidos { get; set; }





    }
}
