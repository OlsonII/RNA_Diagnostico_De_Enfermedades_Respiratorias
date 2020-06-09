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
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 0, 1, 0, 0, 0};
            inputs[2] = new double[] {1, 1, 1, 0, 1, 1, 0, 1, 0};
            inputs[3] = new double[] {0, 0, 0, 1, 0, 0, 0, 0, 1};
            inputs[4] = new double[] {1, 0, 0, 0, 0, 0, 1, 0, 0};
            inputs[5] = new double[] {1, 0, 1, 0, 0, 0, 0, 0, 0};
            inputs[6] = new double[] {0, 1, 0, 0, 0, 0, 1, 0, 0};
            inputs[7] = new double[] {0, 0, 0, 0, 1, 0, 0, 0, 0};
            inputs[8] = new double[] {0, 0, 1, 0, 0, 0, 0, 0, 0};
            inputs[9] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0};
            inputs[10] = new double[] {1, 0, 0, 0, 0, 0, 0, 0, 0};
            inputs[11] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0};
            inputs[12] = new double[] {1, 0, 0, 0, 0, 0, 0, 0, 0};
            inputs[13] = new double[] {0, 0, 1, 1, 0, 0, 0, 0, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 1, 1, 1, 1};
            var outputs = new double[]{1 ,1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "GripeWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkResfriadoComunTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {0, 1, 0, 1, 0, 1, 1};
            inputs[2] = new double[] {1, 0, 1, 0, 1, 0, 1};
            inputs[3] = new double[] {1, 1, 1, 1, 1, 0, 1};
            inputs[4] = new double[] {1, 1, 1, 1, 1, 1, 0};
            inputs[5] = new double[] {0, 0, 0, 1, 1, 1, 1};
            inputs[6] = new double[] {0, 0, 0, 0, 0, 0, 1};
            inputs[7] = new double[] {0, 0, 0, 0, 0, 1, 0};
            inputs[8] = new double[] {0, 0, 0, 0, 1, 0, 0};
            inputs[9] = new double[] {1, 0, 1, 0, 0, 0, 1};
            inputs[10] = new double[] {0, 0, 0, 1, 0, 0, 0};
            inputs[11] = new double[] {0, 0, 0, 0, 0, 1, 0};
            inputs[12] = new double[] {0, 0, 0, 1, 0, 0, 0};
            inputs[13] = new double[] {1, 0, 0, 0, 0, 0, 1};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "ResfriadoComunWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkRinitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 0, 1, 1, 1};
            inputs[3] = new double[] {1, 1, 1, 0, 0};
            inputs[4] = new double[] {1, 1, 1, 0, 1};
            inputs[5] = new double[] {1, 1, 0, 0, 0};
            inputs[6] = new double[] {0, 1, 0, 0, 0};
            inputs[7] = new double[] {1, 0, 0, 0, 0};
            inputs[8] = new double[] {0, 0, 1, 0, 0};
            inputs[9] = new double[] {0, 0, 0, 1, 0};
            inputs[10] = new double[] {0, 0, 0, 0, 1};
            inputs[11] = new double[] {1, 0, 1, 0, 0};
            inputs[12] = new double[] {0, 1, 0, 1, 0};
            inputs[13] = new double[] {0, 0, 0, 1, 1};
            inputs[14] = new double[] {0, 0, 0, 0, 0};
            
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "RinitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkRinosinusitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 1, 1, 1, 1, 0, 0};
            inputs[3] = new double[] {1, 1, 1, 1, 0, 0, 0};
            inputs[4] = new double[] {0, 1, 1, 1, 1, 1, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 0, 0, 1};
            inputs[6] = new double[] {1, 0, 0, 0, 0, 0, 0};
            inputs[7] = new double[] {0, 1, 0, 0, 0, 0, 0};
            inputs[8] = new double[] {0, 0, 1, 0, 0, 1, 0};
            inputs[9] = new double[] {0, 0, 0, 1, 0, 0, 0};
            inputs[10] = new double[] {0, 1, 0, 0, 0, 0, 0};
            inputs[11] = new double[] {0, 0, 0, 0, 1, 0, 0};
            inputs[12] = new double[] {0, 0, 0, 1, 0, 0, 1};
            inputs[13] = new double[] {0, 0, 0, 0, 0, 1, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0};
            
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "RinosinositisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkFaringitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 1, 1, 1, 1, 1, 0, 0};
            inputs[3] = new double[] {1, 1, 1, 1, 1, 0, 0, 0};
            inputs[4] = new double[] {0, 0, 0, 1, 1, 1, 1, 1};
            inputs[5] = new double[] {1, 1, 1, 0, 0, 0, 0, 0};
            inputs[6] = new double[] {0, 0, 0, 0, 0, 0, 0, 1};
            inputs[7] = new double[] {1, 0, 0, 0, 0, 0, 0, 0};
            inputs[8] = new double[] {1, 1, 0, 0, 0, 0, 0, 0};
            inputs[9] = new double[] {0, 0, 1, 0, 0, 1, 0, 0};
            inputs[10] = new double[] {0, 0, 0, 0, 0, 1, 0, 0};
            inputs[11] = new double[] {0, 1, 0, 0, 0, 0, 0, 0};
            inputs[10] = new double[] {0, 0, 0, 1, 0, 1, 0, 0};
            inputs[12] = new double[] {0, 0, 0, 0, 0, 0, 0, 0};
            inputs[13] = new double[] {1, 0, 0, 0, 0, 0, 0, 1};
            inputs[14] = new double[] {1, 0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "FaringitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkAmigdalitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {0, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[2] = new double[] {0, 0, 1, 1, 1, 1, 1, 1, 1};
            inputs[3] = new double[] {0, 0, 0, 1, 1, 1, 1, 1, 1};
            inputs[4] = new double[] {0, 0, 0, 0, 1, 1, 1, 1, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 1};
            inputs[6] = new double[] {0, 0, 0, 0, 0, 1, 0, 0, 0};
            inputs[7] = new double[] {0, 0, 0, 0, 1, 0, 0, 0, 0};
            inputs[8] = new double[] {0, 0, 0, 1, 0, 0, 0, 0, 0};
            inputs[9] = new double[] {1, 0, 0, 1, 0, 0, 0, 0, 0};
            inputs[10] = new double[] {1, 1, 0, 0, 1, 0, 0, 0, 0};
            inputs[11] = new double[] {1, 1, 1, 0, 0, 0, 1, 0, 0};
            inputs[12] = new double[] {0, 1, 1, 1, 0, 0, 0, 0, 1};
            inputs[13] = new double[] {0, 0, 0, 0, 0, 1, 0, 0, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "AmigdalitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkBronquitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {0, 1, 1, 1, 1, 1, 1};
            inputs[2] = new double[] {0, 0, 1, 1, 1, 1, 1};
            inputs[3] = new double[] {1, 0, 0, 1, 1, 1, 1};
            inputs[4] = new double[] {0, 0, 0, 0, 0, 0, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 0, 1, 0};
            inputs[6] = new double[] {0, 0, 0, 0, 1, 0, 0};
            inputs[7] = new double[] {0, 0, 1, 0, 0, 1, 0};
            inputs[8] = new double[] {0, 0, 0, 0, 0, 0, 1};
            inputs[9] = new double[] {0, 1, 0, 1, 0, 0, 0};
            inputs[10] = new double[] {0, 0, 1, 0, 0, 0, 0};
            inputs[11] = new double[] {0, 0, 0, 1, 1, 0, 0};
            inputs[12] = new double[] {0, 1, 0, 0, 0, 1, 0};
            inputs[13] = new double[] {0, 0, 1, 1, 1, 0, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "BronquitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkEnfisemaPulmonarTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 1, 1, 1, 0, 0};
            inputs[3] = new double[] {1, 0, 1, 1, 0, 1};
            inputs[4] = new double[] {0, 1, 1, 1, 1, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 0, 1};
            inputs[6] = new double[] {0, 1, 0, 0, 0, 0};
            inputs[7] = new double[] {0, 0, 0, 0, 0, 0};
            inputs[8] = new double[] {0, 0, 0, 1, 0, 0};
            inputs[9] = new double[] {0, 1, 0, 0, 0, 0};
            inputs[10] = new double[] {0, 0, 0, 1, 0, 0};
            inputs[11] = new double[] {0, 0, 0, 0, 1, 0};
            inputs[12] = new double[] {0, 0, 0, 0, 0, 1};
            inputs[13] = new double[] {1, 0, 1, 1, 0, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "EnfisemaPulmonarWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkAsmaTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1}; 
            inputs[1] = new double[]{1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 0, 1, 0, 1};
            inputs[3] = new double[] {0, 1, 1, 1, 1};
            inputs[4] = new double[] {0, 0, 1, 1, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 1};
            inputs[6] = new double[] {0, 0, 0, 1, 0};
            inputs[7] = new double[] {1, 0, 1, 0, 0};
            inputs[8] = new double[] {0, 1, 0, 0, 1};
            inputs[9] = new double[] {1, 0, 1, 0, 0};
            inputs[10] = new double[] {0, 1, 0, 0, 1};
            inputs[11] = new double[] {0, 0, 1, 1, 0};
            inputs[12] = new double[] {0, 0, 0, 1, 0};
            inputs[13] = new double[] {0, 0, 0, 0, 1};
            inputs[14] = new double[] {0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "AsmaWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkNeumoniaTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 0, 1, 1};
            inputs[2] = new double[] {1, 1, 1, 1, 1, 0, 1};
            inputs[3] = new double[] {1, 1, 0, 1, 1, 1, 1};
            inputs[4] = new double[] {0, 0, 0, 0, 0, 0, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 0, 1, 0};
            inputs[6] = new double[] {0, 0, 0, 0, 1, 0, 0};
            inputs[7] = new double[] {0, 0, 0, 1, 0, 0, 0};
            inputs[8] = new double[] {0, 0, 1, 0, 0, 1, 0};
            inputs[9] = new double[] {0, 1, 0, 0, 0, 0, 0};
            inputs[10] = new double[] {1, 0, 0, 1, 0, 1, 0};
            inputs[11] = new double[] {0, 1, 0, 0, 1, 0, 0};
            inputs[12] = new double[] {0, 0, 1, 0, 0, 0, 0};
            inputs[13] = new double[] {0, 1, 0, 1, 0, 1, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "NeumoniaWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkCancerDePulmonTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 0, 1, 1, 0, 1, 1, 1};
            inputs[2] = new double[] {1, 0, 0, 1, 1, 1, 1, 1};
            inputs[3] = new double[] {1, 0, 1, 1, 1, 1, 0, 1};
            inputs[4] = new double[] {1, 0, 1, 1, 1, 1, 1, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 0, 0, 0, 1};
            inputs[6] = new double[] {0, 1, 0, 0, 0, 0, 1, 0};
            inputs[7] = new double[] {0, 0, 1, 0, 0, 1, 0, 0};
            inputs[8] = new double[] {0, 0, 0, 0, 1, 0, 0, 1};
            inputs[9] = new double[] {0, 0, 0, 1, 0, 0, 0, 0};
            inputs[10] = new double[] {0, 0, 1, 0, 0, 0, 1, 0};
            inputs[11] = new double[] {0, 1, 0, 1, 0, 1, 0, 1};
            inputs[12] = new double[] {1, 0, 0, 0, 0, 0, 1, 0};
            inputs[13] = new double[] {0, 1, 0, 1, 0, 0, 0, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "CancerDePulmonWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkSinusitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 1, 1, 1, 1, 1, 1, 0, 0};
            inputs[3] = new double[] {1, 1, 1, 1, 1, 1, 0, 0, 0};
            inputs[4] = new double[] {0, 0, 1, 0, 0, 0, 0, 0, 1};
            inputs[5] = new double[] {0, 0, 0, 0, 0, 0, 0, 1, 0};
            inputs[6] = new double[] {0, 1, 0, 0, 0, 0, 1, 0, 0};
            inputs[7] = new double[] {0, 0, 0, 0, 1, 0, 0, 0, 0};
            inputs[8] = new double[] {0, 0, 0, 0, 0, 1, 0, 0, 1};
            inputs[9] = new double[] {0, 0, 0, 1, 0, 0, 0, 0, 0};
            inputs[10] = new double[] {0, 0, 1, 0, 0, 0, 0, 0, 1};
            inputs[11] = new double[] {1, 1, 0, 0, 0, 1, 0, 0, 0};
            inputs[12] = new double[] {0, 0, 0, 0, 1, 0, 0, 1, 0};
            inputs[13] = new double[] {0, 0, 1, 0, 0, 0, 1, 0, 0};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "SinusitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkLaringitisTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 0, 1, 1, 0, 1, 1, 1};
            inputs[2] = new double[] {1, 0, 0, 1, 1, 1, 1, 1};
            inputs[3] = new double[] {1, 0, 1, 1, 0, 1, 1, 1};
            inputs[4] = new double[] {1, 0, 1, 1, 1, 1, 0, 1};
            inputs[5] = new double[] {1, 0, 1, 1, 1, 1, 1, 1};
            inputs[6] = new double[] {0, 0, 0, 0, 0, 0, 0, 1};
            inputs[7] = new double[] {0, 0, 1, 0, 0, 1, 0, 0};
            inputs[8] = new double[] {0, 1, 0, 0, 0, 0, 1, 0};
            inputs[9] = new double[] {0, 0, 0, 0, 1, 0, 0, 1};
            inputs[10] = new double[] {0, 0, 1, 0, 0, 0, 1, 0};
            inputs[11] = new double[] {0, 0, 0, 0, 1, 0, 0, 0};
            inputs[12] = new double[] {1, 0, 1, 0, 0, 1, 0, 0};
            inputs[13] = new double[] {0, 1, 0, 1, 0, 0, 0, 1};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "LaringitisWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkEPOCTest()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 0, 0};
            inputs[3] = new double[] {1, 1, 0, 1, 1, 1, 1, 0, 0, 1};
            inputs[4] = new double[] {1, 1, 1, 1, 1, 0, 0, 0, 1, 0};
            inputs[5] = new double[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[6] = new double[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[7] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 1};
            inputs[8] = new double[] {0, 1, 0, 1, 0, 0, 1, 0, 0, 0};
            inputs[9] = new double[] {0, 0, 0, 0, 0, 0, 0, 1, 0, 1};
            inputs[10] = new double[] {0, 0, 1, 0, 0, 1, 0, 0, 0, 0};
            inputs[11] = new double[] {0, 0, 0, 0, 1, 0, 0, 1, 0, 1};
            inputs[12] = new double[] {0, 0, 0, 1, 0, 0, 0, 0, 0, 1};
            inputs[13] = new double[] {0, 1, 0, 0, 0, 1, 0, 0, 0, 1};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "EPOCWeights"});
            Assert.Pass();
        }
        
        [Test]
        public void TrainingNetworkCovid19Test()
        {
            var service = new TrainNetworkService();
            var inputs = new double[15][];
            inputs[0] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[1] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0};
            inputs[2] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0};
            inputs[3] = new double[] {1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0};
            inputs[4] = new double[] {1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0};
            inputs[5] = new double[] {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[6] = new double[] {0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            inputs[7] = new double[] {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1};
            inputs[8] = new double[] {0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0};
            inputs[9] = new double[] {1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1};
            inputs[10] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1};
            inputs[11] = new double[] {1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0};
            inputs[12] = new double[] {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1};
            inputs[13] = new double[] {1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1};
            inputs[14] = new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            var outputs = new double[]{1 ,1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0};
            service.Ejecute(new TrainNetworkRequest(){InputsValues = inputs, OutputsValues = outputs, FileName = "Covid19Weights"});
            Assert.Pass();
        }
    }
}