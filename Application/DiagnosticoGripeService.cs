using Domain;

namespace Application
{
    public class DiagnosticoGripeService
    {
        public string FileName = "GripeWeights";
        public DiagnosticoGripeResponse Ejecute(DiagnosticoGripeRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoGripeResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoGripeResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoGripeRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoGripeResponse
    {
        public string Diagnostico { get; set; }
    }
}