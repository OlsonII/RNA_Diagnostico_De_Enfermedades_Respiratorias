using Domain;

namespace Application
{
    public class DiagnosticoCancerDePulmonService
    {
        public string FileName = "CancerDePulmonWeights";
        public DiagnosticoCancerDePulmonResponse Ejecute(DiagnosticoCancerDePulmonRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoCancerDePulmonResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoCancerDePulmonResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoCancerDePulmonRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoCancerDePulmonResponse
    {
        public string Diagnostico { get; set; }
    }
}