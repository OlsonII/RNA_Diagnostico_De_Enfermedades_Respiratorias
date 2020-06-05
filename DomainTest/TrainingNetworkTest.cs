using Domain;
using NUnit.Framework;

namespace DomainTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFoward()
        {
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {1,	1, 1, 1, 0, 1, 0, 0, 0}, 
                {1,	1, 1, 0, 1, 1, 0, 1, 0}, 
                {0, 0, 0, 0, 0, 0, 0, 0, 0}}; 
            var outputs = new double[]{1 ,1, 1, 0};
            Network network = new Network(20, inputs, outputs);
            network.InitWeights();
            network.Training();
            Assert.Pass();
        }
    }
}