using Domain;

namespace Application
{
    public class DiagnosticoSinusitisService
    {
        public string FileName = "SinusitisWeights";
        public DiagnosticoSinusitisResponse Ejecute(DiagnosticoSinusitisRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.UmbralesCapaOculta = weights.UmbralesCapaOculta;
            network.UmbralesSalida[0] = weights.UmbralSalida;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoSinusitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoSinusitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoSinusitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoSinusitisResponse
    {
        public string Diagnostico { get; set; }
    }
}