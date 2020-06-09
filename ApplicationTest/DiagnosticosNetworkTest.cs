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
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "GripeWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1, 1}}
            ;
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkResfriadoComun()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "ResfriadoComunWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkRinitis()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "RinitisWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkRinosinositis()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "RinosinositisWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkFaringitis()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "FaringitisWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkAmigdalitis()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "AmigdalitisWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkBronquitis()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "BronquitisWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkEnfisemaPulmonar()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "EnfisemaPulmonarWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkAsma()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "AsmaWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkNeumonia()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "NeumoniaWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkCancerDePulmon()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "CancerDePulmonWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkSinusitis()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "SinusitisWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkLaringitis()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "LaringitisWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkEPOC()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "EPOCWeights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
        
        [Test]
        public void DiagnosticoNetworkCovid19()
        {
            var service = new DiagnosticoService();
            var request = new DiagnosticoRequest(){
                NombreDelArchivo = "Covid19Weights",
                InputsValues = new double[]
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            };
            var response = service.Ejecute(request);
            Assert.AreEqual(response.Diagnostico, "Positivo");
        }
    }
}