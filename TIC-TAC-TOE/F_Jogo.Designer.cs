namespace TIC_TAC_TOE
{
    partial class F_Jogo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Jogo));
            this.Lbl_ModoDeJogo = new System.Windows.Forms.Label();
            this.Cbx_Modo = new System.Windows.Forms.ComboBox();
            this.Cbx_Dific = new System.Windows.Forms.ComboBox();
            this.Lbl_Dific = new System.Windows.Forms.Label();
            this.Lbl_Placar = new System.Windows.Forms.Label();
            this.Pbx_PlacarX = new System.Windows.Forms.PictureBox();
            this.Pbx_PlacarO = new System.Windows.Forms.PictureBox();
            this.Lbl_PlacarX = new System.Windows.Forms.Label();
            this.Lbl_PlacarO = new System.Windows.Forms.Label();
            this.Pbx_Grid = new System.Windows.Forms.PictureBox();
            this.Btn_Q4 = new System.Windows.Forms.Button();
            this.Btn_Q0 = new System.Windows.Forms.Button();
            this.Btn_Q5 = new System.Windows.Forms.Button();
            this.Btn_Q2 = new System.Windows.Forms.Button();
            this.Btn_Q3 = new System.Windows.Forms.Button();
            this.Btn_Q6 = new System.Windows.Forms.Button();
            this.Btn_Q7 = new System.Windows.Forms.Button();
            this.Btn_Q1 = new System.Windows.Forms.Button();
            this.Btn_Q8 = new System.Windows.Forms.Button();
            this.Llb_Perfil = new System.Windows.Forms.LinkLabel();
            this.Llb_Planejamento = new System.Windows.Forms.LinkLabel();
            this.Lbl_Turno = new System.Windows.Forms.Label();
            this.Pbx_Resultado = new System.Windows.Forms.PictureBox();
            this.Btn_Ok = new TIC_TAC_TOE.Controles.CustomButton();
            this.Btn_Reiniciar = new TIC_TAC_TOE.Controles.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_PlacarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_PlacarO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ModoDeJogo
            // 
            this.Lbl_ModoDeJogo.AutoSize = true;
            this.Lbl_ModoDeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ModoDeJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Lbl_ModoDeJogo.Location = new System.Drawing.Point(19, 28);
            this.Lbl_ModoDeJogo.Name = "Lbl_ModoDeJogo";
            this.Lbl_ModoDeJogo.Size = new System.Drawing.Size(210, 33);
            this.Lbl_ModoDeJogo.TabIndex = 0;
            this.Lbl_ModoDeJogo.Text = "Modo de Jogo";
            this.Lbl_ModoDeJogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cbx_Modo
            // 
            this.Cbx_Modo.BackColor = System.Drawing.Color.White;
            this.Cbx_Modo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Modo.DropDownWidth = 210;
            this.Cbx_Modo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbx_Modo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Modo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.Cbx_Modo.FormattingEnabled = true;
            this.Cbx_Modo.Items.AddRange(new object[] {
            "Jogador Vs Jogador",
            "Jogador Vs Computador"});
            this.Cbx_Modo.Location = new System.Drawing.Point(235, 28);
            this.Cbx_Modo.Name = "Cbx_Modo";
            this.Cbx_Modo.Size = new System.Drawing.Size(210, 32);
            this.Cbx_Modo.TabIndex = 0;
            this.Cbx_Modo.SelectedIndexChanged += new System.EventHandler(this.MudarModo);
            // 
            // Cbx_Dific
            // 
            this.Cbx_Dific.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_Dific.BackColor = System.Drawing.Color.White;
            this.Cbx_Dific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Dific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbx_Dific.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_Dific.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.Cbx_Dific.FormattingEnabled = true;
            this.Cbx_Dific.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Difícil"});
            this.Cbx_Dific.Location = new System.Drawing.Point(716, 29);
            this.Cbx_Dific.Name = "Cbx_Dific";
            this.Cbx_Dific.Size = new System.Drawing.Size(210, 32);
            this.Cbx_Dific.TabIndex = 1;
            this.Cbx_Dific.Visible = false;
            this.Cbx_Dific.SelectedIndexChanged += new System.EventHandler(this.MudarDificuldade);
            // 
            // Lbl_Dific
            // 
            this.Lbl_Dific.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Dific.AutoSize = true;
            this.Lbl_Dific.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dific.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Lbl_Dific.Location = new System.Drawing.Point(539, 29);
            this.Lbl_Dific.Name = "Lbl_Dific";
            this.Lbl_Dific.Size = new System.Drawing.Size(171, 33);
            this.Lbl_Dific.TabIndex = 2;
            this.Lbl_Dific.Text = "Dificuldade";
            this.Lbl_Dific.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Dific.Visible = false;
            // 
            // Lbl_Placar
            // 
            this.Lbl_Placar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Placar.AutoSize = true;
            this.Lbl_Placar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Placar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Lbl_Placar.Location = new System.Drawing.Point(1007, 27);
            this.Lbl_Placar.Name = "Lbl_Placar";
            this.Lbl_Placar.Size = new System.Drawing.Size(104, 33);
            this.Lbl_Placar.TabIndex = 4;
            this.Lbl_Placar.Text = "Placar";
            this.Lbl_Placar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pbx_PlacarX
            // 
            this.Pbx_PlacarX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_PlacarX.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_PlacarX.Image")));
            this.Pbx_PlacarX.Location = new System.Drawing.Point(1129, 26);
            this.Pbx_PlacarX.Name = "Pbx_PlacarX";
            this.Pbx_PlacarX.Size = new System.Drawing.Size(36, 36);
            this.Pbx_PlacarX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pbx_PlacarX.TabIndex = 5;
            this.Pbx_PlacarX.TabStop = false;
            // 
            // Pbx_PlacarO
            // 
            this.Pbx_PlacarO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_PlacarO.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_PlacarO.Image")));
            this.Pbx_PlacarO.Location = new System.Drawing.Point(1235, 27);
            this.Pbx_PlacarO.Name = "Pbx_PlacarO";
            this.Pbx_PlacarO.Size = new System.Drawing.Size(35, 35);
            this.Pbx_PlacarO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pbx_PlacarO.TabIndex = 6;
            this.Pbx_PlacarO.TabStop = false;
            // 
            // Lbl_PlacarX
            // 
            this.Lbl_PlacarX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PlacarX.AutoSize = true;
            this.Lbl_PlacarX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PlacarX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Lbl_PlacarX.Location = new System.Drawing.Point(1180, 29);
            this.Lbl_PlacarX.Name = "Lbl_PlacarX";
            this.Lbl_PlacarX.Size = new System.Drawing.Size(32, 33);
            this.Lbl_PlacarX.TabIndex = 7;
            this.Lbl_PlacarX.Text = "0";
            this.Lbl_PlacarX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_PlacarO
            // 
            this.Lbl_PlacarO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_PlacarO.AutoSize = true;
            this.Lbl_PlacarO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PlacarO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Lbl_PlacarO.Location = new System.Drawing.Point(1277, 29);
            this.Lbl_PlacarO.Name = "Lbl_PlacarO";
            this.Lbl_PlacarO.Size = new System.Drawing.Size(32, 33);
            this.Lbl_PlacarO.TabIndex = 8;
            this.Lbl_PlacarO.Text = "0";
            this.Lbl_PlacarO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pbx_Grid
            // 
            this.Pbx_Grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pbx_Grid.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Grid.Image")));
            this.Pbx_Grid.Location = new System.Drawing.Point(345, 102);
            this.Pbx_Grid.Name = "Pbx_Grid";
            this.Pbx_Grid.Size = new System.Drawing.Size(694, 540);
            this.Pbx_Grid.TabIndex = 9;
            this.Pbx_Grid.TabStop = false;
            // 
            // Btn_Q4
            // 
            this.Btn_Q4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q4.BackColor = System.Drawing.Color.White;
            this.Btn_Q4.FlatAppearance.BorderSize = 0;
            this.Btn_Q4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q4.Location = new System.Drawing.Point(598, 290);
            this.Btn_Q4.Name = "Btn_Q4";
            this.Btn_Q4.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q4.TabIndex = 6;
            this.Btn_Q4.Tag = "";
            this.Btn_Q4.UseVisualStyleBackColor = false;
            this.Btn_Q4.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q0
            // 
            this.Btn_Q0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q0.BackColor = System.Drawing.Color.White;
            this.Btn_Q0.FlatAppearance.BorderSize = 0;
            this.Btn_Q0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q0.Location = new System.Drawing.Point(415, 130);
            this.Btn_Q0.Name = "Btn_Q0";
            this.Btn_Q0.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q0.TabIndex = 2;
            this.Btn_Q0.Tag = "";
            this.Btn_Q0.UseVisualStyleBackColor = false;
            this.Btn_Q0.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q5
            // 
            this.Btn_Q5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q5.BackColor = System.Drawing.Color.White;
            this.Btn_Q5.FlatAppearance.BorderSize = 0;
            this.Btn_Q5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q5.Location = new System.Drawing.Point(782, 290);
            this.Btn_Q5.Name = "Btn_Q5";
            this.Btn_Q5.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q5.TabIndex = 7;
            this.Btn_Q5.Tag = "";
            this.Btn_Q5.UseVisualStyleBackColor = false;
            this.Btn_Q5.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q2
            // 
            this.Btn_Q2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q2.BackColor = System.Drawing.Color.White;
            this.Btn_Q2.FlatAppearance.BorderSize = 0;
            this.Btn_Q2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q2.Location = new System.Drawing.Point(783, 128);
            this.Btn_Q2.Name = "Btn_Q2";
            this.Btn_Q2.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q2.TabIndex = 4;
            this.Btn_Q2.Tag = "";
            this.Btn_Q2.UseVisualStyleBackColor = false;
            this.Btn_Q2.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q3
            // 
            this.Btn_Q3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q3.BackColor = System.Drawing.Color.White;
            this.Btn_Q3.FlatAppearance.BorderSize = 0;
            this.Btn_Q3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q3.Location = new System.Drawing.Point(415, 290);
            this.Btn_Q3.Name = "Btn_Q3";
            this.Btn_Q3.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q3.TabIndex = 5;
            this.Btn_Q3.Tag = "";
            this.Btn_Q3.UseVisualStyleBackColor = false;
            this.Btn_Q3.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q6
            // 
            this.Btn_Q6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q6.BackColor = System.Drawing.Color.White;
            this.Btn_Q6.FlatAppearance.BorderSize = 0;
            this.Btn_Q6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q6.Location = new System.Drawing.Point(415, 450);
            this.Btn_Q6.Name = "Btn_Q6";
            this.Btn_Q6.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q6.TabIndex = 8;
            this.Btn_Q6.Tag = "";
            this.Btn_Q6.UseVisualStyleBackColor = false;
            this.Btn_Q6.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q7
            // 
            this.Btn_Q7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q7.BackColor = System.Drawing.Color.White;
            this.Btn_Q7.FlatAppearance.BorderSize = 0;
            this.Btn_Q7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q7.Location = new System.Drawing.Point(598, 450);
            this.Btn_Q7.Name = "Btn_Q7";
            this.Btn_Q7.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q7.TabIndex = 9;
            this.Btn_Q7.Tag = "";
            this.Btn_Q7.UseVisualStyleBackColor = false;
            this.Btn_Q7.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q1
            // 
            this.Btn_Q1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q1.BackColor = System.Drawing.Color.White;
            this.Btn_Q1.FlatAppearance.BorderSize = 0;
            this.Btn_Q1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q1.Location = new System.Drawing.Point(599, 130);
            this.Btn_Q1.Name = "Btn_Q1";
            this.Btn_Q1.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q1.TabIndex = 3;
            this.Btn_Q1.Tag = "";
            this.Btn_Q1.UseVisualStyleBackColor = false;
            this.Btn_Q1.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Btn_Q8
            // 
            this.Btn_Q8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Q8.BackColor = System.Drawing.Color.White;
            this.Btn_Q8.FlatAppearance.BorderSize = 0;
            this.Btn_Q8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Q8.Location = new System.Drawing.Point(782, 451);
            this.Btn_Q8.Name = "Btn_Q8";
            this.Btn_Q8.Size = new System.Drawing.Size(177, 154);
            this.Btn_Q8.TabIndex = 10;
            this.Btn_Q8.Tag = "";
            this.Btn_Q8.UseVisualStyleBackColor = false;
            this.Btn_Q8.Click += new System.EventHandler(this.UsuarioJogou);
            // 
            // Llb_Perfil
            // 
            this.Llb_Perfil.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Llb_Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Llb_Perfil.AutoSize = true;
            this.Llb_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llb_Perfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.Llb_Perfil.LinkArea = new System.Windows.Forms.LinkArea(12, 33);
            this.Llb_Perfil.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Llb_Perfil.Location = new System.Drawing.Point(20, 686);
            this.Llb_Perfil.Name = "Llb_Perfil";
            this.Llb_Perfil.Size = new System.Drawing.Size(322, 29);
            this.Llb_Perfil.TabIndex = 11;
            this.Llb_Perfil.TabStop = true;
            this.Llb_Perfil.Text = "Criado por: Paulo-Henrique-Silva";
            this.Llb_Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Llb_Perfil.UseCompatibleTextRendering = true;
            this.Llb_Perfil.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Llb_Perfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IrNoPerfil);
            // 
            // Llb_Planejamento
            // 
            this.Llb_Planejamento.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Llb_Planejamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Llb_Planejamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llb_Planejamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.Llb_Planejamento.LinkArea = new System.Windows.Forms.LinkArea(18, 33);
            this.Llb_Planejamento.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Llb_Planejamento.Location = new System.Drawing.Point(993, 663);
            this.Llb_Planejamento.Name = "Llb_Planejamento";
            this.Llb_Planejamento.Size = new System.Drawing.Size(316, 52);
            this.Llb_Planejamento.TabIndex = 13;
            this.Llb_Planejamento.TabStop = true;
            this.Llb_Planejamento.Text = "Mais Informações: Planejamento Completo (pt-br)";
            this.Llb_Planejamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Llb_Planejamento.UseCompatibleTextRendering = true;
            this.Llb_Planejamento.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Llb_Planejamento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IrNoPlanejamento);
            // 
            // Lbl_Turno
            // 
            this.Lbl_Turno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Turno.AutoSize = true;
            this.Lbl_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Turno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.Lbl_Turno.Location = new System.Drawing.Point(1151, 82);
            this.Lbl_Turno.Name = "Lbl_Turno";
            this.Lbl_Turno.Size = new System.Drawing.Size(101, 25);
            this.Lbl_Turno.TabIndex = 14;
            this.Lbl_Turno.Text = "Vez de X";
            this.Lbl_Turno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pbx_Resultado
            // 
            this.Pbx_Resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pbx_Resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Pbx_Resultado.Location = new System.Drawing.Point(398, 155);
            this.Pbx_Resultado.Name = "Pbx_Resultado";
            this.Pbx_Resultado.Size = new System.Drawing.Size(570, 443);
            this.Pbx_Resultado.TabIndex = 15;
            this.Pbx_Resultado.TabStop = false;
            this.Pbx_Resultado.Visible = false;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Btn_Ok.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Btn_Ok.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(171)))), ((int)(((byte)(192)))));
            this.Btn_Ok.BorderRadius = 0;
            this.Btn_Ok.BorderSize = 0;
            this.Btn_Ok.FlatAppearance.BorderSize = 0;
            this.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.Btn_Ok.Location = new System.Drawing.Point(551, 540);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(264, 36);
            this.Btn_Ok.TabIndex = 16;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.Btn_Ok.UseVisualStyleBackColor = false;
            this.Btn_Ok.Visible = false;
            this.Btn_Ok.Click += new System.EventHandler(this.FechouResultado);
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Reiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Btn_Reiniciar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.Btn_Reiniciar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(171)))), ((int)(((byte)(192)))));
            this.Btn_Reiniciar.BorderRadius = 5;
            this.Btn_Reiniciar.BorderSize = 2;
            this.Btn_Reiniciar.FlatAppearance.BorderSize = 0;
            this.Btn_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reiniciar.ForeColor = System.Drawing.Color.White;
            this.Btn_Reiniciar.Location = new System.Drawing.Point(551, 681);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(264, 36);
            this.Btn_Reiniciar.TabIndex = 12;
            this.Btn_Reiniciar.Text = "Reiniciar Jogo";
            this.Btn_Reiniciar.TextColor = System.Drawing.Color.White;
            this.Btn_Reiniciar.UseVisualStyleBackColor = false;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.ReiniciarJogo);
            // 
            // F_Jogo
            // 
            this.AcceptButton = this.Btn_Reiniciar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Pbx_Resultado);
            this.Controls.Add(this.Lbl_Turno);
            this.Controls.Add(this.Llb_Planejamento);
            this.Controls.Add(this.Llb_Perfil);
            this.Controls.Add(this.Btn_Reiniciar);
            this.Controls.Add(this.Btn_Q8);
            this.Controls.Add(this.Btn_Q1);
            this.Controls.Add(this.Btn_Q7);
            this.Controls.Add(this.Btn_Q6);
            this.Controls.Add(this.Btn_Q3);
            this.Controls.Add(this.Btn_Q2);
            this.Controls.Add(this.Btn_Q5);
            this.Controls.Add(this.Btn_Q0);
            this.Controls.Add(this.Btn_Q4);
            this.Controls.Add(this.Pbx_Grid);
            this.Controls.Add(this.Lbl_PlacarO);
            this.Controls.Add(this.Lbl_PlacarX);
            this.Controls.Add(this.Pbx_PlacarO);
            this.Controls.Add(this.Pbx_PlacarX);
            this.Controls.Add(this.Lbl_Placar);
            this.Controls.Add(this.Cbx_Dific);
            this.Controls.Add(this.Lbl_Dific);
            this.Controls.Add(this.Cbx_Modo);
            this.Controls.Add(this.Lbl_ModoDeJogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC-TAC-TOE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_PlacarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_PlacarO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ModoDeJogo;
        private System.Windows.Forms.ComboBox Cbx_Modo;
        private System.Windows.Forms.ComboBox Cbx_Dific;
        private System.Windows.Forms.Label Lbl_Dific;
        private System.Windows.Forms.Label Lbl_Placar;
        private System.Windows.Forms.PictureBox Pbx_PlacarX;
        private System.Windows.Forms.PictureBox Pbx_PlacarO;
        private System.Windows.Forms.Label Lbl_PlacarX;
        private System.Windows.Forms.Label Lbl_PlacarO;
        private System.Windows.Forms.PictureBox Pbx_Grid;
        private System.Windows.Forms.Button Btn_Q4;
        private System.Windows.Forms.Button Btn_Q0;
        private System.Windows.Forms.Button Btn_Q5;
        private System.Windows.Forms.Button Btn_Q2;
        private System.Windows.Forms.Button Btn_Q3;
        private System.Windows.Forms.Button Btn_Q6;
        private System.Windows.Forms.Button Btn_Q7;
        private System.Windows.Forms.Button Btn_Q1;
        private System.Windows.Forms.Button Btn_Q8;
        private Controles.CustomButton Btn_Reiniciar;
        private System.Windows.Forms.LinkLabel Llb_Perfil;
        private System.Windows.Forms.LinkLabel Llb_Planejamento;
        private System.Windows.Forms.Label Lbl_Turno;
        private System.Windows.Forms.PictureBox Pbx_Resultado;
        private Controles.CustomButton Btn_Ok;
    }
}

