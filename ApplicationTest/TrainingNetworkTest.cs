using System;
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
        public void TrainingNetworkGripeTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {1,	1, 1, 1, 0, 1, 0, 0, 0}, 
                {1,	1, 1, 0, 1, 1, 0, 1, 0}, 
                {0, 0, 0, 0, 0, 0, 0, 0, 0}}; 
            var outputs = new double[]{1 ,1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "GripeWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkResfriadoComunTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1}, 
                {0,	1, 0, 1, 0, 1, 1}, 
                {1,	0, 1, 0, 1, 0, 1}, 
                {1, 1, 1, 1, 1, 0, 1},
                {1, 1, 1, 1, 1, 1, 0},
                {0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "ResfriadoComunWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkRinitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 0}, 
                {1, 0, 1, 1, 1}, 
                {1, 1, 1, 0, 0},
                {1, 1, 1, 0, 1},
                {0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "RinitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkRinosinitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 1, 1, 0}, 
                {1, 1, 1, 1, 1, 0, 0}, 
                {1, 1, 1, 1, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "RinosinositisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkFaringitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 1, 1, 1, 0}, 
                {1, 1, 1, 1, 1, 1, 0, 0}, 
                {1, 1, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 1, 1, 1, 1, 1},
                {1, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "FaringitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkAmigdalitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {0, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {0, 0, 1, 1, 1, 1, 1, 1, 1}, 
                {0, 0, 0, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 1}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "AmigdalitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkBronquitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1}, 
                {0, 1, 1, 1, 1, 1, 1}, 
                {0, 0, 1, 1, 1, 1, 1}, 
                {1, 0, 0, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "BronquitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkEnfisemaPulmonarTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 1, 0}, 
                {1, 1, 1, 1, 0, 0}, 
                {1, 0, 1, 1, 0, 1},
                {0, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "EnfisemaPulmonarWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkAsmaTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 0}, 
                {1, 0, 1, 0, 1},
                {0, 1, 1, 1, 1},
                {0, 0, 1, 1, 1},
                {0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "AsmaWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkNeumoniaTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 1, 0, 1, 1}, 
                {1, 1, 1, 1, 1, 1, 0, 1}, 
                {1, 1, 1, 0, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "NeumoniaWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkCancerDePulmonTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1}, 
                {1, 0, 1, 1, 0, 1, 1, 1}, 
                {1, 0, 0, 1, 1, 1, 1, 1}, 
                {1, 0, 1, 1, 1, 1, 0, 1},
                {1, 0, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 1}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "CancerDePulmonWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkSinusitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 1, 1, 1, 1, 0}, 
                {1, 1, 1, 1, 1, 1, 1, 0, 0},
                {1, 1, 1, 1, 1, 1, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "SinusitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkLaringitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1}, 
                {1, 0, 1, 1, 0, 1, 1, 1}, 
                {1, 0, 0, 1, 1, 1, 1, 1}, 
                {1, 0, 1, 1, 0, 1, 1, 1},
                {1, 0, 1, 1, 1, 1, 0, 1},
                {1, 0, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "LaringitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkEPOCTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 0}, 
                {1, 1, 1, 1, 1, 1, 1, 1, 0, 0}, 
                {1, 1, 0, 1, 1, 1, 1, 0, 0, 1},
                {1, 1, 1, 1, 1, 0, 0, 0, 1, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "EPOCWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkCovid19Test()
        {
            var service = new TrainNetworkService();
            var inputs = new double[,]{
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0}, 
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0}, 
                {1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
                {1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
                {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }; 
            var outputs = new double[]{1 ,1, 1, 1, 1, 1, 1, 0};
            service.Ejecute(new TrainNetworkRequest(){HiddenNodesNumber = 20, InputsValues = inputs, OutputsValues = outputs, FileName = "Covid19Weights"});
            Assert.Pass();
        }

        /*[Test]
        public void ReadWeighstGripeTest()
        {
            var service = new ReadWeightsService();
            var response = service.Ejecute(new ReadWeightsRequest() { Inputs = 9, FileName = "PesosEnfermedad01"});
            Console.WriteLine("Pesos entrada - oculta");
            foreach (var responseInputToHiddenWeight in response.InputToHiddenWeights)
            {
                Console.WriteLine(responseInputToHiddenWeight);
            }
            Console.WriteLine("Pesos oculta - salida");
            foreach (var responseHiddenToOutputWeight in response.HiddenToOutputWeights)
            {
                Console.WriteLine(responseHiddenToOutputWeight);
            }
        }*/
    }
}