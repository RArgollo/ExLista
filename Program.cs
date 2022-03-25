using ExLista.Escola;
namespace ExLista;
public class Program
{
    static void Main(string[] args)
    {
        var secretaria = new Secretaria();
        secretaria.CadastrarNovasTurmas();
    }
    static void ExerciciosLista()
    {
        var numeros = new List<int>();
        var numerosMaisDoze = new List<int>();
        var strings = new List<string>();
        for (var contador = 0; contador < 10; contador++)
        {
            //Adicionar um valor dentro da lista
            numeros.Add(contador + 2);
            numerosMaisDoze.Add(contador + 12);
            strings.Add(contador.ToString());
        }
        //Adicinar uma lista dentro de outra
        numeros.AddRange(numerosMaisDoze);
        //Remover Item
        numeros.Remove(5);
        numeros.RemoveAt(2);
        numeros.RemoveAll(numeroARemover => numeroARemover != 10); // referência do predicado
        numeros.RemoveRange(0, 5); //a partir da posição, x itens (posição, QtdeItens)
        //Buscar index de um valor
        numeros.IndexOf(5); //busca a posição do valor informado
        //Buscar um valor na lista
        numeros.ElementAt(3); // busca o valor na posição informada
        numeros.Find(numero => numero % 2 == 0); // busca o primeiro valor que atenda ao predicado
        numeros.FindAll(numero => numero % 2 == 0); // busca todos os valores que atendam ao predicado e retorna uma lista
        numeros.Where(numero => numero % 2 == 0); // ***
        //Verificação
        numeros.Any(numero => numero % 2 == 0); // confirmação de existência de qualquer item que atendam ao predicado
        numeros.Exists(numero => numero % 2 == 0); // confirmação de existência de qualquer item que atendam ao predicado
        numeros.All(numero => numero % 2 == 0); //verifica se todos os números atendem ao predicado
        //Ordenação
        numeros.OrderByDescending(x => x); // retorna uma lista de forma decrescente
        numeros.OrderBy(x => x); // retorna uma lista de forma crescente
    }
    static void ExerciciosData()
    {
        var dataEHoraAtual = DateTime.Now;
        var dataEHoraDois = DateTime.Now.AddDays(1);
        var dataEHoraTres = DateTime.Now.AddMonths(1);
        var dataDeNascimento = DateTime.Parse("19/11/2001");
        var dateTimeEmString = dataDeNascimento.ToString("dd/MM/yy hh:mm.ss");
        Console.WriteLine($"Você nasceu no dia {dataDeNascimento.Day} do mês {dataDeNascimento.Month} do {dataDeNascimento.DayOfYear} dia do ano");
        //TimeSpan é utilizado para identificar diferença de datas
        var diferença = dataEHoraAtual.Subtract(dataEHoraTres);
        Console.WriteLine(diferença.Days);
    }
}


