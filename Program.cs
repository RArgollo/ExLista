namespace ExLista;
public class Program
{
    static void Main(string[] args)
    {
        var numeros = new List<int>();
        var numerosMaisDoze = new List<int>();
        var strings = new List<string>();
        for (var contador = 0; contador < 10; contador++)
        {
            //Adicionar um valor dentro da lista
            numeros.Add(contador+2);
            numerosMaisDoze.Add(contador + 12);
            strings.Add(contador.ToString());
        }
        //Adicinar uma lista dentro de outra
        numeros.AddRange(numerosMaisDoze);
        //Remover Item
        numeros.Remove(5);
        numeros.RemoveAt(2);
    }
}