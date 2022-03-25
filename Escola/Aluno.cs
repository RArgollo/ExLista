namespace ExLista.Escola
{
    public class Aluno
    {
        public string Nome { get; }    
        public DateTime DataDeNascimento { get; }
        public string CPF { get; set; }
        public Aluno(string nome,string cpf, DateTime dataDeNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataDeNascimento = dataDeNascimento;
        }
    }
}