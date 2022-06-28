using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Logica;

namespace TIC_TAC_TOE
{
    public partial class F_Jogo : Form
    {
        /// <summary>
        /// Armazena os botões que fazem parte dos Quadrados do jogo.
        /// </summary>
        private Button[] quadrados;

        /// <summary>
        /// Armazena o caracter 'X' ou 'O' para controlar os turnos dos jogadores.
        /// </summary>
        private char simbJogAtual;

        /// <summary>
        /// Dificuldade atual do jogo.
        /// </summary>
        private Dificuldade dificAtual;

        /// <summary>
        /// Modo de jogo atual.
        /// </summary>
        private ModoDeJogo modoAtual;

        public F_Jogo()
        {
            InitializeComponent();

            Cbx_Modo.SelectedIndex = 0;
            Cbx_Dific.SelectedIndex = 1;

            quadrados = new Button[] { Btn_Q0, Btn_Q1, Btn_Q2, Btn_Q3, Btn_Q4, Btn_Q5, Btn_Q6, Btn_Q7, Btn_Q8 };

            ComecarPartida();
        }

        /// <summary>
        /// Começa um novo jogo com as definições atuais.
        /// </summary>
        private void ComecarPartida()
        {
            if (Cbx_Modo.SelectedIndex == 0)
                modoAtual = ModoDeJogo.JvsJ;
            else
                modoAtual = ModoDeJogo.JvsC;

            if (Cbx_Dific.SelectedIndex == 0)
                dificAtual = Dificuldade.Facil;
            else if (Cbx_Dific.SelectedIndex == 1)
                dificAtual = Dificuldade.Medio;
            else
                dificAtual = Dificuldade.Dificil;

            simbJogAtual = 'X';

            foreach (var i in quadrados)
                i.Image = null;
        }

        private void ReiniciarJogo(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja reiniciar a partida?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                ComecarPartida();
        }

        /// <summary>
        /// Método usado em todos os quadrados do jogo para mudar as imagens dos botões conforme o jogador atual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsuarioJogou(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            botao.Image = simbJogAtual == 'X' ? Properties.Resources.X_Jogo : Properties.Resources.O_Jogo;

            if (modoAtual == ModoDeJogo.JvsJ)
                simbJogAtual = simbJogAtual == 'X' ? 'O' : 'X';
            else
            {

            }
        }

        private void IrNoPerfil(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Paulo-Henrique-Silva");
        }

        private void IrNoPlanejamento(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("");
        }
    }
}
