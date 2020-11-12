

using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int tuno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            tuno = 1;
            jogadorAtual = Cor.Branca;
            ColocarPecas();
        }

        public void ExecultaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarQtdMovimento();
            Peca pecaCapturada = tab.RetirarPeca(destino);
            terminada = false;
            tab.ColocarPeca(p, destino);
        }
        private void ColocarPecas()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c',1).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c',2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d',2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e',2).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e',1).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d',1).toPosicao());    
            
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c',7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c',8).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d',7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e',7).toPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e',8).toPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d',8).toPosicao());


        }
    }
}
