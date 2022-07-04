using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Logica
{
    /// <summary>
    /// Classe que cria a IA do jogo no modo JvsC.
    /// </summary>
    public class Computador
    {
        private readonly Dificuldade dificIa;

        public Computador(Dificuldade dificJogo)
        {
            dificIa = dificJogo;
        }

        /// <summary>
        /// Conforme a dificuldade, a Ia jogará no grid conforme as jogadas possíveis.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>Retorna o número do quadrado escolhido pelo computador. Caso não tenha sido possível escolher, retorna -1.</returns>
        public int Jogar(Grid grid)
        {
            int quad;

            switch (dificIa)
            {
                case Dificuldade.Facil:
                    if ((quad = EscolheUmBomQuadrado(grid, 'X')) != -1)
                        return quad;

                    return EscolheAleatorio(grid);

                case Dificuldade.Medio:
                    if ((quad = EscolheUmBomQuadrado(grid, 'O')) != -1)
                        return quad;

                    if ((quad = EscolheUmBomQuadrado(grid, 'X')) != -1)
                        return quad;

                    return EscolheAleatorio(grid);

                case Dificuldade.Dificil:
                    if ((quad = EscolheUmBomQuadrado(grid, 'O')) != -1)
                        return quad;

                    if ((quad = EscolheUmBomQuadrado(grid, 'X')) != -1)
                        return quad;

                    if ((quad = TentaEstrategia(grid)) != -1)
                        return quad;

                    return EscolheAleatorio(grid);
            }

            return -1;
        }

        /// <summary>
        /// Checa o grid do jogo para tentar completar ou bloquear uma sequência específica.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="simbJog"></param>
        /// <returns>Retorna o número do quadrado, 0 a 8, que deve ser usado para completar uma sequência. Se não for possível completar, retornará -1 </returns>
        private int EscolheUmBomQuadrado(Grid grid, char simbJog)
        {
            char[] simbQuad = new char[9];

            for (int i = 0; i < 9; i++)
                simbQuad[i] = (char)grid.Quadrados[i].Tag;

            //Checa as linhas
            for (int i = 0; i < 9; i += 3)
            {
                if (simbQuad[i] == '\0' && simbQuad[i + 1] == simbJog && simbQuad[i + 2] == simbJog)
                    return i;
                if (simbQuad[i] == simbJog && simbQuad[i + 1] == '\0' && simbQuad[i + 2] == simbJog)
                    return i + 1;
                if (simbQuad[i] == simbJog && simbQuad[i + 1] == simbJog && simbQuad[i + 2] == '\0')
                    return i + 2;
            }

            //Checa as colunas
            for (int i = 0; i < 3; i++)
            {
                if (simbQuad[i] == '\0' && simbQuad[i + 3] == simbJog && simbQuad[i + 6] == simbJog)
                    return i;
                if (simbQuad[i] == simbJog && simbQuad[i + 3] == '\0' && simbQuad[i + 6] == simbJog)
                    return i + 3;
                if (simbQuad[i] == simbJog && simbQuad[i + 3] == simbJog && simbQuad[i + 6] == '\0')
                    return i + 6;
            }

            //Checa a diagonal principal
            if (simbQuad[0] == '\0' && simbQuad[4] == simbJog && simbQuad[8] == simbJog)
                return 0;
            if (simbQuad[0] == simbJog && simbQuad[4] == '\0' && simbQuad[8] == simbJog)
                return 4;
            if (simbQuad[0] == simbJog && simbQuad[4] == simbJog && simbQuad[8] == '\0')
                return 8;

            //checa a diagonal secundária
            if (simbQuad[2] == '\0' && simbQuad[4] == simbJog && simbQuad[6] == simbJog)
                return 2;
            if (simbQuad[2] == simbJog && simbQuad[4] == '\0' && simbQuad[6] == simbJog)
                return 4;
            if (simbQuad[2] == simbJog && simbQuad[4] == simbJog && simbQuad[6] == '\0')
                return 6;

            return -1;
        }

        /// <summary>
        /// O computador tenta jogar conforme a melhor estratégia existente em tic-tac-toe.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>Retorna o número do quadrado, 0 a 8, para concretizar a estratégia. Se não for possível, retornará -1</returns>
        private int TentaEstrategia(Grid grid)
        {
            //A estratégia consiste em priorizar os cantos ao máximo.
            //Contudo caso o advérsio obtenha algum canto, a prioridade deve ser obter o centro.

            char[] simbQuad = new char[9];

            for (int i = 0; i < 9; i++)
                simbQuad[i] = (char)grid.Quadrados[i].Tag;

            if ((simbQuad[0] == 'X' || simbQuad[2] == 'X' || simbQuad[6] == 'X' || simbQuad[8] == 'X') && simbQuad[4] == '\0')
                return 4;

            if (simbQuad[0] == '\0' || simbQuad[2] == '\0' || simbQuad[6] == '\0' || simbQuad[8] == '\0')
            {
                int quadCanto = 0;

                do
                {
                    switch (new Random().Next(1, 5))
                    {
                        case 1:
                            quadCanto = 0;
                            break;

                        case 2:
                            quadCanto = 2;
                            break;

                        case 3:
                            quadCanto = 6;
                            break;

                        case 4:
                            quadCanto = 8;
                            break;
                    }
                }
                while (simbQuad[quadCanto] != '\0');

                return quadCanto;
            }

            return -1;
        }

        private int EscolheAleatorio(Grid grid)
        {
            Random rand = new Random();
            int quad;

            while (grid.Quadrados[quad = rand.Next(0, 9)].Image != null);

            return quad;
        }
    }
}
