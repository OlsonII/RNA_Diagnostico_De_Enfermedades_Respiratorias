using Domain;

namespace Application
{
    public class DiagnosticoLaringitisService
    {
        public string FileName = "LaringitisWeights";
        public DiagnosticoLaringitisResponse Ejecute(DiagnosticoLaringitisRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoLaringitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoLaringitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoLaringitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoLaringitisResponse
    {
        public string Diagnostico { get; set; }
    }
}