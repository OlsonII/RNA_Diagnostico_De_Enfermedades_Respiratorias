using Domain;

namespace Application
{
    public class DiagnosticoEnfisemaPulmonarService
    {
        public string FileName = "EnfisemaPulmonarWeights";
        public DiagnosticoEnfisemaPulmonarResponse Ejecute(DiagnosticoEnfisemaPulmonarRequest request)
        {
            var network = new Network(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Inputs, FileName = FileName});
            network.InputsToHiddenWeights = weights.InputToHiddenWeights;
            network.HiddenToOutputsWeights = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.roundedOutput == 1)
            {
                return new DiagnosticoEnfisemaPulmonarResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoEnfisemaPulmonarResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoEnfisemaPulmonarRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoEnfisemaPulmonarResponse
    {
        public string Diagnostico { get; set; }
    }
}