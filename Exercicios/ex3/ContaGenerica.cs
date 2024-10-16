using System.ComponentModel;

namespace ex3;

public abstract class Contagenerica
{
    public string Banco { get; set; }
    public int Agente { get; set; }
    public int conta { get; set; }
    public double Saldo { get; set; }

    public abstract void Depositar();
    public abstract void Sacar();
}

public class ContaCorrente : Contagenerica
{
    public double limite { get; set; }
    public override void Depositar()
    {
        Console.WriteLine("Você depositou 500 reais");
    }
    public override void Sacar()
    {
        Console.WriteLine("Você sacou 200 reais");
    }
}

