using Domain;

namespace Application
{
    public class DiagnosticoRinitisService
    {
        public string FileName = "RinitisWeights";
        public DiagnosticoRinitisResponse Ejecute(DiagnosticoRinitisRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoRinitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoRinitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoRinitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoRinitisResponse
    {
        public string Diagnostico { get; set; }
    }
}