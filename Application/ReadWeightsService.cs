using System;
using System.IO;

namespace Application
{
    public class ReadWeightsService
    {

        public ReadWeightsResponse Ejecute(ReadWeightsRequest request)
        {
            if (!File.Exists($"D:\\Weights\\{request.FileName}.txt"))
                return null;
            
            var file = new StreamReader($"D:\\Weights\\{request.FileName}.txt");
            var response = new ReadWeightsResponse();
            response.InputToHiddenWeights = new double[request.Inputs, 20];
            response.HiddenToOutputWeights = new double[20];
            response.UmbralesCapaOculta = new double[20];
            response.UmbralSalida = 0.0;
            var input = 0;
            var hidden = 0;
            string line = file.ReadLine();
            while (line != null)
            {
                if (!line.Equals("---"))
                {
                    if (input < request.Inputs)
                    {
                        var numbers = line.Split(" | ");
                        for (var i = 0; i < 20; i++)
                        {
                            if (numbers[i] != " | " && numbers[i] != "")
                            {
                                response.InputToHiddenWeights[input, i] = double.Parse(numbers[i]);
                            }
                        }
                        input++;
                    }
                    else if(hidden < 20)
                    {
                        response.HiddenToOutputWeights[hidden] = double.Parse(line);
                        hidden++;
                    }
                    else if(hidden < 40)
                    {
                        response.UmbralesCapaOculta[hidden - 20] = double.Parse(line);
                        hidden++;
                    }
                    else
                    {
                        response.UmbralSalida = Double.Parse(line);
                    }
                }
                line = file.ReadLine();
            }
            return response;
        }
    }
    
    public class ReadWeightsRequest
    {
        public string FileName { get; set; }
        public int Inputs { get; set; }
    }

    public class ReadWeightsResponse
    {
        public double[,] InputToHiddenWeights { get; set; }
        public double[] HiddenToOutputWeights { get; set; }
        public double[] UmbralesCapaOculta { get; set; }
        public double UmbralSalida { get; set; }
    }
}