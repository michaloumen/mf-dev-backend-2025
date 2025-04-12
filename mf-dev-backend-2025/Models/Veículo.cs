using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Veículos")]
    public class Veículo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação!")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo!")]
        public int AnoModelo { get; set; }
    }
}
