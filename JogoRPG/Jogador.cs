using System.Collections.Generic; // Necessário para usar List

public class Jogador : Personagem // Sintaxe de herança
{
    public List<Item> Inventario { get; set; }

    // O construtor chama o construtor da classe base (Personagem)
    public Jogador(string nome, int vida, int ataque) : base(nome, vida, ataque)
    {
        Inventario = new List<Item>();
    }

    public void PegarItem(Item item)
    {
        Inventario.Add(item);
        Console.WriteLine($"{Nome} pegou {item.Nome}.");
    }

    public void MostrarInventario()
    {
        if (Inventario.Count == 0)
        {
            Console.WriteLine("O inventário está vazio.");
        }
        else
        {
            Console.WriteLine("Inventário:");
            foreach (var item in Inventario)
            {
                Console.WriteLine($"- {item.Nome}");
            }
        }
    }
}