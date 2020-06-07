using Domain;

namespace Application
{
    public class DiagnosticoRinosinositisService
    {
        public string FileName = "RinosinositisWeights";
        public DiagnosticoRinosinositisResponse Ejecute(DiagnosticoRinosinositisRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoRinosinositisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoRinosinositisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoRinosinositisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoRinosinositisResponse
    {
        public string Diagnostico { get; set; }
    }
}