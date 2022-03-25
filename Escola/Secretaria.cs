namespace ExLista.Escola
{
    public class Secretaria
    {
        public void CadastrarNovasTurmas()
        {
            var salasDeAula = new List<SalaDeAula>();
            var opcaoContinuar = 0;
            do
            {
                Console.WriteLine("Deseja adicionar uma nova sala de aula? 1-Sim ou 2-Nao");
                opcaoContinuar = int.Parse(Console.ReadLine());
                if (opcaoContinuar == 1)
                {
                    Console.WriteLine("Qual o nome do Professor?");
                    var nomeProfessor = Console.ReadLine();
                    Console.WriteLine("Qual a serie?");
                    var serie = Console.ReadLine();
                    var alunos = CadastrarAlunosIniciais();
                    salasDeAula.Add(new SalaDeAula(serie,alunos,nomeProfessor));

                }
            } while (opcaoContinuar != 2);
        }
        private List<Aluno> CadastrarAlunosIniciais()
        {
            var continuarAdicionando = 0;
            Console.WriteLine("Deseja adicionar novos alunos? 1-sim ou 2-não");
            continuarAdicionando = int.Parse(Console.ReadLine());
            var alunosIniciais = new List<Aluno>();
            while (continuarAdicionando == 1)
            {
                alunosIniciais.Add(CadastrarAluno());
                Console.WriteLine("Deseja adicionar novos alunos? 1-sim ou 2-não");
                continuarAdicionando = int.Parse(Console.ReadLine());
            }
            return alunosIniciais;
        }
        private Aluno CadastrarAluno()
        {
            Console.WriteLine("Qual o nome do aluno?");
            var nomeAluno = Console.ReadLine();
            Console.WriteLine("Qual o CPF do aluno?");
            var cpfAluno = Console.ReadLine();
            Console.WriteLine("Qual a data de nascimento do aluno?");
            var dataNascimentoAluno = DateTime.Parse(Console.ReadLine());
            return new Aluno(nomeAluno, cpfAluno, dataNascimentoAluno);
        }
    }
}