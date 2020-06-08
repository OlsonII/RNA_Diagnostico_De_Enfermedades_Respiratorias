using Domain;

namespace Application
{
    public class DiagnosticoCancerDePulmonService
    {
        public string FileName = "CancerDePulmonWeights";
        public DiagnosticoCancerDePulmonResponse Ejecute(DiagnosticoCancerDePulmonRequest request)
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
                return new DiagnosticoCancerDePulmonResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoCancerDePulmonResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoCancerDePulmonRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoCancerDePulmonResponse
    {
        public string Diagnostico { get; set; }
    }
}