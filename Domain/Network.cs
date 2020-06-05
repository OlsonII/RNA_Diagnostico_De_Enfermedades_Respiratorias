﻿using System;

namespace Domain
{
    public class Network
    {
        public static Random RandomGenerator;
        public int Inputs;
        public int Outputs;
        public int HiddenNodesNumber;
        public int HiddenLayers;
        public double[,] InputsValues;
        public double[] OutputsValues;
        public double[,] InputsToHiddenWeights;
        public double[] HiddenToOutputsWeights;
        public double[] HiddenBiases;
        public double[] OutputsBiases;
        public double Error;
        public Node[] HiddenNodes;
        public Node[] OutputNodes;
        public const double LearningRate = 0.06;

        public Network(int hiddenNodesNumber, double[,] inputsValues, double[] outputsValues)
        {
            HiddenNodesNumber = hiddenNodesNumber;
            InputsValues = inputsValues;
            OutputsValues = outputsValues;
            Inputs = InputsValues.GetLength(1);
            Outputs = 1;
            HiddenLayers = 1;
            InputsToHiddenWeights = new double[Inputs,HiddenNodesNumber];
            HiddenToOutputsWeights = new double[HiddenNodesNumber];
            HiddenBiases = new double[HiddenNodesNumber];
            OutputsBiases = new double[InputsValues.GetLength(1)];
            HiddenNodes = new Node[HiddenNodesNumber];
            OutputNodes = new Node[InputsValues.GetLength(0)];
        }

        //TODO: DIVIDIR EN MODULOS ESTE METODO
        public void InitWeights()
        {
            RandomGenerator = new Random();
            
            #region FillInputWeights
            for (int input = 0; input < Inputs; input++)
                for (int firstHidden = 0; firstHidden < HiddenNodesNumber; firstHidden++)
                    InputsToHiddenWeights[input,firstHidden] = RandomGenerator.NextDouble();
            #endregion

            #region FillHiddenToOutputWeights
            for (int hidden = 0; hidden < HiddenNodesNumber; hidden++)
                HiddenToOutputsWeights[hidden] = RandomGenerator.NextDouble();
            #endregion
                
            #region FillHiddenBiases

            for (int layer = 0; layer < HiddenLayers; layer++)
                for (int hidden = 0; hidden < HiddenNodesNumber; hidden++)
                    HiddenBiases[hidden] = RandomGenerator.NextDouble();
            
            #endregion

            #region FillOutputBiases

            for (int output = 0; output < Outputs; output++)
                OutputsBiases[output] = RandomGenerator.NextDouble();

            #endregion
        }

        public void FowardPass(int pattern)
        {
            #region InputToHidden
            for (int hidden = 0; hidden < HiddenNodesNumber; hidden++)
            {
                HiddenNodes[hidden] = new Node();

                for (int input = 0; input < Inputs; input++)
                {
                    HiddenNodes[hidden].Input += InputsToHiddenWeights[input,hidden] * InputsValues[pattern,input]; //TODO: HIDDEN
                }

                HiddenNodes[hidden].Input += HiddenBiases[hidden] * 1;
                HiddenNodes[hidden].Output = (1 / (1 + Math.Pow(Math.E, -1*HiddenNodes[hidden].Input)));
            }
            #endregion
                
            #region HiddenToOutput

            OutputNodes[pattern] = new Node();
            for (int hidden = 0; hidden < HiddenNodes.Length; hidden++)
            {
                OutputNodes[pattern].Input += HiddenToOutputsWeights[hidden] * HiddenNodes[hidden].Output;
            }
            OutputNodes[pattern].Input += OutputsBiases[0] * 1;
            OutputNodes[pattern].Output = (1 / (1 + Math.Pow(Math.E, -1*OutputNodes[pattern].Input)));
            #endregion
        }

