using Domain;

namespace Application
{
    public class DiagnosticoFaringitisService
    {
        public string FileName = "FaringitisWeights";
        public DiagnosticoFaringitisResponse Ejecute(DiagnosticoFaringitisRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoFaringitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoFaringitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoFaringitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoFaringitisResponse
    {
        public string Diagnostico { get; set; }
    }
}