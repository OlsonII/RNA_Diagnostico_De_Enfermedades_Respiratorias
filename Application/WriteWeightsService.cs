using System.IO;
using Domain;

namespace Application
{
    public class WriteWeightsService
    {
        public void Ejecute(WriteWeightsRequest request)
        {
            var fileToWrite = new StreamWriter($"D:\\Weights\\{request.FileName}.txt");
            
            for (int oculta = 0; oculta < request.CapaOculta.Length; oculta++)
            {
                var text = "";
                for (int pesos = 0; pesos < request.CapaOculta[oculta].Pesos.Length; pesos++)
                {
                    text += request.CapaOculta[oculta].Pesos[pesos] + " | ";
                }
                fileToWrite.WriteLine(text);
                fileToWrite.WriteLine("---");
            }
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            for (int salida = 0; salida < request.NeuronaSalida.Pesos.Length; salida++)
            {
                fileToWrite.WriteLine(request.NeuronaSalida.Pesos[salida].ToString());
                fileToWrite.WriteLine("---");
            }
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            for (int hidden = 0; hidden < request.CapaOculta.Length; hidden++)
            {
                fileToWrite.WriteLine(request.CapaOculta[hidden].Umbral.ToString());
                fileToWrite.WriteLine("---");
            }
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine("---");
            fileToWrite.WriteLine(request.UmbralSalida.ToString());
            fileToWrite.Close();
        }
    }

    public class WriteWeightsRequest
    {
        public Neurona[] CapaOculta { get; set; }
        public Neurona NeuronaSalida { get; set; }
        public double UmbralSalida { get; set; }
        public string FileName { get; set; }
    }
}