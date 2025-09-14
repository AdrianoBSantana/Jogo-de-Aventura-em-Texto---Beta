using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // --- CRIAÇÃO DO MUNDO (sem alterações) ---
        var salaInicial = new Sala("Entrada da Caverna", "Você está na entrada escura de uma caverna. O ar é úmido e cheira a mofo.");
        var corredor = new Sala("Corredor Estreito", "Um corredor de pedra. Há uma poça d'água no chão e sons estranhos ecoam à frente.");
        var tesouroSala = new Sala("Câmara do Tesouro", "Uma sala brilhante com um baú de madeira reforçado no centro! Parece que você encontrou!");

        salaInicial.AdicionarSaida("norte", corredor);
        corredor.AdicionarSaida("sul", salaInicial);
        corredor.AdicionarSaida("leste", tesouroSala);
        tesouroSala.AdicionarSaida("oeste", corredor);

        var espada = new Item("Espada", "Uma espada de ferro, um pouco enferrujada mas ainda afiada.");
        var chave = new Item("Chave", "Uma chave de bronze pequena e antiga. Deve abrir algo importante.");
        var goblin = new Inimigo("Goblin", 20, 5);

        salaInicial.Itens.Add(espada);
        corredor.Inimigo = goblin;
        tesouroSala.Itens.Add(chave);

        var jogador = new Jogador("Herói", 100, 10);
        var salaAtual = salaInicial;
        bool gameOver = false;

        // --- MELHORIA: MENSAGEM DE BOAS-VINDAS E OBJETIVO ---
        Console.WriteLine("==============================================");
        Console.WriteLine("Bem-vindo à Caverna do Desafio!");
        Console.WriteLine("Seu objetivo: Encontrar a Câmara do Tesouro e pegar a Chave antiga.");
        Console.WriteLine("Digite 'ajuda' a qualquer momento para ver os comandos disponíveis.");
        Console.WriteLine("==============================================");
        
        // --- LOOP PRINCIPAL DO JOGO (GAME LOOP) ---
        while (!gameOver)
        {
            Console.WriteLine(); 
            
            // --- MELHORIA: EXIBIR STATUS DO JOGADOR ---
            Console.WriteLine($"[Sua Vida: {jogador.Vida} HP]");
            salaAtual.Descrever();
            
            Console.Write("> ");
            string? input = Console.ReadLine()?.ToLower(); 

            if (string.IsNullOrEmpty(input))
            {
                continue;
            }

            string[] comando = input.Split(' ');
            string acao = comando[0];

            switch (acao)
            {
                // --- MELHORIA: COMANDO 'AJUDA' ---
                case "ajuda":
                    Console.WriteLine("--- Comandos Disponíveis ---");
                    Console.WriteLine("ir <direção>   - Move para a sala na direção (ex: ir norte)");
                    Console.WriteLine("pegar <item>     - Pega um item da sala (ex: pegar espada)");
                    Console.WriteLine("inventario     - Mostra os itens que você está carregando");
                    Console.WriteLine("atacar         - Ataca o inimigo na sala");
                    Console.WriteLine("ajuda          - Mostra esta lista de comandos");
                    Console.WriteLine("sair           - Encerra o jogo");
                    Console.WriteLine("--------------------------");
                    break;

                case "ir":
                    if (comando.Length > 1)
                    {
                        string direcao = comando[1];
                        if (salaAtual.Saidas.ContainsKey(direcao))
                        {
                            salaAtual = salaAtual.Saidas[direcao];
                        }
                        else
                        {
                            Console.WriteLine("Você não pode ir por aí.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ir para onde? (Ex: ir norte)");
                    }
                    break;

                case "pegar":
                    if (comando.Length > 1)
                    {
                        string nomeItem = comando[1];
                        Item? itemParaPegar = salaAtual.Itens.FirstOrDefault(i => i.Nome.ToLower() == nomeItem);

                        if (itemParaPegar != null)
                        {
                            jogador.PegarItem(itemParaPegar);
                            salaAtual.Itens.Remove(itemParaPegar);
                        }
                        else
                        {
                            Console.WriteLine("Esse item não está aqui.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pegar o quê? (Ex: pegar espada)");
                    }
                    break;

                case "inventario":
                    jogador.MostrarInventario();
                    break;

                case "atacar":
                    if (salaAtual.Inimigo != null && salaAtual.Inimigo.EstaVivo())
                    {
                        jogador.Atacar(salaAtual.Inimigo);
                        if (salaAtual.Inimigo.EstaVivo())
                        {
                            salaAtual.Inimigo.Atacar(jogador);
                            if (!jogador.EstaVivo())
                            {
                                Console.WriteLine("Você foi derrotado... GAME OVER.");
                                gameOver = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não há ninguém para atacar aqui.");
                    }
                    break;

                case "sair":
                    Console.WriteLine("Obrigado por jogar!");
                    gameOver = true;
                    break;

                default:
                    Console.WriteLine("Comando desconhecido. Digite 'ajuda' para ver as opções.");
                    break;
            }
        }
    }
}