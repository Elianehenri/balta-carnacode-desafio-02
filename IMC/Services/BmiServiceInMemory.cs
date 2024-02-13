using IMC.Models;

namespace IMC.Services
{
    public class BmiServiceInMemory : IBmiService
    {
        private readonly List<BMIModel> _models = new();

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
