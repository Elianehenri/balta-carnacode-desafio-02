using IMC.Models;

namespace IMC.Services;

public interface IBmiService
{
    void Adicionar(BMIModel model);
    List<BMIModel> Listar();
}