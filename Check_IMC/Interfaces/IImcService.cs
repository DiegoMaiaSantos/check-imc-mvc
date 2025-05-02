using Check_IMC.Models;

namespace Check_IMC.Interfaces
{
    public interface IImcService
    {
        double CalculatingIMC(ImcModel model);
        string ImcResult(double calculationResult);
    }
}
