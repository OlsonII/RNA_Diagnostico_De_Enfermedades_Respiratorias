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
            var otherService = new WriteWeightsService();
            otherService.Ejecute(new WriteWeightsRequest()
            {
                HiddenToOutputWeights = network.HiddenToOutputsWeights,
                InputToHiddenWeights = network.InputsToHiddenWeights
            });
            return new TrainNetworkResponse(){Network = network};
        }
    }

    public class TrainNetworkRequest
    {
        public int HiddenNodesNumber { get; set; }
        public double[,] InputsValues { get; set; }
        public double[] OutputsValues { get; set; }
    }

    public class TrainNetworkResponse
    {
        public Network Network { get; set; }
    }
}