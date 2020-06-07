using Domain;

namespace Application
{
    public class DiagnosticoAmigdalitisService
    {
        public string FileName = "AmigdalitisWeights";
        public DiagnosticoAmigdalitisResponse Ejecute(DiagnosticoAmigdalitisRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoAmigdalitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoAmigdalitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoAmigdalitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoAmigdalitisResponse
    {
        public string Diagnostico { get; set; }
    }
}