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
        /// Armazena 'X' ou 'O' para controlar os turnos dos jogadores.
        /// </summary>
        private char simbJogAtual;

        /// <summary>
        /// Dificuldade atual do jogo.
        /// </summary>
        private Dificuldade dificAtual;

        /// <summary>
        /// Grid do jogo atual, onde armazenado e verificado o estado do jogo.
        /// </summary>
        private Grid gridAtual;

        /// <summary>
        /// Modo de jogo atual.
        /// </summary>
        private ModoDeJogo modoAtual;

        public F_Jogo()
        {
            InitializeComponent();

            Cbx_Modo.SelectedIndex = 0;
            Cbx_Dific.SelectedIndex = 1;
        }

        /// <summary>
        /// Começa um novo jogo com as definições atuais.
        /// </summary>
        private void ComecarPartida()
        {
            if (Cbx_Modo.SelectedIndex == 0)
            {
                modoAtual = ModoDeJogo.JvsJ;

                Lbl_Dific.Visible = false;
                Cbx_Dific.Visible = false;
            }
            else
            {
                modoAtual = ModoDeJogo.JvsC;

                Lbl_Dific.Visible = true;
                Cbx_Dific.Visible = true;
            }

            if (Cbx_Dific.SelectedIndex == 0)
                dificAtual = Dificuldade.Facil;
            else if (Cbx_Dific.SelectedIndex == 1)
                dificAtual = Dificuldade.Medio;
            else
                dificAtual = Dificuldade.Dificil;

            simbJogAtual = 'X';

            gridAtual = new Grid(Btn_Q0, Btn_Q1, Btn_Q2, Btn_Q3, Btn_Q4, Btn_Q5, Btn_Q6, Btn_Q7, Btn_Q8);

            foreach (var i in gridAtual.Quadrados)
            {
                i.Image = null;
                i.Enabled = true;
                i.Tag = '\0';
            }
        }

        private void ReiniciarJogo(object sender, EventArgs e)
        {
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

            //muda a imagem do botão conforme o usuário que jogou.
            botao.Tag = simbJogAtual;
            botao.Image = simbJogAtual == 'X' ? Properties.Resources.X_Jogo : Properties.Resources.O_Jogo;

            //Checa os cenários de fim de jogo para o jogador que acabou de jogar
            if (gridAtual.EVitoria(simbJogAtual))
                EncerrarPartida(simbJogAtual);
            else if (gridAtual.EEmpate())
                EncerrarPartida('\0');

            if (modoAtual == ModoDeJogo.JvsJ)
            {
                simbJogAtual = simbJogAtual == 'X' ? 'O' : 'X';
            }
            else
            {

            }
        }

        /// <summary>
        /// Método ativado caso o jogador mude o modo de jogo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MudarModo(object sender, EventArgs e)
        {
            Lbl_PlacarX.Text = "0";
            Lbl_PlacarO.Text = "0";
            ComecarPartida();
        }
        
        /// <summary>
        /// Método ativado caso o jogador mude a dificuldade da IA.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MudarDificuldade(object sender, EventArgs e)
        {
            Lbl_PlacarX.Text = "0";
            Lbl_PlacarO.Text = "0";
            ComecarPartida();
        }

        /// <summary>
        /// Encerra a partida e determina o ganhador, caso haja.
        /// </summary>
        /// <param name="jogVencedor">Jogador que venceu a partida. Caso o valor seja nulo, será considerado como empate.</param>
        private void EncerrarPartida(char jogVencedor)
        {
            foreach (var i in gridAtual.Quadrados)
                i.Enabled = false;

            if (jogVencedor == 'X')
            {
                MessageBox.Show("Jogador X venceu!");
                Lbl_PlacarX.Text = (int.Parse(Lbl_PlacarX.Text) + 1).ToString();
            }
            else if (jogVencedor == 'O')
            {
                MessageBox.Show("Jogador O venceu!");
                Lbl_PlacarO.Text = (int.Parse(Lbl_PlacarX.Text) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Empate!");
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
