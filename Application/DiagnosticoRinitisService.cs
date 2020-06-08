using Domain;

namespace Application
{
    public class DiagnosticoRinitisService
    {
        public string FileName = "RinitisWeights";
        public DiagnosticoRinitisResponse Ejecute(DiagnosticoRinitisRequest request)
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
                return new DiagnosticoRinitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoRinitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoRinitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoRinitisResponse
    {
        public string Diagnostico { get; set; }
    }
}