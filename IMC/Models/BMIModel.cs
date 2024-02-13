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

        public DateTime DataCalculo { get; set; }
        public Double ValorCalculado { get; set; }
        public BMISituationEnum Situacao { get; set; }

        public BMISituationEnum GetSituacao()
        {
            if (ValorCalculado < 17.0)
            {
                return BMISituationEnum.MuitoAbaixoDoPeso;
            }
            else if (ValorCalculado >= 17.0 && ValorCalculado < 18.5)
            {
                return BMISituationEnum.AbaixoDoPeso;
            }
            else if (ValorCalculado >= 18.5 && ValorCalculado < 25)
            {
                return BMISituationEnum.PesoNormal;
            }
            else if (ValorCalculado >= 25 && ValorCalculado < 30)
            {
                return BMISituationEnum.AcimaDoPeso;
            }
            else if (ValorCalculado >= 30 && ValorCalculado < 35)
            {
                return BMISituationEnum.ObesidadeI;
            }
            else if (ValorCalculado >= 35 && ValorCalculado < 40)
            {
                return BMISituationEnum.ObesidadeII;
            }
            else
            {
                return BMISituationEnum.ObesidadeIII;
            }
        }
    }
}
