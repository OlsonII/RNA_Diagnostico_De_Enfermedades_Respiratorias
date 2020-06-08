﻿using System;

namespace Domain
{
    public class Sigmoide
    {
        public static double Salida(double value)
        {
            return 1.0 / (1.0 + Math.Exp(-value));
        }

        public static double Derivar(double value)
        {
            return value * (1 - value);
        }
    }
}