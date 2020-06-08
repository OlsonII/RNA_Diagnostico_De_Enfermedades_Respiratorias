using Domain;

namespace Application
{
    public class DiagnosticoAmigdalitisService
    {
        public string FileName = "AmigdalitisWeights";
        public DiagnosticoAmigdalitisResponse Ejecute(DiagnosticoAmigdalitisRequest request)
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
                return new DiagnosticoAmigdalitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoAmigdalitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoAmigdalitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoAmigdalitisResponse
    {
        public string Diagnostico { get; set; }
    }
}