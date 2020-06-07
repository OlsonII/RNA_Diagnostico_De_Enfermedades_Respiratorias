using Domain;

namespace Application
{
    public class DiagnosticoLaringitisService
    {
        public string FileName = "LaringitisWeights";
        public DiagnosticoLaringitisResponse Ejecute(DiagnosticoLaringitisRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoLaringitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoLaringitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoLaringitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoLaringitisResponse
    {
        public string Diagnostico { get; set; }
    }
}