using System;
using Domain;

namespace Application
{
    public class DiagnosticoService
    {
        public DiagnosticoResponse Ejecute(DiagnosticoRequest request)
        {
            var red = new Red(request.InputsValues);
            var reader = new ReadWeightsService().Ejecute(new ReadWeightsRequest(){Inputs = red.Entradas, FileName = request.NombreDelArchivo});
            if (reader != null)
            {
                for (var i = 0; i < red.NeuronasOcultas.Length; i++)
                {
                    for (var pesos = 0; pesos < red.NeuronasOcultas[i].Pesos.Length; pesos++)
                    {
                        red.NeuronasOcultas[i].Pesos[pesos] = reader.PesosCapaOculta[i, pesos];
                    }
                    red.NeuronasOcultas[i].Umbral = reader.UmbralesCapaOculta[i];
                }
                
                red.NeuronaDeSalida.Pesos = reader.PesosSalida;
                red.NeuronaDeSalida.Umbral = reader.UmbralSalida;
                red.EstaEntrenada = true;
                red.FowardPass(request.InputsValues);
            }
            else
            {
                red.EstaEntrenada = false;
            }
            if (Math.Round(red.NeuronaDeSalida.Salida()) == 1)
            {
                return new DiagnosticoResponse(){Diagnostico = "Positivo"};
            }
            return new DiagnosticoResponse(){Diagnostico = "Negativo"};
        }
    }

    public class DiagnosticoRequest
    {
        public double[] InputsValues { get; set; }
        public string NombreDelArchivo { get; set; }
    }

    public class DiagnosticoResponse
    {
        public string Diagnostico { get; set; }
    }
}