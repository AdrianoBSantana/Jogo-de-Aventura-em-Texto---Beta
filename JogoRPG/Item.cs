public class Item
{
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public Item(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }
}