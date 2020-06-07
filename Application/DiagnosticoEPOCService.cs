using Domain;

namespace Application
{
    public class DiagnosticoEPOCService
    {
        public string FileName = "EPOCWeights";
        public DiagnosticoEPOCResponse Ejecute(DiagnosticoEPOCRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoEPOCResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoEPOCResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoEPOCRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoEPOCResponse
    {
        public string Diagnostico { get; set; }
    }
}