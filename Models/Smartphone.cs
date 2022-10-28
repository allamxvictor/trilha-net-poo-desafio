namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string Modelo { get; set; }

        private string Emei { get; set; }

        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string emei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Emei = emei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}