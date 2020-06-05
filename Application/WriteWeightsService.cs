﻿using System.IO;

namespace Application
{
    public class WriteWeightsService
    {
        public WriteWeightsResponse Ejecute(WriteWeightsRequest request)
        {
            var fileToWrite = new StreamWriter("D:\\Weights\\PesosEnfermedad01.txt");
            
            for (int input = 0; input < request.InputToHiddenWeights.GetLength(0); input++)
            {
                var text = "";
                for (int hidden = 0; hidden < request.InputToHiddenWeights.GetLength(1); hidden++)
                {
                    text += request.InputToHiddenWeights[input, hidden] + " | ";
                }
                fileToWrite.WriteLine(text);
                fileToWrite.WriteLine("---");
            }
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            for (int hidden = 0; hidden < request.HiddenToOutputWeights.Length; hidden++)
            {
                fileToWrite.WriteLine(request.HiddenToOutputWeights[hidden].ToString());
                fileToWrite.WriteLine("---");
            }
            fileToWrite.Close();
            return null;
        }
    }

    public class WriteWeightsRequest
    {
        public double[,] InputToHiddenWeights { get; set; }
        public double[] HiddenToOutputWeights { get; set; }
    }

    public class WriteWeightsResponse
    {
        
    }
}