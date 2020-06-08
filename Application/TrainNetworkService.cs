using Domain;

namespace Application
{
    public class TrainNetworkService
    {
        public TrainNetworkResponse Ejecute(TrainNetworkRequest request)
        {
            var network = new Red(request.HiddenNodesNumber, request.InputsValues, request.OutputsValues);
            var reader = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){FileName = request.FileName, Inputs = request.InputsValues.GetLength(1)});
            if (reader != null)
            {
                network.PesosEntradaAOculta = reader.InputToHiddenWeights;
                network.PesosOcultaASalida = reader.HiddenToOutputWeights;
                network.UmbralesCapaOculta = reader.UmbralesCapaOculta;
                network.UmbralesSalida[0] = reader.UmbralSalida;
            }
            else
            {
                network.InicializarPesos();
            }
            network.Entrenamiento();
            var saveWeightsService = new WriteWeightsService();
            saveWeightsService.Ejecute(new WriteWeightsRequest()
            {
                HiddenToOutputWeights = network.PesosOcultaASalida,
                InputToHiddenWeights = network.PesosEntradaAOculta,
                UmbralesOculta = network.UmbralesCapaOculta,
                UmbralSalida = network.UmbralesSalida[0],
                FileName = request.FileName
            });
            return new TrainNetworkResponse(){Red = network};
        }
    }

    public class TrainNetworkRequest
    {
        public int HiddenNodesNumber { get; set; }
        public double[,] InputsValues { get; set; }
        public double[] OutputsValues { get; set; }
        public string FileName { get; set; }
    }

    public class TrainNetworkResponse
    {
        public Red Red { get; set; }
    }
}