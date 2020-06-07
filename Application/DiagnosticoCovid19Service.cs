using Domain;

namespace Application
{
    public class DiagnosticoCovid19Service
    {
        public string FileName = "Covid19Weights";
        public DiagnosticoCovid19Response Ejecute(DiagnosticoCovid19Request request)
        {
            var network = new Red(20, request.InputsValues);
            var weights = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = network.Entradas, FileName = FileName});
            network.PesosEntradaAOculta = weights.InputToHiddenWeights;
            network.PesosOcultaASalida = weights.HiddenToOutputWeights;
            network.FowardPass(0);
            if (network.SalidaRedondeada == 1)
            {
                return new DiagnosticoCovid19Response(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoCovid19Response(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoCovid19Request
    {
        public double[,] InputsValues { get; set; }
    }

    public class DiagnosticoCovid19Response
    {
        public string Diagnostico { get; set; }
    }
}