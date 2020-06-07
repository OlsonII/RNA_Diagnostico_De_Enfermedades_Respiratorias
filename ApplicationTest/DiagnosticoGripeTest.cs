using Application;
using NUnit.Framework;

namespace ApplicationTest
{
    public class DiagnosticoGripeTest
    {
        [Test]
        public void NetworkGripe()
        {
            var service = new DiagnosticoGripeService();
            var request = new DiagnosticoGripeRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
    }
}