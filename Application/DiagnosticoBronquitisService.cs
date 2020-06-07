using Domain;

namespace Application
{
    public class DiagnosticoBronquitisService
    {
        public string FileName = "BronquitisWeights";
        public DiagnosticoBronquitisResponse Ejecute(DiagnosticoBronquitisRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoBronquitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoBronquitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoBronquitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoBronquitisResponse
    {
        public string Diagnostico { get; set; }
    }
}