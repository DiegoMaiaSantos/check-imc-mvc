using Check_IMC.Interfaces;
using Check_IMC.Models;

namespace Check_IMC.Services
{
    public class ImcService : IImcService
    {
        public double CalculatingIMC(ImcModel model)
        {
            if (model.Weight <= 0.0 || model.Height <= 0.0)
                throw new ArgumentException("Peso e altura devem ser maiores que zero.");

            double alturaEmMetros = model.Height > 10 ? model.Height / 100.0 : model.Height;
            double imc = model.Weight / (alturaEmMetros * alturaEmMetros);

            return Math.Round(imc, 2);
        }

        public string ImcResult(double calculationResult)
        {
            try
            {
                if (calculationResult < 18.5) return "Magreza";
                if (calculationResult < 24.9) return "Normal";
                if (calculationResult < 29.9) return "Sobrepeso";

                return "Obesidade";
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar resultado do IMC.");
            }
        }
    }
}
