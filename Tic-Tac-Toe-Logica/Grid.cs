using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tic_Tac_Toe_Logica
{
    /// <summary>
    /// Classe usada para criar um grid ao jogo da velha
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// Coleção de "Quadrados" (botões) que compoem o grid do jogo.
        /// </summary>
        public Button[] Quadrados { get; }

        public Grid(params Button[] quadradosDoJogo)
        {
            Quadrados = quadradosDoJogo;
        }

        /// <summary>
        /// Retorna se é vitória do jogador especificado, conforme a imagem.
        /// </summary>
        /// <param name="simbJog"> Imagem do jogador a checar.</param>
        /// <returns></returns>
        public bool EVitoria(char simbJog)
        {
            //Para verificar o conteúdo dos quadrados, é usado a propriedade "Tag" com o char 'X' ou 'O'
            char[] simbQuad = new char[9]; //armazena a tag (simbolos) dos quadrados.

            for (int i = 0; i < 9; i++)
                simbQuad[i] = (char)Quadrados[i].Tag;

            //Checa as linhas
            for (int i = 0; i < 9; i += 3)
            {
                if (simbQuad[i] == simbJog && simbQuad[i + 1] == simbJog && simbQuad[i + 2] == simbJog)
                    return true;
            }

            //Checa as colunas
            for (int i = 0; i < 3; i++)
            {
                if (simbQuad[i] == simbJog && simbQuad[i + 3] == simbJog && simbQuad[i + 6] == simbJog)
                    return true;
            }

            //Checa a diagonal principal
            if (simbQuad[0] == simbJog && simbQuad[4] == simbJog && simbQuad[8] == simbJog)
                return true;

            //Checa a diagonal secundária
            if (simbQuad[2] == simbJog && simbQuad[4] == simbJog && simbQuad[6] == simbJog)
                return true;

            return false;
        }

        /// <summary>
        /// Retorna se houve um empate no grid do jogo.
        /// </summary>
        /// <returns></returns>
        public bool EEmpate()
        {
            //Caso haje pelo menos um quadrado vazio, significa que ainda não é empate.
            foreach (var i in Quadrados)
            {
                if (i.Image == null) 
                    return false;
            }

            return true;
        }
    }
}
