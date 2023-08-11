

using MMOCS;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {

        Mago Bia = new Mago();
        Bia.Nome = "Beatrice";
        Bia.Nivel = 2;
        Bia.QI = 75;
        Bia.Agilidade = 50;
        Bia.Vida = 100;
        Bia.Raca = "Humana";
        Bia.Forca = 70;
        Bia.Defesa = 40;

        Cavaleiro At = new Cavaleiro();
        At.Nome = "Atena";
        At.Nivel = 2;
        At.QI = 30;
        At.Agilidade = 50;
        At.Vida = 150;
        At.Raca = "Humana";
        At.Forca = 65;
        At.Defesa = 40;

        Anao An = new Anao();
        An.Nome = "Jiorge";
        An.Nivel = 2;
        An.QI = 20;
        An.Agilidade = 25;
        An.Vida = 175;
        An.Raca = "Anao";
        An.Forca = 60;
        An.Defesa = 90;

        Elfo El = new Elfo();
        El.Nome = "Jambo";
        El.Nivel = 4;
        El.QI = 90;
        El.Agilidade = 80;
        El.Vida = 55;
        El.Raca = "Elfo";
        El.Forca = 30;
        El.Defesa = 35;

        Console.WriteLine("Bem vindos a Maden Fight! a arena onde sai apenas um campeão");
        Console.WriteLine("Selecione seu jogador:");
        Console.WriteLine("1 - Cavaleiro\n2 - Mago\n3 - Elfo\n4 - Anão");
        int escolhaJogador = int.Parse(Console.ReadLine());
        Personagem jogador = null;
        switch (escolhaJogador)
        {
            case 1:
                jogador = At;
                break;
            case 2:
                jogador = Bia;
                break;
            case 3:
                jogador = El;
                break;
            case 4:
                jogador = An;
                break;
            default:
                Console.WriteLine("Faça uma escolha válida!");
                break;
        }
        jogador.apresentar();
        Console.WriteLine("---------|#|---------");
        Console.WriteLine("Selecione seu inimigo:");
        Console.WriteLine("1 - Cavaleiro\n2 - Mago\n3 - Elfo\n4 - Anão");
        int escolhaInimigo = int.Parse(Console.ReadLine());
        Personagem inimigo = null;
        switch (escolhaInimigo)
        {
            case 1:
                inimigo = At;
                break;
            case 2:
                inimigo = Bia;
                break;
            case 3:
                inimigo = El;
                break;
            case 4:
                inimigo = An;
                break;
            default:
                Console.WriteLine("Faça uma escolha válida!");
                break;
        }
        inimigo.apresentar();
        if (escolhaJogador == escolhaInimigo)
        {
            Console.WriteLine("Você não pode lutar contra si mesmo!");
        }
        Console.WriteLine("---------|#|---------");
        Console.WriteLine($"A luta ficou entre {jogador.Nome} o(a) {jogador.Raca} e {inimigo.Nome} o(a) {inimigo.Raca}");

        while (true)
        {
            Console.WriteLine("Selecione a ação:");
            Console.WriteLine("1 - Usar Poção de Cura\n2 - Atacar\n3 - Sair");
            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                jogador.regenerarVida();
                inimigo.atacar(jogador);
                Console.WriteLine($"{inimigo.Nome} te atacou e você ficou com {jogador.Vida} de vida");
            }
            else if (escolha == 2)
            {
                jogador.atacar(inimigo);
                Console.WriteLine($"Seu inimigo ficou com:{inimigo.Vida} de vida!");
                Console.WriteLine($"Seu inimigo contra atacou!");
                inimigo.atacar(jogador);
                Console.WriteLine($"{inimigo.Nome} te atacou e você ficou com {jogador.Vida} de vida");

                if (inimigo.Vida <= 0)
                {
                    Console.WriteLine("Você derrotou seu Inimigo");
                    jogador.subirNivel();
                    break;
                }
                if(jogador.Vida <= 0)
                {
                    Console.WriteLine("Você foi derrotado tente novamente!");
                    break;
                }
            }
            else if (escolha == 3)
            {
                break;
            }
        }








    }
}