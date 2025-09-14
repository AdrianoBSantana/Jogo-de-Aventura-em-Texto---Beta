public class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }

    public Personagem(string nome, int vida, int ataque)
    {
        Nome = nome;
        Vida = vida;
        Ataque = ataque;
    }

    public bool EstaVivo()
    {
        return Vida > 0;
    }

    public virtual void Atacar(Personagem alvo)
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome}!");
        alvo.Vida -= Ataque;
        if (!alvo.EstaVivo())
        {
            Console.WriteLine($"{alvo.Nome} foi derrotado!");
        }
    }
}