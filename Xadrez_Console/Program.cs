using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                ;
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");

                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partida.ExecultaMovimento(origem, destino);

                }
                Tela.ImprimirTabuleiro(partida.tab);

            }
            catch (TabuleiroException x)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
