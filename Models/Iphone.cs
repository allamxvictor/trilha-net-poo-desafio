namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone...");
        }
    }
}