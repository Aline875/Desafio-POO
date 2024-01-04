using System;

namespace Celulares
{
    public abstract class Smartphone
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Numero { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public abstract void InstalarAplicativo(string aplicativo);
        public abstract void Ligar(string numero);
        public abstract void ReceberChamada(string numero);
    }

    public class Nokia : Smartphone
    {
        public Nokia(string modelo, string numero, string imei, int memoria)
        {
            Marca = "Nokia";
            Modelo = modelo;
            Numero = numero;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo} na plataforma Windows Store do {Marca} {Modelo}.");
        }

        public override void Ligar(string numero)
        {
            Console.WriteLine($"Discando {numero} no {Marca} {Modelo}.");
        }

        public override void ReceberChamada(string numero)
        {
            Console.WriteLine($"Recebendo chamada de {numero} no {Marca} {Modelo}.");
        }
    }

    public class Iphone : Smartphone
    {
        public Iphone(string modelo, string numero, string imei, int memoria)
        {
            Marca = "iPhone";
            Modelo = modelo;
            Numero = numero;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo} na App Store do {Marca} {Modelo}.");
        }

        public override void Ligar(string numero)
        {
            Console.WriteLine($"Discando {numero} no {Marca} {Modelo}.");
        }

        public override void ReceberChamada(string numero)
        {
            Console.WriteLine($"Recebendo chamada de {numero} no {Marca} {Modelo}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("Lumia", "123456789", "IMEI1234", 64);
            Iphone iphone = new Iphone("12", "987654321", "IMEI5678", 128);

            nokia.Ligar("987654321");
            iphone.ReceberChamada("123456789");
        }
    }
}