        public void Training()
        {
            for (int iteration = 0; iteration < 30000; iteration++)
            {
                Console.WriteLine($"************************Iteracion {iteration}**********************************");
                for (int pattern = 0; pattern < InputsValues.GetLength(0); pattern++)
                {
                    var hiddenToOutputsWeightsUpdated = HiddenToOutputsWeights;
                    var inputToHiddenWeightsUpdated = InputsToHiddenWeights;
                    var dErrorWithOutput = 0.0;
                    var dOutOutputWithInputOutput = 0.0;
                    var dInputOutputWithWeight = 0.0;
                    var dInputOutputWithHiddenOutput = 0.0;
                    var dOutHiddenWithInputHidden = 0.0;
                    var dErrorWithOutputHidden = 0.0;
                    var dInputHiddenWithWeight = 0.0;
                    var dErrorWithWeight = 0.0;
                    Console.WriteLine($"Valores entrada: {InputsValues[pattern,0]} - {InputsValues[pattern,1]}");
                    
                    FowardPass(pattern);

                    #region Error

                    Error = (0.5) * Math.Pow(OutputsValues[pattern] - OutputNodes[pattern].Output, 2);
                    Console.WriteLine($"Salida esperada: {OutputsValues[pattern]} | Salida Obtenida: {OutputNodes[pattern].Output}");
                    Console.WriteLine($"Error patron {pattern}: {Error}");

                    #endregion
                
                    //TODO:BACKWARD PASS

                    for (int hidden = 0; hidden < HiddenToOutputsWeights.Length; hidden++)
                    {
                        dErrorWithOutput = Math.Pow(OutputsValues[pattern] - OutputNodes[pattern].Output, 2-1) * -1;
                        dOutOutputWithInputOutput = OutputNodes[pattern].Output * (1 - OutputNodes[pattern].Output);
                        dInputOutputWithWeight = HiddenNodes[hidden].Output;

                        hiddenToOutputsWeightsUpdated[hidden] =
                            HiddenToOutputsWeights[hidden] - LearningRate *
                            (dErrorWithOutput * dOutOutputWithInputOutput * dInputOutputWithWeight);
                    }
                
                    var dErrorWithInputOutput = dErrorWithOutput * dOutOutputWithInputOutput;

                    for (int input = 0; input < Inputs; input++)
                    {
                        for (int hidden = 0; hidden < HiddenNodesNumber; hidden++)
                        {
                            for (int subHidden = 0; subHidden < HiddenNodes.Length; subHidden++)
                            {
                                var valueA = HiddenToOutputsWeights[subHidden];
                                var valueB = HiddenNodes[subHidden].Output;
                                if (valueB == HiddenNodes[hidden].Output)
                                {
                                    valueB = 1;
                                    dInputOutputWithHiddenOutput += valueA * valueB;
                                    break;
                                }
                                else
                                {
                                    valueB = 0;
                                }
                                dInputOutputWithHiddenOutput += valueA * valueB;
                            }

                            dOutHiddenWithInputHidden = HiddenNodes[hidden].Output * (1 - HiddenNodes[hidden].Output);
                            dErrorWithOutputHidden = dErrorWithInputOutput * dInputOutputWithHiddenOutput;

                            for (int subInput = 0; subInput < Inputs; subInput++)
                            {
                                var valueA = InputsToHiddenWeights[subInput,hidden];
                                var valueB = InputsValues[pattern,subInput];
                                if (valueA == InputsToHiddenWeights[subInput, hidden])
                                {
                                    valueA = 1;
                                    dInputHiddenWithWeight += valueA * valueB;
                                    break;
                                }
                                else
                                {
                                    valueA = 0;
                                }
                                dInputHiddenWithWeight += valueA * valueB;
                            }
                            //
                            dErrorWithWeight = dErrorWithOutputHidden * dOutHiddenWithInputHidden*dInputHiddenWithWeight;
                            inputToHiddenWeightsUpdated[input, hidden] =
                                InputsToHiddenWeights[input, hidden] - LearningRate * dErrorWithWeight;
                        }
                    }

                    InputsToHiddenWeights = inputToHiddenWeightsUpdated;
                    HiddenToOutputsWeights = hiddenToOutputsWeightsUpdated;
                }
            }
            
        }
    }
}