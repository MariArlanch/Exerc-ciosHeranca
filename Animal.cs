using _01___Heranca;

namespace _01___Heranca
{
    //a classe "Animal" é uma classe abstrarta que servirá de modelo para os outros animais
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string TipoAlimentacao { get; set; }

        /*Método abstrato não possui implementação aqui, mas as classes que herdarem vão precisar implementar*/
        public abstract void EmitirSom();

    }
    //A classe "Cachorro" herda da classe animal
    /*isso significa que o cachorro tera todos os atributos e comportamentos definidos em animal. 
     * Mas tambem pode ser suas proprias caracteristicas*/
    public class Cachorro : Animal
    {
        public string Raca { get; set; }
        //bool significa booleana, ou seja, espera uma resposta verdadeira ou falsa para atributo
        public bool BuscaObjetos { get; set; }

        public override void EmitirSom()
        {
            Console.WriteLine("Auau");
        }

    }

}
