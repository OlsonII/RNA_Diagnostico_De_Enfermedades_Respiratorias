using Application;
using NUnit.Framework;

namespace ApplicationTest
{
    public class DiagnosticoNetworkTest
    {
        [SetUp]
        public void Setup()
        {}
        
        [Test]
        public void DiagnosticoNetworkGripe()
        {
            var service = new DiagnosticoGripeService();
            var request = new DiagnosticoGripeRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkResfriadoComun()
        {
            var service = new DiagnosticoResfriadoComunService();
            var request = new DiagnosticoResfriadoComunRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkRinitis()
        {
            var service = new DiagnosticoRinitisService();
            var request = new DiagnosticoRinitisRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkRinosinositis()
        {
            var service = new DiagnosticoRinosinositisService();
            var request = new DiagnosticoRinosinositisRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkFaringitis()
        {
            var service = new DiagnosticoFaringitisService();
            var request = new DiagnosticoFaringitisRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkAmigdalitis()
        {
            var service = new DiagnosticoAmigdalitisService();
            var request = new DiagnosticoAmigdalitisRequest(){InputsValues = new double[,]{
                {0, 0, 0, 0, 0, 0, 0, 0, 0}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkBronquitis()
        {
            var service = new DiagnosticoBronquitisService();
            var request = new DiagnosticoBronquitisRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkEnfisemaPulmonar()
        {
            var service = new DiagnosticoEnfisemaPulmonarService();
            var request = new DiagnosticoEnfisemaPulmonarRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkAsma()
        {
            var service = new DiagnosticoAsmaService();
            var request = new DiagnosticoAsmaRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkNeumonia()
        {
            var service = new DiagnosticoNeumoniaService();
            var request = new DiagnosticoNeumoniaRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkCancerDePulmon()
        {
            var service = new DiagnosticoCancerDePulmonService();
            var request = new DiagnosticoCancerDePulmonRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkSinusitis()
        {
            var service = new DiagnosticoSinusitisService();
            var request = new DiagnosticoSinusitisRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkLaringitis()
        {
            var service = new DiagnosticoLaringitisService();
            var request = new DiagnosticoLaringitisRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkEPOC()
        {
            var service = new DiagnosticoEPOCService();
            var request = new DiagnosticoEPOCRequest(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkCovid19()
        {
            var service = new DiagnosticoCovid19Service();
            var request = new DiagnosticoCovid19Request(){InputsValues = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
    }
}