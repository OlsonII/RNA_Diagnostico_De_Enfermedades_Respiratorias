using Application;
using NUnit.Framework;

namespace ApplicationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TrainingNetworkTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {1,	1, 1, 1, 0, 1, 0, 0, 0}, 
                {1,	1, 1, 0, 1, 1, 0, 1, 0}, 
                {0, 0, 0, 0, 0, 0, 0, 0, 0}}; 
            var outputs = new double[]{1 ,1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs});
            Assert.Pass();
        }
    }
}