namespace ex_1
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Envelhecer(int anos)

        {
            Idade += anos;
        }

        public void Desenvelhecer(int anos)

        {
            Idade -= anos;
        }

    }

    public class Funcionario : Pessoa
    {

    }   
}
