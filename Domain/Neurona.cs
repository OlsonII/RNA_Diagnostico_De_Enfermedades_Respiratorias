﻿namespace Domain
{
    public class Neurona
    {
        public double Entrada;
        public double Salida;

        public Neurona(double entrada, double salida)
        {
            Entrada = entrada;
            Salida = salida;
        }

        public Neurona()
        {
            this.Entrada = 0.0;
            this.Salida = 0.0;
        }
    }
}