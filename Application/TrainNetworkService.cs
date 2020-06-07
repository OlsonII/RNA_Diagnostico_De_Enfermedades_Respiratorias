using Domain;

namespace Application
{
    public class TrainNetworkService
    {
        public TrainNetworkResponse Ejecute(TrainNetworkRequest request)
        {
            var network = new Network(request.HiddenNodesNumber, request.InputsValues, request.OutputsValues);
            network.InitWeights();
            network.Training();
            var saveWeightsService = new WriteWeightsService();
            saveWeightsService.Ejecute(new WriteWeightsRequest()
            {
                HiddenToOutputWeights = network.HiddenToOutputsWeights,
                InputToHiddenWeights = network.InputsToHiddenWeights,
                FileName = request.FileName
            });
            return new TrainNetworkResponse(){Network = network};
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
        public Network Network { get; set; }
    }
}