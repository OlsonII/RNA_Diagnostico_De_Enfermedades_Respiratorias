using Domain;

namespace Application
{
    public class DiagnosticoGripeService
    {
        public string FileName = "GripeWeights";
        public DiagnosticoGripeResponse Ejecute(DiagnosticoGripeRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoGripeResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoGripeResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoGripeRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoGripeResponse
    {
        public string Diagnostico { get; set; }
    }
}