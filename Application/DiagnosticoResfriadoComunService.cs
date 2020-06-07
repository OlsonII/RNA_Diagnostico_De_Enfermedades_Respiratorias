using Domain;

namespace Application
{
    public class DiagnosticoResfriadoComunService
    {
        public string FileName = "ResfriadoComunWeights";
        public DiagnosticoResfriadoComunResponse Ejecute(DiagnosticoResfriadoComunRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoResfriadoComunResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoResfriadoComunResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoResfriadoComunRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoResfriadoComunResponse
    {
        public string Diagnostico { get; set; }
    }
}