using Domain;

namespace Application
{
    public class DiagnosticoRinosinositisService
    {
        public string FileName = "RinosinositisWeights";
        public DiagnosticoRinosinositisResponse Ejecute(DiagnosticoRinosinositisRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoRinosinositisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoRinosinositisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoRinosinositisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoRinosinositisResponse
    {
        public string Diagnostico { get; set; }
    }
}