using Domain;

namespace Application
{
    public class DiagnosticoAsmaService
    {
        public string FileName = "AsmaWeights";
        public DiagnosticoAsmaResponse Ejecute(DiagnosticoAsmaRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoAsmaResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoAsmaResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoAsmaRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoAsmaResponse
    {
        public string Diagnostico { get; set; }
    }
}