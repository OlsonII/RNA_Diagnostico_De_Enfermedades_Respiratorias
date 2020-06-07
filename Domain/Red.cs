﻿using System;

namespace Domain
{
    public class Red
    {
        public static Random RandomGenerator;
        public int Entradas;
        public int Salidas;
        public int NumeroNeuronasOcultas;
        public int CapasOcultas;
        public double[,] ValoresEntrada;
        public double[] ValoresSalida;
        public double[,] PesosEntradaAOculta;
        public double[] PesosOcultaASalida;
        public double[] UmbralesCapaOculta;
        public double[] UmbralesSalida;
        public double Error;
        public Neurona[] NeuronasOcultas;
        public Neurona[] NeuronasSalida;
        public double SalidaRedondeada = 0.0;
        public const double RataAprendizaje = 0.06;

        public Red(int numeroNeuronasOcultas, double[,] valoresEntrada, double[] valoresSalida)
        {
            NumeroNeuronasOcultas = numeroNeuronasOcultas;
            ValoresEntrada = valoresEntrada;
            ValoresSalida = valoresSalida;
            Entradas = ValoresEntrada.GetLength(1);
            Salidas = 1;
            CapasOcultas = 1;
            PesosEntradaAOculta = new double[Entradas,NumeroNeuronasOcultas];
            PesosOcultaASalida = new double[NumeroNeuronasOcultas];
            UmbralesCapaOculta = new double[NumeroNeuronasOcultas];
            UmbralesSalida = new double[ValoresEntrada.GetLength(1)];
            NeuronasOcultas = new Neurona[NumeroNeuronasOcultas];
            NeuronasSalida = new Neurona[ValoresEntrada.GetLength(0)];
        }

        public Red(int numeroNeuronasOcultas, double[,] valoresEntrada)
        {
            NumeroNeuronasOcultas = numeroNeuronasOcultas;
            ValoresEntrada = valoresEntrada;
            Entradas = ValoresEntrada.GetLength(1);
            Salidas = 1;
            CapasOcultas = 1;
            PesosEntradaAOculta = new double[Entradas,NumeroNeuronasOcultas];
            PesosOcultaASalida = new double[NumeroNeuronasOcultas];
            UmbralesCapaOculta = new double[NumeroNeuronasOcultas];
            UmbralesSalida = new double[ValoresEntrada.GetLength(1)];
            NeuronasOcultas = new Neurona[NumeroNeuronasOcultas];
            NeuronasSalida = new Neurona[ValoresEntrada.GetLength(0)];
        }

        //TODO: DIVIDIR EN MODULOS ESTE METODO
        public void InicializarPesos()
        {
            RandomGenerator = new Random();
            
            #region FillInputWeights
            for (int input = 0; input < Entradas; input++)
                for (int firstHidden = 0; firstHidden < NumeroNeuronasOcultas; firstHidden++)
                    PesosEntradaAOculta[input,firstHidden] = RandomGenerator.NextDouble();
            #endregion

            #region FillHiddenToOutputWeights
            for (int hidden = 0; hidden < NumeroNeuronasOcultas; hidden++)
                PesosOcultaASalida[hidden] = RandomGenerator.NextDouble();
            #endregion
                
            #region FillHiddenBiases

            for (int layer = 0; layer < CapasOcultas; layer++)
                for (int hidden = 0; hidden < NumeroNeuronasOcultas; hidden++)
                    UmbralesCapaOculta[hidden] = RandomGenerator.NextDouble();
            
            #endregion

            #region FillOutputBiases

            for (int output = 0; output < Salidas; output++)
                UmbralesSalida[output] = RandomGenerator.NextDouble();

            #endregion
        }

        public void FowardPass(int pattern)
        {
            #region InputToHidden
            for (int hidden = 0; hidden < NumeroNeuronasOcultas; hidden++)
            {
                NeuronasOcultas[hidden] = new Neurona();

                for (int input = 0; input < Entradas; input++)
                {
                    NeuronasOcultas[hidden].Entrada += PesosEntradaAOculta[input,hidden] * ValoresEntrada[pattern,input]; //TODO: HIDDEN
                }

                NeuronasOcultas[hidden].Entrada += UmbralesCapaOculta[hidden] * 1;
                NeuronasOcultas[hidden].Salida = (1 / (1 + Math.Pow(Math.E, -1*NeuronasOcultas[hidden].Entrada)));
            }
            #endregion
                
            #region HiddenToOutput

            NeuronasSalida[pattern] = new Neurona();
            for (int hidden = 0; hidden < NeuronasOcultas.Length; hidden++)
            {
                NeuronasSalida[pattern].Entrada += PesosOcultaASalida[hidden] * NeuronasOcultas[hidden].Salida;
            }
            NeuronasSalida[pattern].Entrada += UmbralesSalida[0] * 1;
            NeuronasSalida[pattern].Salida = (1 / (1 + Math.Pow(Math.E, -1*NeuronasSalida[pattern].Entrada)));
            SalidaRedondeada = Math.Round(NeuronasSalida[pattern].Salida);

            #endregion
        }

