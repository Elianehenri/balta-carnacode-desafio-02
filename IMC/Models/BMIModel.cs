using System.ComponentModel.DataAnnotations;


namespace IMC.Models
{
  
    public class BMIModel
    {
        [Required(ErrorMessage = "A altura é obrigatória.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "A altura é inválida.")]
        public string Altura { get; set; }

        [Required(ErrorMessage = "O peso é obrigatório.")]
        [Range(1.0, double.MaxValue, ErrorMessage = "O peso é inválido.")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "O sexo é obrigatório.")]
        public string Sexo { get; set; }

        public bool Mais65Anos { get; set; }
    }
}