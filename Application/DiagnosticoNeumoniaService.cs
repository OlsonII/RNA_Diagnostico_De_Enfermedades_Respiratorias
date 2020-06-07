using Domain;

namespace Application
{
    public class DiagnosticoNeumoniaService
    {
        public string FileName = "NeumoniaWeights";
        public DiagnosticoNeumoniaResponse Ejecute(DiagnosticoNeumoniaRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoNeumoniaResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoNeumoniaResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoNeumoniaRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoNeumoniaResponse
    {
        public string Diagnostico { get; set; }
    }
}