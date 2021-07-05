namespace pooMaiorIdade
{
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public Pessoa()
        {
        }

        public Pessoa(int idade, string nome)
        {
            this.Idade = idade;
            this.Nome = nome;
        }

        public string ExibirDados()
        {
            return ("nome: " + this.Nome + "/n idade: " + this.Idade);
        }
    }
}
