using Domain;

namespace Application
{
    public class DiagnosticoBronquitisService
    {
        public string FileName = "BronquitisWeights";
        public DiagnosticoBronquitisResponse Ejecute(DiagnosticoBronquitisRequest request)
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
                return new DiagnosticoBronquitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoBronquitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoBronquitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoBronquitisResponse
    {
        public string Diagnostico { get; set; }
    }
}