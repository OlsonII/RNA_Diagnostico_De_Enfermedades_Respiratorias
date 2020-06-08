using Domain;

namespace Application
{
    public class DiagnosticoAsmaService
    {
        public string FileName = "AsmaWeights";
        public DiagnosticoAsmaResponse Ejecute(DiagnosticoAsmaRequest request)
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
                return new DiagnosticoAsmaResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoAsmaResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoAsmaRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoAsmaResponse
    {
        public string Diagnostico { get; set; }
    }
}