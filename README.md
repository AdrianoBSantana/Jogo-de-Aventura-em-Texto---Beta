# Jogo de Aventura em Texto (RPG de Console)

![Linguagem](https://img.shields.io/badge/Linguagem-C%23-blueviolet) ![Plataforma](https://img.shields.io/badge/Plataforma-.NET-blue) ![Status](https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow)

> Um clássico jogo de aventura e RPG baseado em texto, rodando diretamente no console. Este projeto foi desenvolvido como um exercício prático para solidificar conceitos de Programação Orientada a Objetos (OOP) com C#.

---

### 🎮 Sobre o Jogo

Neste jogo, você é um herói explorando uma caverna perigosa. Seu objetivo é navegar por diferentes salas, encontrar itens úteis, enfrentar inimigos e, finalmente, localizar o tesouro escondido. Todas as interações acontecem através de comandos de texto simples, como `ir norte`, `pegar espada` e `atacar`.

### 📸 Screenshot


<img width="559" height="219" alt="image" src="https://github.com/user-attachments/assets/292dcc2f-0982-4c7a-bc04-6a263664990c" />

---

### ✨ Features

* **Exploração de Ambientes:** Navegue entre salas interconectadas usando comandos direcionais.
* **Interação com Itens:** Pegue e guarde itens em um inventário pessoal.
* **Sistema de Combate:** Lute contra inimigos em um sistema de combate baseado em turnos.
* **Interface Intuitiva:** Um sistema de ajuda integrado (`ajuda`) e descrições claras para guiar o jogador.
* **Feedback Constante:** O status do jogador (HP) é exibido a cada turno.

---

### 🛠️ Tecnologias Utilizadas

* **[C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)**: Linguagem de programação principal.
* **[.NET](https://dotnet.microsoft.com/)**: Plataforma de desenvolvimento utilizada para criar a aplicação de console.

---

### 🚀 Como Rodar o Projeto

Para rodar este projeto localmente, siga os passos abaixo.

**Pré-requisitos:**

* Ter o [SDK do .NET](https://dotnet.microsoft.com/download) instalado em sua máquina.

**Passos:**

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/](https://github.com/)[SEU-USUARIO]/[NOME-DO-SEU-REPOSITORIO].git
    ```

2.  **Navegue para a pasta do projeto:**
    ```bash
    cd JogoRPG
    ```

3.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```
    O jogo iniciará no seu terminal. Divirta-se!

---

### 🏛️ Estrutura do Projeto

O projeto foi estruturado utilizando princípios de **Programação Orientada a Objetos** para garantir um código limpo, modular e de fácil expansão. As principais classes são:

* `Personagem`: Classe base que define atributos comuns como `Nome`, `Vida` e `Ataque`.
* `Jogador`: Herda de `Personagem` e adiciona funcionalidades específicas, como o `Inventario`.
* `Inimigo`: Herda de `Personagem` e representa os monstros do jogo.
* `Item`: Representa os objetos que podem ser encontrados e coletados.
* `Sala`: Define os locais do mapa, contendo descrições, itens, inimigos e as saídas para outras salas.
* `Program`: Classe principal que contém o "motor do jogo" (game loop) e controla todo o fluxo da aplicação.

---

### 🌱 Futuras Melhorias

Este projeto é uma base que pode ser expandida de várias maneiras:

- [ ] Implementar um sistema para salvar e carregar o progresso do jogo.
- [ ] Adicionar mais tipos de itens (poções de cura, armaduras).
- [ ] Criar quebra-cabeças (ex: uma porta que só abre com uma chave específica).
- [ ] Adicionar NPCs (personagens não-jogáveis) com diálogos.
- [ ] Desenvolver um sistema de atributos mais complexo (Força, Defesa, Agilidade).

