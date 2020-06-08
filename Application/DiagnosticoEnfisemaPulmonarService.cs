using Domain;

namespace Application
{
    public class DiagnosticoEnfisemaPulmonarService
    {
        public string FileName = "EnfisemaPulmonarWeights";
        public DiagnosticoEnfisemaPulmonarResponse Ejecute(DiagnosticoEnfisemaPulmonarRequest request)
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
                return new DiagnosticoEnfisemaPulmonarResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoEnfisemaPulmonarResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoEnfisemaPulmonarRequest
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoEnfisemaPulmonarResponse
    {
        public string Diagnostico { get; set; }
    }
}