﻿using System;

namespace Domain
{
    public class Red
    {
        public double[][] ValoresEntradas;
        public double[] ValoresSalida;
        public int Entradas;
        public const int Salidas = 1;
        public Neurona[] NeuronasOcultas = new Neurona[20];
        public Neurona NeuronaDeSalida;
        public const int Iteraciones = 2000;
        public bool EstaEntrenada = false;

        public Red(double[][] valoresEntradas, double[] valoresSalida)
        {
            ValoresEntradas = valoresEntradas;
            ValoresSalida = valoresSalida;
            for (var ocultas = 0; ocultas < 20; ocultas++)
            {
                NeuronasOcultas[ocultas] = new Neurona(valoresEntradas[0].Length);
                if(!EstaEntrenada)
                    NeuronasOcultas[ocultas].GenerarPesosAleatorios();
            }
            NeuronaDeSalida = new Neurona(20);
            if(!EstaEntrenada)
                NeuronaDeSalida.GenerarPesosAleatorios();
        }

        public Red(double[] valoresEntradas)
        {
            ValoresEntradas[0] = valoresEntradas;
        }

        public void FowardPass(double[] patron)
        {
            for (var oculta = 0; oculta < NeuronasOcultas.Length; oculta++)
            {
                NeuronasOcultas[oculta].Entradas = patron;
                NeuronaDeSalida.Entradas[oculta] = NeuronasOcultas[oculta].Salida();
            }
            Console.WriteLine($"Salida Obtenida: {NeuronaDeSalida.Salida()}");
            Console.WriteLine($"Error: {NeuronaDeSalida.Error}");
        }

        public void BackWard(int patron)
        {
            NeuronaDeSalida.Error = Sigmoide.Derivar(NeuronaDeSalida.Salida()) * (ValoresSalida[patron] - NeuronaDeSalida.Salida());
            NeuronaDeSalida.AjustarPesos();

            for (var oculta = 0; oculta < NeuronasOcultas.Length; oculta++)
            {
                NeuronasOcultas[oculta].Error = Sigmoide.Derivar(NeuronasOcultas[oculta].Salida()) * 
                                                 NeuronaDeSalida.Error *
                                                 NeuronaDeSalida.Pesos[oculta];
                NeuronasOcultas[oculta].AjustarPesos();
            }
            
        }

        public void Entrenar()
        {
            for (int iteracion = 0; iteracion < Iteraciones; iteracion++)
            {
                Console.WriteLine($"************************Iteracion {iteracion}**********************************");
                for (var patron = 0; patron < ValoresEntradas.Length; patron++)
                {
                    FowardPass(ValoresEntradas[patron]);
                    BackWard(patron);
                }
            }
        }
    }
}