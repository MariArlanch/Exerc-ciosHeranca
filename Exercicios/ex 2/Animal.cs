namespace ex_2
{
    public abstract class Animal
    {
        public string Especie { get; set; }

        public abstract void EmitirSom();
        
    }

    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O gato faz: Miau!");
        }
    }

    public class Porco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O porco faz: Oinc oinc!");
        }
    }

    public class Capivara : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("A capivara faz: Ronronar e grunhidos suaves!");
        }
    }
}
