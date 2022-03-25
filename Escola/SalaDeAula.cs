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
        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public void RemoverAluno(string cpf){
            Alunos.RemoveAll(aluno => aluno.CPF == cpf);
        }
        public void MudarProfessor(string nomeProfessor){
            NomeDoProfessor = nomeProfessor;
        }
    }
}