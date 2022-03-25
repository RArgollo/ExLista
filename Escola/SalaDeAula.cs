namespace ExLista.Escola
{
    public class SalaDeAula
    {
        public string NomeDoProfessor { get; set; }
        public string Serie { get; }
        public List<Aluno> Alunos { get; private set; }
        public SalaDeAula(string serie, List<Aluno> alunosInicial, string professor)
        {
            NomeDoProfessor = professor;
            Serie = serie;
            Alunos = alunosInicial;
        }
        public void AdicionarAluno(string nome, string cpf, DateTime dataDeNascimento)
        {
            Alunos.Add(new Aluno(nome, cpf, dataDeNascimento));
        }
        public void RemoverAluno(string cpf)
        {
            Alunos.RemoveAll(aluno => aluno.CPF == cpf);
        }
        public void MudarProfessor(string nomeProfessor)
        {
            NomeDoProfessor = nomeProfessor;
        }
    }
}