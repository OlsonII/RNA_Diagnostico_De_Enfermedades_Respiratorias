﻿namespace Domain
{
    public class Node
    {
        public double Input;
        public double Output;

        public Node(double input, double output)
        {
            Input = input;
            Output = output;
        }

        public Node()
        {
            this.Input = 0.0;
            this.Output = 0.0;
        }
    }
}