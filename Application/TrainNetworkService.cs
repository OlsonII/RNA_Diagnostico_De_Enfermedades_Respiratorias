using Domain;

namespace Application
{
    public class TrainNetworkService
    {
        public TrainNetworkResponse Ejecute(TrainNetworkRequest request)
        {
            var red = new Red(request.InputsValues, request.OutputsValues);
            var reader = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){FileName = request.FileName, Inputs = request.InputsValues[0].Length});
            if (reader != null)
            {
                for (var i = 0; i < red.NeuronasOcultas.Length; i++)
                {
                    for (var pesos = 0; pesos < red.NeuronasOcultas[i].Pesos.Length; pesos++)
                    {
                        red.NeuronasOcultas[i].Pesos[pesos] = reader.PesosCapaOculta[i, pesos];
                    }
                    red.NeuronasOcultas[i].Umbral = reader.UmbralesCapaOculta[i];
                }
                
                red.NeuronaDeSalida.Pesos = reader.PesosSalida;
                red.NeuronaDeSalida.Umbral = reader.UmbralSalida;
                red.EstaEntrenada = true;
            }
            else
            {
                red.EstaEntrenada = false;
            }
            red.Entrenar();
            var saveWeightsService = new WriteWeightsService();
            saveWeightsService.Ejecute(new WriteWeightsRequest()
            {
                CapaOculta = red.NeuronasOcultas,
                NeuronaSalida = red.NeuronaDeSalida,
                UmbralSalida = red.NeuronaDeSalida.Umbral,
                FileName = request.FileName
            });
            return new TrainNetworkResponse(){Red = red};
        }
    }

    public class TrainNetworkRequest
    {
        public double[][] InputsValues { get; set; }
        public double[] OutputsValues { get; set; }
        public string FileName { get; set; }
    }

    public class TrainNetworkResponse
    {
        public Red Red { get; set; }
    }
}