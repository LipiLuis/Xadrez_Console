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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(6, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(4, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 1));

                Tela.ImprimirTabuleiro(tab);

            }
            catch(TabuleiroException x)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
