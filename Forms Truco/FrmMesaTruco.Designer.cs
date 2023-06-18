namespace Forms_Truco
{
    partial class FrmMesaTruco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFechaYHora = new Label();
            lblCantoJugador2 = new Label();
            lblCantoJugador1 = new Label();
            btnCancelarPartida = new Button();
            grpPosiciones = new GroupBox();
            lblPosicion2 = new Label();
            lblPosicion1 = new Label();
            grpBxMesa = new GroupBox();
            lblTantoJugador2 = new Label();
            lblTantoJugador1 = new Label();
            lblTanto = new Label();
            lblValorDelTruco = new Label();
            lblNaipe32 = new Label();
            lblValorTanto = new Label();
            lblNaipe31 = new Label();
            lblMano3 = new Label();
            lblNaipe22 = new Label();
            lblNaipe21 = new Label();
            lblMano2 = new Label();
            lblNaipe12 = new Label();
            lblNaipe11 = new Label();
            lblMano1 = new Label();
            btnAlMazo2 = new Button();
            btnQuiero2 = new Button();
            btnTruco2 = new Button();
            btnFlor2 = new Button();
            btnFaltaEnvido2 = new Button();
            btnRealEnvido2 = new Button();
            btnEnvido2 = new Button();
            btnAlMazo1 = new Button();
            grpBxJugador2 = new GroupBox();
            btnJugarNaipe2 = new Button();
            chkBxOcultarMano2 = new CheckBox();
            rBtn4 = new RadioButton();
            rBtn5 = new RadioButton();
            rBtn6 = new RadioButton();
            grpBxJugador1 = new GroupBox();
            btnJugarNaipe1 = new Button();
            chkBxOcultarMano1 = new CheckBox();
            rBtn1 = new RadioButton();
            rBtn2 = new RadioButton();
            rBtn3 = new RadioButton();
            btnQuiero1 = new Button();
            btnTruco1 = new Button();
            btnFlor1 = new Button();
            btnFaltaEnvido1 = new Button();
            btnRealEnvido1 = new Button();
            btnEnvido1 = new Button();
            grpPosiciones.SuspendLayout();
            grpBxMesa.SuspendLayout();
            grpBxJugador2.SuspendLayout();
            grpBxJugador1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFechaYHora
            // 
            lblFechaYHora.Location = new Point(400, 466);
            lblFechaYHora.Name = "lblFechaYHora";
            lblFechaYHora.Size = new Size(176, 15);
            lblFechaYHora.TabIndex = 36;
            lblFechaYHora.Text = "Hora";
            lblFechaYHora.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCantoJugador2
            // 
            lblCantoJugador2.AutoSize = true;
            lblCantoJugador2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantoJugador2.Location = new Point(400, 394);
            lblCantoJugador2.Name = "lblCantoJugador2";
            lblCantoJugador2.Size = new Size(151, 25);
            lblCantoJugador2.TabIndex = 49;
            lblCantoJugador2.Text = "Falta Envido!";
            // 
            // lblCantoJugador1
            // 
            lblCantoJugador1.AutoSize = true;
            lblCantoJugador1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantoJugador1.Location = new Point(12, 394);
            lblCantoJugador1.Name = "lblCantoJugador1";
            lblCantoJugador1.Size = new Size(151, 25);
            lblCantoJugador1.TabIndex = 48;
            lblCantoJugador1.Text = "Falta Envido!";
            // 
            // btnCancelarPartida
            // 
            btnCancelarPartida.Location = new Point(194, 430);
            btnCancelarPartida.Name = "btnCancelarPartida";
            btnCancelarPartida.Size = new Size(200, 48);
            btnCancelarPartida.TabIndex = 47;
            btnCancelarPartida.Text = "Cancelar Partida";
            btnCancelarPartida.UseVisualStyleBackColor = true;
            // 
            // grpPosiciones
            // 
            grpPosiciones.Controls.Add(lblPosicion2);
            grpPosiciones.Controls.Add(lblPosicion1);
            grpPosiciones.Location = new Point(194, 352);
            grpPosiciones.Name = "grpPosiciones";
            grpPosiciones.Size = new Size(200, 72);
            grpPosiciones.TabIndex = 46;
            grpPosiciones.TabStop = false;
            grpPosiciones.Text = "Posiciones";
            // 
            // lblPosicion2
            // 
            lblPosicion2.AutoSize = true;
            lblPosicion2.Location = new Point(7, 42);
            lblPosicion2.Name = "lblPosicion2";
            lblPosicion2.Size = new Size(61, 15);
            lblPosicion2.TabIndex = 1;
            lblPosicion2.Text = "Posición 2";
            // 
            // lblPosicion1
            // 
            lblPosicion1.AutoSize = true;
            lblPosicion1.Location = new Point(7, 23);
            lblPosicion1.Name = "lblPosicion1";
            lblPosicion1.Size = new Size(61, 15);
            lblPosicion1.TabIndex = 0;
            lblPosicion1.Text = "Posición 1";
            // 
            // grpBxMesa
            // 
            grpBxMesa.Controls.Add(lblTantoJugador2);
            grpBxMesa.Controls.Add(lblTantoJugador1);
            grpBxMesa.Controls.Add(lblTanto);
            grpBxMesa.Controls.Add(lblValorDelTruco);
            grpBxMesa.Controls.Add(lblNaipe32);
            grpBxMesa.Controls.Add(lblValorTanto);
            grpBxMesa.Controls.Add(lblNaipe31);
            grpBxMesa.Controls.Add(lblMano3);
            grpBxMesa.Controls.Add(lblNaipe22);
            grpBxMesa.Controls.Add(lblNaipe21);
            grpBxMesa.Controls.Add(lblMano2);
            grpBxMesa.Controls.Add(lblNaipe12);
            grpBxMesa.Controls.Add(lblNaipe11);
            grpBxMesa.Controls.Add(lblMano1);
            grpBxMesa.Location = new Point(194, 10);
            grpBxMesa.Name = "grpBxMesa";
            grpBxMesa.Size = new Size(200, 327);
            grpBxMesa.TabIndex = 45;
            grpBxMesa.TabStop = false;
            grpBxMesa.Text = "Mesa";
            // 
            // lblTantoJugador2
            // 
            lblTantoJugador2.Location = new Point(104, 221);
            lblTantoJugador2.Name = "lblTantoJugador2";
            lblTantoJugador2.Size = new Size(90, 15);
            lblTantoJugador2.TabIndex = 13;
            lblTantoJugador2.Text = "Tanto Jugador 2";
            lblTantoJugador2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTantoJugador1
            // 
            lblTantoJugador1.AutoSize = true;
            lblTantoJugador1.Location = new Point(6, 221);
            lblTantoJugador1.Name = "lblTantoJugador1";
            lblTantoJugador1.Size = new Size(90, 15);
            lblTantoJugador1.TabIndex = 12;
            lblTantoJugador1.Text = "Tanto Jugador 1";
            // 
            // lblTanto
            // 
            lblTanto.AutoSize = true;
            lblTanto.Location = new Point(83, 196);
            lblTanto.Name = "lblTanto";
            lblTanto.Size = new Size(36, 15);
            lblTanto.TabIndex = 11;
            lblTanto.Text = "Tanto";
            // 
            // lblValorDelTruco
            // 
            lblValorDelTruco.AutoSize = true;
            lblValorDelTruco.Location = new Point(6, 302);
            lblValorDelTruco.Name = "lblValorDelTruco";
            lblValorDelTruco.Size = new Size(96, 15);
            lblValorDelTruco.TabIndex = 1;
            lblValorDelTruco.Text = "Valor del Truco: 1";
            // 
            // lblNaipe32
            // 
            lblNaipe32.Location = new Point(137, 168);
            lblNaipe32.Name = "lblNaipe32";
            lblNaipe32.Size = new Size(57, 15);
            lblNaipe32.TabIndex = 10;
            lblNaipe32.Text = "Carta 3B";
            lblNaipe32.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValorTanto
            // 
            lblValorTanto.AutoSize = true;
            lblValorTanto.Location = new Point(6, 283);
            lblValorTanto.Name = "lblValorTanto";
            lblValorTanto.Size = new Size(103, 15);
            lblValorTanto.TabIndex = 0;
            lblValorTanto.Text = "Valor del Envido: 0";
            // 
            // lblNaipe31
            // 
            lblNaipe31.AutoSize = true;
            lblNaipe31.Location = new Point(7, 168);
            lblNaipe31.Name = "lblNaipe31";
            lblNaipe31.Size = new Size(52, 15);
            lblNaipe31.TabIndex = 9;
            lblNaipe31.Text = "Carta 3A";
            // 
            // lblMano3
            // 
            lblMano3.AutoSize = true;
            lblMano3.Location = new Point(62, 141);
            lblMano3.Name = "lblMano3";
            lblMano3.Size = new Size(78, 15);
            lblMano3.TabIndex = 8;
            lblMano3.Text = "Tercera Mano";
            // 
            // lblNaipe22
            // 
            lblNaipe22.Location = new Point(137, 105);
            lblNaipe22.Name = "lblNaipe22";
            lblNaipe22.Size = new Size(57, 15);
            lblNaipe22.TabIndex = 7;
            lblNaipe22.Text = "Carta 2B";
            lblNaipe22.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNaipe21
            // 
            lblNaipe21.AutoSize = true;
            lblNaipe21.Location = new Point(7, 105);
            lblNaipe21.Name = "lblNaipe21";
            lblNaipe21.Size = new Size(52, 15);
            lblNaipe21.TabIndex = 6;
            lblNaipe21.Text = "Carta 2A";
            // 
            // lblMano2
            // 
            lblMano2.AutoSize = true;
            lblMano2.Location = new Point(58, 80);
            lblMano2.Name = "lblMano2";
            lblMano2.Size = new Size(87, 15);
            lblMano2.TabIndex = 5;
            lblMano2.Text = "Segunda Mano";
            // 
            // lblNaipe12
            // 
            lblNaipe12.Location = new Point(137, 46);
            lblNaipe12.Name = "lblNaipe12";
            lblNaipe12.Size = new Size(57, 15);
            lblNaipe12.TabIndex = 4;
            lblNaipe12.Text = "Carta 1B";
            lblNaipe12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNaipe11
            // 
            lblNaipe11.AutoSize = true;
            lblNaipe11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNaipe11.ForeColor = SystemColors.ControlText;
            lblNaipe11.Location = new Point(7, 46);
            lblNaipe11.Name = "lblNaipe11";
            lblNaipe11.Size = new Size(52, 15);
            lblNaipe11.TabIndex = 3;
            lblNaipe11.Text = "Carta 1A";
            // 
            // lblMano1
            // 
            lblMano1.AutoSize = true;
            lblMano1.Location = new Point(63, 19);
            lblMano1.Name = "lblMano1";
            lblMano1.Size = new Size(82, 15);
            lblMano1.TabIndex = 2;
            lblMano1.Text = "Primera Mano";
            // 
            // btnAlMazo2
            // 
            btnAlMazo2.BackColor = SystemColors.ActiveBorder;
            btnAlMazo2.Location = new Point(400, 314);
            btnAlMazo2.Name = "btnAlMazo2";
            btnAlMazo2.Size = new Size(176, 23);
            btnAlMazo2.TabIndex = 44;
            btnAlMazo2.Text = "Me voy al mazo";
            btnAlMazo2.UseVisualStyleBackColor = false;
            // 
            // btnQuiero2
            // 
            btnQuiero2.BackColor = SystemColors.ActiveBorder;
            btnQuiero2.Location = new Point(491, 285);
            btnQuiero2.Name = "btnQuiero2";
            btnQuiero2.Size = new Size(85, 23);
            btnQuiero2.TabIndex = 43;
            btnQuiero2.Text = "Quiero!";
            btnQuiero2.UseVisualStyleBackColor = false;
            // 
            // btnTruco2
            // 
            btnTruco2.BackColor = SystemColors.ActiveBorder;
            btnTruco2.Location = new Point(491, 256);
            btnTruco2.Name = "btnTruco2";
            btnTruco2.Size = new Size(85, 23);
            btnTruco2.TabIndex = 42;
            btnTruco2.Text = "Truco!";
            btnTruco2.UseVisualStyleBackColor = false;
            // 
            // btnFlor2
            // 
            btnFlor2.BackColor = SystemColors.ActiveBorder;
            btnFlor2.Location = new Point(491, 227);
            btnFlor2.Name = "btnFlor2";
            btnFlor2.Size = new Size(85, 23);
            btnFlor2.TabIndex = 41;
            btnFlor2.Text = "Flor!";
            btnFlor2.UseVisualStyleBackColor = false;
            // 
            // btnFaltaEnvido2
            // 
            btnFaltaEnvido2.BackColor = SystemColors.ActiveBorder;
            btnFaltaEnvido2.Location = new Point(400, 285);
            btnFaltaEnvido2.Name = "btnFaltaEnvido2";
            btnFaltaEnvido2.Size = new Size(85, 23);
            btnFaltaEnvido2.TabIndex = 40;
            btnFaltaEnvido2.Text = "Falta Envido!";
            btnFaltaEnvido2.UseVisualStyleBackColor = false;
            // 
            // btnRealEnvido2
            // 
            btnRealEnvido2.BackColor = SystemColors.ActiveBorder;
            btnRealEnvido2.Location = new Point(400, 256);
            btnRealEnvido2.Name = "btnRealEnvido2";
            btnRealEnvido2.Size = new Size(85, 23);
            btnRealEnvido2.TabIndex = 39;
            btnRealEnvido2.Text = "Real Envido!";
            btnRealEnvido2.UseVisualStyleBackColor = false;
            // 
            // btnEnvido2
            // 
            btnEnvido2.BackColor = SystemColors.ActiveBorder;
            btnEnvido2.Location = new Point(400, 227);
            btnEnvido2.Name = "btnEnvido2";
            btnEnvido2.Size = new Size(85, 23);
            btnEnvido2.TabIndex = 38;
            btnEnvido2.Text = "Envido!";
            btnEnvido2.UseVisualStyleBackColor = false;
            // 
            // btnAlMazo1
            // 
            btnAlMazo1.BackColor = SystemColors.ActiveBorder;
            btnAlMazo1.Location = new Point(12, 314);
            btnAlMazo1.Name = "btnAlMazo1";
            btnAlMazo1.Size = new Size(176, 23);
            btnAlMazo1.TabIndex = 37;
            btnAlMazo1.Text = "Me voy al mazo";
            btnAlMazo1.UseVisualStyleBackColor = false;
            // 
            // grpBxJugador2
            // 
            grpBxJugador2.Controls.Add(btnJugarNaipe2);
            grpBxJugador2.Controls.Add(chkBxOcultarMano2);
            grpBxJugador2.Controls.Add(rBtn4);
            grpBxJugador2.Controls.Add(rBtn5);
            grpBxJugador2.Controls.Add(rBtn6);
            grpBxJugador2.Location = new Point(400, 10);
            grpBxJugador2.Name = "grpBxJugador2";
            grpBxJugador2.Size = new Size(176, 211);
            grpBxJugador2.TabIndex = 35;
            grpBxJugador2.TabStop = false;
            grpBxJugador2.Text = "Jugador 2";
            // 
            // btnJugarNaipe2
            // 
            btnJugarNaipe2.BackColor = SystemColors.ActiveBorder;
            btnJugarNaipe2.Location = new Point(17, 168);
            btnJugarNaipe2.Name = "btnJugarNaipe2";
            btnJugarNaipe2.Size = new Size(75, 23);
            btnJugarNaipe2.TabIndex = 27;
            btnJugarNaipe2.Text = "Jugar carta";
            btnJugarNaipe2.UseVisualStyleBackColor = false;
            // 
            // chkBxOcultarMano2
            // 
            chkBxOcultarMano2.AutoSize = true;
            chkBxOcultarMano2.Location = new Point(17, 32);
            chkBxOcultarMano2.Name = "chkBxOcultarMano2";
            chkBxOcultarMano2.Size = new Size(101, 19);
            chkBxOcultarMano2.TabIndex = 26;
            chkBxOcultarMano2.Text = "Ocultar Cartas";
            chkBxOcultarMano2.UseVisualStyleBackColor = true;
            // 
            // rBtn4
            // 
            rBtn4.AutoSize = true;
            rBtn4.Location = new Point(17, 74);
            rBtn4.Name = "rBtn4";
            rBtn4.Size = new Size(62, 19);
            rBtn4.TabIndex = 17;
            rBtn4.TabStop = true;
            rBtn4.Text = "Carta 1";
            rBtn4.UseVisualStyleBackColor = true;
            // 
            // rBtn5
            // 
            rBtn5.AutoSize = true;
            rBtn5.Location = new Point(17, 99);
            rBtn5.Name = "rBtn5";
            rBtn5.Size = new Size(62, 19);
            rBtn5.TabIndex = 18;
            rBtn5.TabStop = true;
            rBtn5.Text = "Carta 2";
            rBtn5.UseVisualStyleBackColor = true;
            // 
            // rBtn6
            // 
            rBtn6.AutoSize = true;
            rBtn6.Location = new Point(17, 124);
            rBtn6.Name = "rBtn6";
            rBtn6.Size = new Size(62, 19);
            rBtn6.TabIndex = 19;
            rBtn6.TabStop = true;
            rBtn6.Text = "Carta 3";
            rBtn6.UseVisualStyleBackColor = true;
            // 
            // grpBxJugador1
            // 
            grpBxJugador1.Controls.Add(btnJugarNaipe1);
            grpBxJugador1.Controls.Add(chkBxOcultarMano1);
            grpBxJugador1.Controls.Add(rBtn1);
            grpBxJugador1.Controls.Add(rBtn2);
            grpBxJugador1.Controls.Add(rBtn3);
            grpBxJugador1.Location = new Point(12, 10);
            grpBxJugador1.Name = "grpBxJugador1";
            grpBxJugador1.Size = new Size(176, 211);
            grpBxJugador1.TabIndex = 34;
            grpBxJugador1.TabStop = false;
            grpBxJugador1.Text = "Jugador 1";
            // 
            // btnJugarNaipe1
            // 
            btnJugarNaipe1.BackColor = SystemColors.ActiveBorder;
            btnJugarNaipe1.Location = new Point(20, 168);
            btnJugarNaipe1.Name = "btnJugarNaipe1";
            btnJugarNaipe1.Size = new Size(75, 23);
            btnJugarNaipe1.TabIndex = 26;
            btnJugarNaipe1.Text = "Jugar carta";
            btnJugarNaipe1.UseVisualStyleBackColor = false;
            // 
            // chkBxOcultarMano1
            // 
            chkBxOcultarMano1.AutoSize = true;
            chkBxOcultarMano1.Location = new Point(20, 32);
            chkBxOcultarMano1.Name = "chkBxOcultarMano1";
            chkBxOcultarMano1.Size = new Size(101, 19);
            chkBxOcultarMano1.TabIndex = 25;
            chkBxOcultarMano1.Text = "Ocultar Cartas";
            chkBxOcultarMano1.UseVisualStyleBackColor = true;
            // 
            // rBtn1
            // 
            rBtn1.AutoSize = true;
            rBtn1.Location = new Point(20, 74);
            rBtn1.Name = "rBtn1";
            rBtn1.Size = new Size(62, 19);
            rBtn1.TabIndex = 14;
            rBtn1.TabStop = true;
            rBtn1.Text = "Carta 1";
            rBtn1.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            rBtn2.AutoSize = true;
            rBtn2.Location = new Point(20, 99);
            rBtn2.Name = "rBtn2";
            rBtn2.Size = new Size(62, 19);
            rBtn2.TabIndex = 15;
            rBtn2.TabStop = true;
            rBtn2.Text = "Carta 2";
            rBtn2.UseVisualStyleBackColor = true;
            // 
            // rBtn3
            // 
            rBtn3.AutoSize = true;
            rBtn3.Location = new Point(20, 124);
            rBtn3.Name = "rBtn3";
            rBtn3.Size = new Size(62, 19);
            rBtn3.TabIndex = 16;
            rBtn3.TabStop = true;
            rBtn3.Text = "Carta 3";
            rBtn3.UseVisualStyleBackColor = true;
            // 
            // btnQuiero1
            // 
            btnQuiero1.BackColor = SystemColors.ActiveBorder;
            btnQuiero1.Location = new Point(103, 285);
            btnQuiero1.Name = "btnQuiero1";
            btnQuiero1.Size = new Size(85, 23);
            btnQuiero1.TabIndex = 33;
            btnQuiero1.Text = "Quiero!";
            btnQuiero1.UseVisualStyleBackColor = false;
            // 
            // btnTruco1
            // 
            btnTruco1.BackColor = SystemColors.ActiveBorder;
            btnTruco1.Location = new Point(103, 256);
            btnTruco1.Name = "btnTruco1";
            btnTruco1.Size = new Size(85, 23);
            btnTruco1.TabIndex = 32;
            btnTruco1.Text = "Truco!";
            btnTruco1.UseVisualStyleBackColor = false;
            // 
            // btnFlor1
            // 
            btnFlor1.BackColor = SystemColors.ActiveBorder;
            btnFlor1.Location = new Point(103, 227);
            btnFlor1.Name = "btnFlor1";
            btnFlor1.Size = new Size(85, 23);
            btnFlor1.TabIndex = 31;
            btnFlor1.Text = "Flor!";
            btnFlor1.UseVisualStyleBackColor = false;
            // 
            // btnFaltaEnvido1
            // 
            btnFaltaEnvido1.BackColor = SystemColors.ActiveBorder;
            btnFaltaEnvido1.Location = new Point(12, 285);
            btnFaltaEnvido1.Name = "btnFaltaEnvido1";
            btnFaltaEnvido1.Size = new Size(85, 23);
            btnFaltaEnvido1.TabIndex = 30;
            btnFaltaEnvido1.Text = "Falta Envido!";
            btnFaltaEnvido1.UseVisualStyleBackColor = false;
            // 
            // btnRealEnvido1
            // 
            btnRealEnvido1.BackColor = SystemColors.ActiveBorder;
            btnRealEnvido1.Location = new Point(12, 256);
            btnRealEnvido1.Name = "btnRealEnvido1";
            btnRealEnvido1.Size = new Size(85, 23);
            btnRealEnvido1.TabIndex = 29;
            btnRealEnvido1.Text = "Real Envido!";
            btnRealEnvido1.UseVisualStyleBackColor = false;
            // 
            // btnEnvido1
            // 
            btnEnvido1.BackColor = SystemColors.ActiveBorder;
            btnEnvido1.Location = new Point(12, 227);
            btnEnvido1.Name = "btnEnvido1";
            btnEnvido1.Size = new Size(85, 23);
            btnEnvido1.TabIndex = 28;
            btnEnvido1.Text = "Envido!";
            btnEnvido1.UseVisualStyleBackColor = false;
            // 
            // FrmMesaTruco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(589, 491);
            Controls.Add(lblFechaYHora);
            Controls.Add(lblCantoJugador2);
            Controls.Add(lblCantoJugador1);
            Controls.Add(btnCancelarPartida);
            Controls.Add(grpPosiciones);
            Controls.Add(grpBxMesa);
            Controls.Add(btnAlMazo2);
            Controls.Add(btnQuiero2);
            Controls.Add(btnTruco2);
            Controls.Add(btnFlor2);
            Controls.Add(btnFaltaEnvido2);
            Controls.Add(btnRealEnvido2);
            Controls.Add(btnEnvido2);
            Controls.Add(btnAlMazo1);
            Controls.Add(grpBxJugador2);
            Controls.Add(grpBxJugador1);
            Controls.Add(btnQuiero1);
            Controls.Add(btnTruco1);
            Controls.Add(btnFlor1);
            Controls.Add(btnFaltaEnvido1);
            Controls.Add(btnRealEnvido1);
            Controls.Add(btnEnvido1);
            Name = "FrmMesaTruco";
            Text = "FrmMesa";
            grpPosiciones.ResumeLayout(false);
            grpPosiciones.PerformLayout();
            grpBxMesa.ResumeLayout(false);
            grpBxMesa.PerformLayout();
            grpBxJugador2.ResumeLayout(false);
            grpBxJugador2.PerformLayout();
            grpBxJugador1.ResumeLayout(false);
            grpBxJugador1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaYHora;
        private Label lblCantoJugador2;
        private Label lblCantoJugador1;
        private Button btnCancelarPartida;
        private GroupBox grpPosiciones;
        private Label lblPosicion2;
        private Label lblPosicion1;
        private GroupBox grpBxMesa;
        private Label lblTantoJugador2;
        private Label lblTantoJugador1;
        private Label lblTanto;
        private Label lblValorDelTruco;
        private Label lblNaipe32;
        private Label lblValorTanto;
        private Label lblNaipe31;
        private Label lblMano3;
        private Label lblNaipe22;
        private Label lblNaipe21;
        private Label lblMano2;
        private Label lblNaipe12;
        private Label lblNaipe11;
        private Label lblMano1;
        private Button btnAlMazo2;
        private Button btnQuiero2;
        private Button btnTruco2;
        private Button btnFlor2;
        private Button btnFaltaEnvido2;
        private Button btnRealEnvido2;
        private Button btnEnvido2;
        private Button btnAlMazo1;
        private GroupBox grpBxJugador2;
        private Button btnJugarNaipe2;
        private CheckBox chkBxOcultarMano2;
        private RadioButton rBtn4;
        private RadioButton rBtn5;
        private RadioButton rBtn6;
        private GroupBox grpBxJugador1;
        private Button btnJugarNaipe1;
        private CheckBox chkBxOcultarMano1;
        private RadioButton rBtn1;
        private RadioButton rBtn2;
        private RadioButton rBtn3;
        private Button btnQuiero1;
        private Button btnTruco1;
        private Button btnFlor1;
        private Button btnFaltaEnvido1;
        private Button btnRealEnvido1;
        private Button btnEnvido1;
    }
}