using Domain;

namespace Application
{
    public class DiagnosticoSinusitisService
    {
        public string FileName = "SinusitisWeights";
        public DiagnosticoSinusitisResponse Ejecute(DiagnosticoSinusitisRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoSinusitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoSinusitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoSinusitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoSinusitisResponse
    {
        public string Diagnostico { get; set; }
    }
}