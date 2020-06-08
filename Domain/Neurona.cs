﻿using System;

namespace Domain
{
    public class Neurona
    {
        public double[] Entradas;
        public double[] Pesos;
        public double Error;

        public double Umbral;
        
        private Random _random = new Random();

        public Neurona()
        {
        }

        public Neurona(int entradas)
        {
            Entradas = new double[entradas];
            Pesos = new double[entradas];
        }

        public void GenerarPesosAleatorios()
        {
            for (var i = 0; i < Entradas.Length; i++)
            {
                Pesos[i] = _random.NextDouble();
            }
            Umbral = _random.NextDouble();
        }

        public void AjustarPesos()
        {
            for (var i = 0; i < Pesos.Length; i++)
            {
                Pesos[i] += Error * Entradas[i];
            }
            Umbral += Error;
        }

        public double Salida()
        {
            var salida = 0.0;
            for (var i = 0; i < Entradas.Length; i++)
            {
                salida += Pesos[i] * Entradas[i];
            }
            salida += Umbral;
            return Sigmoide.Salida(salida);
        }
    }
}