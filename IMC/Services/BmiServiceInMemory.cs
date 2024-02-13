using IMC.Models;

namespace IMC.Services
{
    public class BmiServiceInMemory : IBmiService
    {
        private readonly List<BMIModel> _models = new()
        {
            new BMIModel
            {
                Altura = "186",
                Peso = "86",
                Mais65Anos = false,
                Sexo = "Masculino"
            },
            new BMIModel
            {
                Altura = "160",
                Peso = "55",
                Mais65Anos = false,
                Sexo = "Feminino"
            },
            new BMIModel
            {
                Altura = "170",
                Peso = "80",
                Mais65Anos = false,
                Sexo = "Masculino"
            }
        };

        public void Adicionar(BMIModel model)
        {
            _models.Add(model);
        }

		public List<BMIModel> Listar()
        {
            return _models;
        }
	}
}
