using System.Collections.Generic;

public class Sala
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public Dictionary<string, Sala> Saidas { get; set; }
    public List<Item> Itens { get; set; }
    public Inimigo? Inimigo { get; set; } // O '?' permite que o inimigo seja nulo (null)

    public Sala(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
        Saidas = new Dictionary<string, Sala>();
        Itens = new List<Item>();
        Inimigo = null; // Começa sem inimigo
    }

    public void AdicionarSaida(string direcao, Sala salaDestino)
    {
        Saidas[direcao] = salaDestino;
    }

  // Dentro da classe Sala, em Sala.cs

public void Descrever()
{
    Console.WriteLine($"--- {Nome} ---");
    Console.WriteLine(Descricao);

    // MELHORIA: Listar os itens na sala de forma mais claraS
    if (Itens.Count > 0)
    {
        Console.WriteLine("Você vê os seguintes itens: " + string.Join(", ", Itens.Select(i => i.Nome)));
    }

    // MELHORIA: Informar sobre o inimigo
    if (Inimigo != null && Inimigo.EstaVivo())
    {
        Console.WriteLine($"Cuidado! Um {Inimigo.Nome} hostil está aqui!");
    }

    // MELHORIA: Mostrar claramente as saídas disponíveis
    if (Saidas.Count > 0)
    {
        Console.WriteLine("Saídas disponíveis: " + string.Join(", ", Saidas.Keys));
    }
    else
    {
        Console.WriteLine("Não há saídas visíveis daqui.");
    }
}
}