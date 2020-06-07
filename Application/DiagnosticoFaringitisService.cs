using Domain;

namespace Application
{
    public class DiagnosticoFaringitisService
    {
        public string FileName = "FaringitisWeights";
        public DiagnosticoFaringitisResponse Ejecute(DiagnosticoFaringitisRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoFaringitisResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoFaringitisResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoFaringitisRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoFaringitisResponse
    {
        public string Diagnostico { get; set; }
    }
}