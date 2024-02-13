using System.ComponentModel.DataAnnotations;

namespace IMC.Models;

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
	public double? ImcCalculado { get; set; }
	public BMISituationEnum Situacao { get; set; }

	public void CalcularImc()
	{
		if (!double.TryParse(Altura, out var altura) || !double.TryParse(Peso, out var peso)) return;

		var alturaMetros = altura / 100.0;
		var imc = peso / (alturaMetros * alturaMetros);

		// Preenche as propriedades do modelo
		ImcCalculado = imc;
		DataCalculo = DateTime.UtcNow;
		Situacao = GetSituacao();
	}

	private BMISituationEnum GetSituacao()
	{
		if (ImcCalculado < 17.0)
		{
			return BMISituationEnum.MuitoAbaixoDoPeso;
		}

		if (ImcCalculado >= 17.0 && ImcCalculado < 18.5)
		{
			return BMISituationEnum.AbaixoDoPeso;
		}
		if (ImcCalculado >= 18.5 && ImcCalculado < 25)
		{
			return BMISituationEnum.PesoNormal;
		}
		if (ImcCalculado >= 25 && ImcCalculado < 30)
		{
			return BMISituationEnum.AcimaDoPeso;
		}
		if (ImcCalculado >= 30 && ImcCalculado < 35)
		{
			return BMISituationEnum.ObesidadeI;
		}
		if (ImcCalculado >= 35 && ImcCalculado < 40)
		{
			return BMISituationEnum.ObesidadeII;
		}
		return BMISituationEnum.ObesidadeIII;
	}
}