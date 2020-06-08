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

        /*[Test]
        public void TestFoward()
        {
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {1,	1, 1, 1, 0, 1, 0, 0, 0}, 
                {1,	1, 1, 0, 1, 1, 0, 1, 0}, 
                {0, 0, 0, 0, 0, 0, 0, 0, 0}}; 
            var outputs = new double[]{1 ,1, 1, 0};
            Red red = new Red(20, inputs, outputs);
            red.InicializarPesos();
            red.Entrenamiento();
            Assert.Pass();
        }*/
    }
}