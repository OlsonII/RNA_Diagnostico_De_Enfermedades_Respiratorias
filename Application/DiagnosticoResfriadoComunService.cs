using Domain;

namespace Application
{
    public class DiagnosticoResfriadoComunService
    {
        public string FileName = "ResfriadoComunWeights";
        public DiagnosticoResfriadoComunResponse Ejecute(DiagnosticoResfriadoComunRequest request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoResfriadoComunResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoResfriadoComunResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoResfriadoComunRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoResfriadoComunResponse
    {
        public string Diagnostico { get; set; }
    }
}