        public void Entrenamiento()
        {
            for (int iteracion = 0; iteracion < 30000; iteracion++)
            {
                Console.WriteLine($"************************Iteracion {iteracion}**********************************");
                for (int patron = 0; patron < ValoresEntrada.GetLength(0); patron++)
                {
                    var hiddenToOutputsWeightsUpdated = PesosOcultaASalida;
                    var inputToHiddenWeightsUpdated = PesosEntradaAOculta;
                    var dErrorWithOutput = 0.0;
                    var dOutOutputWithInputOutput = 0.0;
                    var dInputOutputWithWeight = 0.0;
                    var dInputOutputWithHiddenOutput = 0.0;
                    var dOutHiddenWithInputHidden = 0.0;
                    var dErrorWithOutputHidden = 0.0;
                    var dInputHiddenWithWeight = 0.0;
                    var dErrorWithWeight = 0.0;
                    Console.WriteLine($"Valores entrada: {ValoresEntrada[patron,0]} - {ValoresEntrada[patron,1]}");
                    
                    FowardPass(patron);

                    #region Error

                    Error = (0.5) * Math.Pow(ValoresSalida[patron] - NeuronasSalida[patron].Salida, 2);
                    Console.WriteLine($"Salida esperada: {ValoresSalida[patron]} | Salida Obtenida: {NeuronasSalida[patron].Salida}");
                    Console.WriteLine($"Error patron {patron}: {Error}");

                    #endregion
                
                    //TODO:BACKWARD PASS

                    for (int oculta = 0; oculta < PesosOcultaASalida.Length; oculta++)
                    {
                        dErrorWithOutput = Math.Pow(ValoresSalida[patron] - NeuronasSalida[patron].Salida, 2-1) * -1;
                        dOutOutputWithInputOutput = NeuronasSalida[patron].Salida * (1 - NeuronasSalida[patron].Salida);
                        dInputOutputWithWeight = NeuronasOcultas[oculta].Salida;

                        hiddenToOutputsWeightsUpdated[oculta] =
                            PesosOcultaASalida[oculta] - RataAprendizaje *
                            (dErrorWithOutput * dOutOutputWithInputOutput * dInputOutputWithWeight);
                    }
                
                    var dErrorWithInputOutput = dErrorWithOutput * dOutOutputWithInputOutput;

                    for (int entrada = 0; entrada < Entradas; entrada++)
                    {
                        for (int oculta = 0; oculta < NumeroNeuronasOcultas; oculta++)
                        {
                            for (int subOculta = 0; subOculta < NeuronasOcultas.Length; subOculta++)
                            {
                                var valueA = PesosOcultaASalida[subOculta];
                                var valueB = NeuronasOcultas[subOculta].Salida;
                                if (valueB == NeuronasOcultas[oculta].Salida)
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

                            dOutHiddenWithInputHidden = NeuronasOcultas[oculta].Salida * (1 - NeuronasOcultas[oculta].Salida);
                            dErrorWithOutputHidden = dErrorWithInputOutput * dInputOutputWithHiddenOutput;

                            for (int subInput = 0; subInput < Entradas; subInput++)
                            {
                                var valueA = PesosEntradaAOculta[subInput,oculta];
                                var valueB = ValoresEntrada[patron,subInput];
                                if (valueA == PesosEntradaAOculta[subInput, oculta])
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
                            inputToHiddenWeightsUpdated[entrada, oculta] =
                                PesosEntradaAOculta[entrada, oculta] - RataAprendizaje * dErrorWithWeight;
                        }
                    }

                    PesosEntradaAOculta = inputToHiddenWeightsUpdated;
                    PesosOcultaASalida = hiddenToOutputsWeightsUpdated;
                }
            }
            
        }
    }
}