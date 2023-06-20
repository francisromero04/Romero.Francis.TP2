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
            btnCancelarJuego = new Button();
            gbxPosiciones = new GroupBox();
            lblPosicion2 = new Label();
            lblPosicion1 = new Label();
            gbxMesa = new GroupBox();
            lblEnvidoDos = new Label();
            lblEnvidoUno = new Label();
            lblTanto = new Label();
            lblValorDelTruco = new Label();
            lblCarta3B = new Label();
            lblValorTanto = new Label();
            lblCarta3A = new Label();
            lblMano3 = new Label();
            lblCarta2B = new Label();
            lblCarta2A = new Label();
            lblMano2 = new Label();
            lblCarta1B = new Label();
            lblCarta1A = new Label();
            lblMano1 = new Label();
            btnIrseDos = new Button();
            btnQuieroDos = new Button();
            btnTrucoDos = new Button();
            btnFlorDos = new Button();
            btnFaltaEnvidoDos = new Button();
            btnRealEnvidoDos = new Button();
            btnEnvidoDos = new Button();
            btnIrseUno = new Button();
            gbxJugadorDos = new GroupBox();
            btnJugarDos = new Button();
            chbOcultarDos = new CheckBox();
            rBtn4 = new RadioButton();
            rBtn5 = new RadioButton();
            rBtn6 = new RadioButton();
            gbxJugadorUno = new GroupBox();
            btnJugarUno = new Button();
            chbOcultarUno = new CheckBox();
            rBtn1 = new RadioButton();
            rBtn2 = new RadioButton();
            rBtn3 = new RadioButton();
            btnQuieroUno = new Button();
            btnTrucoUno = new Button();
            btnFlorUno = new Button();
            btnFaltaEnvidoUno = new Button();
            btnRealEnvidoUno = new Button();
            btnEnvidoUno = new Button();
            gbxPosiciones.SuspendLayout();
            gbxMesa.SuspendLayout();
            gbxJugadorDos.SuspendLayout();
            gbxJugadorUno.SuspendLayout();
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
            // btnCancelarJuego
            // 
            btnCancelarJuego.Location = new Point(194, 430);
            btnCancelarJuego.Name = "btnCancelarJuego";
            btnCancelarJuego.Size = new Size(200, 48);
            btnCancelarJuego.TabIndex = 47;
            btnCancelarJuego.Text = "Cancelar Partida";
            btnCancelarJuego.UseVisualStyleBackColor = true;
            btnCancelarJuego.Click += btnCancelarJuego_Click;
            // 
            // gbxPosiciones
            // 
            gbxPosiciones.Controls.Add(lblPosicion2);
            gbxPosiciones.Controls.Add(lblPosicion1);
            gbxPosiciones.Location = new Point(194, 352);
            gbxPosiciones.Name = "gbxPosiciones";
            gbxPosiciones.Size = new Size(200, 72);
            gbxPosiciones.TabIndex = 46;
            gbxPosiciones.TabStop = false;
            gbxPosiciones.Text = "Posiciones";
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
            // gbxMesa
            // 
            gbxMesa.Controls.Add(lblEnvidoDos);
            gbxMesa.Controls.Add(lblEnvidoUno);
            gbxMesa.Controls.Add(lblTanto);
            gbxMesa.Controls.Add(lblValorDelTruco);
            gbxMesa.Controls.Add(lblCarta3B);
            gbxMesa.Controls.Add(lblValorTanto);
            gbxMesa.Controls.Add(lblCarta3A);
            gbxMesa.Controls.Add(lblMano3);
            gbxMesa.Controls.Add(lblCarta2B);
            gbxMesa.Controls.Add(lblCarta2A);
            gbxMesa.Controls.Add(lblMano2);
            gbxMesa.Controls.Add(lblCarta1B);
            gbxMesa.Controls.Add(lblCarta1A);
            gbxMesa.Controls.Add(lblMano1);
            gbxMesa.Location = new Point(194, 10);
            gbxMesa.Name = "gbxMesa";
            gbxMesa.Size = new Size(200, 327);
            gbxMesa.TabIndex = 45;
            gbxMesa.TabStop = false;
            gbxMesa.Text = "Mesa";
            // 
            // lblEnvidoDos
            // 
            lblEnvidoDos.Location = new Point(104, 221);
            lblEnvidoDos.Name = "lblEnvidoDos";
            lblEnvidoDos.Size = new Size(90, 15);
            lblEnvidoDos.TabIndex = 13;
            lblEnvidoDos.Text = "Tanto Jugador 2";
            lblEnvidoDos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEnvidoUno
            // 
            lblEnvidoUno.AutoSize = true;
            lblEnvidoUno.Location = new Point(6, 221);
            lblEnvidoUno.Name = "lblEnvidoUno";
            lblEnvidoUno.Size = new Size(90, 15);
            lblEnvidoUno.TabIndex = 12;
            lblEnvidoUno.Text = "Tanto Jugador 1";
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
            // lblCarta3B
            // 
            lblCarta3B.Location = new Point(137, 168);
            lblCarta3B.Name = "lblCarta3B";
            lblCarta3B.Size = new Size(57, 15);
            lblCarta3B.TabIndex = 10;
            lblCarta3B.Text = "Carta 3B";
            lblCarta3B.TextAlign = ContentAlignment.MiddleRight;
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
            // lblCarta3A
            // 
            lblCarta3A.AutoSize = true;
            lblCarta3A.Location = new Point(7, 168);
            lblCarta3A.Name = "lblCarta3A";
            lblCarta3A.Size = new Size(52, 15);
            lblCarta3A.TabIndex = 9;
            lblCarta3A.Text = "Carta 3A";
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
            // lblCarta2B
            // 
            lblCarta2B.Location = new Point(137, 105);
            lblCarta2B.Name = "lblCarta2B";
            lblCarta2B.Size = new Size(57, 15);
            lblCarta2B.TabIndex = 7;
            lblCarta2B.Text = "Carta 2B";
            lblCarta2B.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCarta2A
            // 
            lblCarta2A.AutoSize = true;
            lblCarta2A.Location = new Point(7, 105);
            lblCarta2A.Name = "lblCarta2A";
            lblCarta2A.Size = new Size(52, 15);
            lblCarta2A.TabIndex = 6;
            lblCarta2A.Text = "Carta 2A";
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
            // lblCarta1B
            // 
            lblCarta1B.Location = new Point(137, 46);
            lblCarta1B.Name = "lblCarta1B";
            lblCarta1B.Size = new Size(57, 15);
            lblCarta1B.TabIndex = 4;
            lblCarta1B.Text = "Carta 1B";
            lblCarta1B.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCarta1A
            // 
            lblCarta1A.AutoSize = true;
            lblCarta1A.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarta1A.ForeColor = SystemColors.ControlText;
            lblCarta1A.Location = new Point(7, 46);
            lblCarta1A.Name = "lblCarta1A";
            lblCarta1A.Size = new Size(52, 15);
            lblCarta1A.TabIndex = 3;
            lblCarta1A.Text = "Carta 1A";
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
            // btnIrseDos
            // 
            btnIrseDos.BackColor = SystemColors.ActiveBorder;
            btnIrseDos.Location = new Point(400, 314);
            btnIrseDos.Name = "btnIrseDos";
            btnIrseDos.Size = new Size(176, 23);
            btnIrseDos.TabIndex = 44;
            btnIrseDos.Text = "Me voy al mazo";
            btnIrseDos.UseVisualStyleBackColor = false;
            // 
            // btnQuieroDos
            // 
            btnQuieroDos.BackColor = SystemColors.ActiveBorder;
            btnQuieroDos.Location = new Point(491, 285);
            btnQuieroDos.Name = "btnQuieroDos";
            btnQuieroDos.Size = new Size(85, 23);
            btnQuieroDos.TabIndex = 43;
            btnQuieroDos.Text = "Quiero!";
            btnQuieroDos.UseVisualStyleBackColor = false;
            // 
            // btnTrucoDos
            // 
            btnTrucoDos.BackColor = SystemColors.ActiveBorder;
            btnTrucoDos.Location = new Point(491, 256);
            btnTrucoDos.Name = "btnTrucoDos";
            btnTrucoDos.Size = new Size(85, 23);
            btnTrucoDos.TabIndex = 42;
            btnTrucoDos.Text = "Truco!";
            btnTrucoDos.UseVisualStyleBackColor = false;
            // 
            // btnFlorDos
            // 
            btnFlorDos.BackColor = SystemColors.ActiveBorder;
            btnFlorDos.Location = new Point(491, 227);
            btnFlorDos.Name = "btnFlorDos";
            btnFlorDos.Size = new Size(85, 23);
            btnFlorDos.TabIndex = 41;
            btnFlorDos.Text = "Flor!";
            btnFlorDos.UseVisualStyleBackColor = false;
            // 
            // btnFaltaEnvidoDos
            // 
            btnFaltaEnvidoDos.BackColor = SystemColors.ActiveBorder;
            btnFaltaEnvidoDos.Location = new Point(400, 285);
            btnFaltaEnvidoDos.Name = "btnFaltaEnvidoDos";
            btnFaltaEnvidoDos.Size = new Size(85, 23);
            btnFaltaEnvidoDos.TabIndex = 40;
            btnFaltaEnvidoDos.Text = "Falta Envido!";
            btnFaltaEnvidoDos.UseVisualStyleBackColor = false;
            // 
            // btnRealEnvidoDos
            // 
            btnRealEnvidoDos.BackColor = SystemColors.ActiveBorder;
            btnRealEnvidoDos.Location = new Point(400, 256);
            btnRealEnvidoDos.Name = "btnRealEnvidoDos";
            btnRealEnvidoDos.Size = new Size(85, 23);
            btnRealEnvidoDos.TabIndex = 39;
            btnRealEnvidoDos.Text = "Real Envido!";
            btnRealEnvidoDos.UseVisualStyleBackColor = false;
            // 
            // btnEnvidoDos
            // 
            btnEnvidoDos.BackColor = SystemColors.ActiveBorder;
            btnEnvidoDos.Location = new Point(400, 227);
            btnEnvidoDos.Name = "btnEnvidoDos";
            btnEnvidoDos.Size = new Size(85, 23);
            btnEnvidoDos.TabIndex = 38;
            btnEnvidoDos.Text = "Envido!";
            btnEnvidoDos.UseVisualStyleBackColor = false;
            // 
            // btnIrseUno
            // 
            btnIrseUno.BackColor = SystemColors.ActiveBorder;
            btnIrseUno.Location = new Point(12, 314);
            btnIrseUno.Name = "btnIrseUno";
            btnIrseUno.Size = new Size(176, 23);
            btnIrseUno.TabIndex = 37;
            btnIrseUno.Text = "Me voy al mazo";
            btnIrseUno.UseVisualStyleBackColor = false;
            // 
            // gbxJugadorDos
            // 
            gbxJugadorDos.Controls.Add(btnJugarDos);
            gbxJugadorDos.Controls.Add(chbOcultarDos);
            gbxJugadorDos.Controls.Add(rBtn4);
            gbxJugadorDos.Controls.Add(rBtn5);
            gbxJugadorDos.Controls.Add(rBtn6);
            gbxJugadorDos.Location = new Point(400, 10);
            gbxJugadorDos.Name = "gbxJugadorDos";
            gbxJugadorDos.Size = new Size(176, 211);
            gbxJugadorDos.TabIndex = 35;
            gbxJugadorDos.TabStop = false;
            gbxJugadorDos.Text = "Jugador 2";
            // 
            // btnJugarDos
            // 
            btnJugarDos.BackColor = SystemColors.ActiveBorder;
            btnJugarDos.Location = new Point(17, 168);
            btnJugarDos.Name = "btnJugarDos";
            btnJugarDos.Size = new Size(75, 23);
            btnJugarDos.TabIndex = 27;
            btnJugarDos.Text = "Jugar carta";
            btnJugarDos.UseVisualStyleBackColor = false;
            // 
            // chbOcultarDos
            // 
            chbOcultarDos.AutoSize = true;
            chbOcultarDos.Location = new Point(17, 32);
            chbOcultarDos.Name = "chbOcultarDos";
            chbOcultarDos.Size = new Size(101, 19);
            chbOcultarDos.TabIndex = 26;
            chbOcultarDos.Text = "Ocultar Cartas";
            chbOcultarDos.UseVisualStyleBackColor = true;
            chbOcultarDos.CheckedChanged += chbOcultarDos_CheckedChanged;
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
            // gbxJugadorUno
            // 
            gbxJugadorUno.Controls.Add(btnJugarUno);
            gbxJugadorUno.Controls.Add(chbOcultarUno);
            gbxJugadorUno.Controls.Add(rBtn1);
            gbxJugadorUno.Controls.Add(rBtn2);
            gbxJugadorUno.Controls.Add(rBtn3);
            gbxJugadorUno.Location = new Point(12, 10);
            gbxJugadorUno.Name = "gbxJugadorUno";
            gbxJugadorUno.Size = new Size(176, 211);
            gbxJugadorUno.TabIndex = 34;
            gbxJugadorUno.TabStop = false;
            gbxJugadorUno.Text = "Jugador 1";
            // 
            // btnJugarUno
            // 
            btnJugarUno.BackColor = SystemColors.ActiveBorder;
            btnJugarUno.Location = new Point(20, 168);
            btnJugarUno.Name = "btnJugarUno";
            btnJugarUno.Size = new Size(75, 23);
            btnJugarUno.TabIndex = 26;
            btnJugarUno.Text = "Jugar carta";
            btnJugarUno.UseVisualStyleBackColor = false;
            // 
            // chbOcultarUno
            // 
            chbOcultarUno.AutoSize = true;
            chbOcultarUno.Location = new Point(20, 32);
            chbOcultarUno.Name = "chbOcultarUno";
            chbOcultarUno.Size = new Size(101, 19);
            chbOcultarUno.TabIndex = 25;
            chbOcultarUno.Text = "Ocultar Cartas";
            chbOcultarUno.UseVisualStyleBackColor = true;
            chbOcultarUno.CheckedChanged += chbOcultarUno_CheckedChanged;
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
            // btnQuieroUno
            // 
            btnQuieroUno.BackColor = SystemColors.ActiveBorder;
            btnQuieroUno.Location = new Point(103, 285);
            btnQuieroUno.Name = "btnQuieroUno";
            btnQuieroUno.Size = new Size(85, 23);
            btnQuieroUno.TabIndex = 33;
            btnQuieroUno.Text = "Quiero!";
            btnQuieroUno.UseVisualStyleBackColor = false;
            // 
            // btnTrucoUno
            // 
            btnTrucoUno.BackColor = SystemColors.ActiveBorder;
            btnTrucoUno.Location = new Point(103, 256);
            btnTrucoUno.Name = "btnTrucoUno";
            btnTrucoUno.Size = new Size(85, 23);
            btnTrucoUno.TabIndex = 32;
            btnTrucoUno.Text = "Truco!";
            btnTrucoUno.UseVisualStyleBackColor = false;
            // 
            // btnFlorUno
            // 
            btnFlorUno.BackColor = SystemColors.ActiveBorder;
            btnFlorUno.Location = new Point(103, 227);
            btnFlorUno.Name = "btnFlorUno";
            btnFlorUno.Size = new Size(85, 23);
            btnFlorUno.TabIndex = 31;
            btnFlorUno.Text = "Flor!";
            btnFlorUno.UseVisualStyleBackColor = false;
            // 
            // btnFaltaEnvidoUno
            // 
            btnFaltaEnvidoUno.BackColor = SystemColors.ActiveBorder;
            btnFaltaEnvidoUno.Location = new Point(12, 285);
            btnFaltaEnvidoUno.Name = "btnFaltaEnvidoUno";
            btnFaltaEnvidoUno.Size = new Size(85, 23);
            btnFaltaEnvidoUno.TabIndex = 30;
            btnFaltaEnvidoUno.Text = "Falta Envido!";
            btnFaltaEnvidoUno.UseVisualStyleBackColor = false;
            // 
            // btnRealEnvidoUno
            // 
            btnRealEnvidoUno.BackColor = SystemColors.ActiveBorder;
            btnRealEnvidoUno.Location = new Point(12, 256);
            btnRealEnvidoUno.Name = "btnRealEnvidoUno";
            btnRealEnvidoUno.Size = new Size(85, 23);
            btnRealEnvidoUno.TabIndex = 29;
            btnRealEnvidoUno.Text = "Real Envido!";
            btnRealEnvidoUno.UseVisualStyleBackColor = false;
            // 
            // btnEnvidoUno
            // 
            btnEnvidoUno.BackColor = SystemColors.ActiveBorder;
            btnEnvidoUno.Location = new Point(12, 227);
            btnEnvidoUno.Name = "btnEnvidoUno";
            btnEnvidoUno.Size = new Size(85, 23);
            btnEnvidoUno.TabIndex = 28;
            btnEnvidoUno.Text = "Envido!";
            btnEnvidoUno.UseVisualStyleBackColor = false;
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
            Controls.Add(btnCancelarJuego);
            Controls.Add(gbxPosiciones);
            Controls.Add(gbxMesa);
            Controls.Add(btnIrseDos);
            Controls.Add(btnQuieroDos);
            Controls.Add(btnTrucoDos);
            Controls.Add(btnFlorDos);
            Controls.Add(btnFaltaEnvidoDos);
            Controls.Add(btnRealEnvidoDos);
            Controls.Add(btnEnvidoDos);
            Controls.Add(btnIrseUno);
            Controls.Add(gbxJugadorDos);
            Controls.Add(gbxJugadorUno);
            Controls.Add(btnQuieroUno);
            Controls.Add(btnTrucoUno);
            Controls.Add(btnFlorUno);
            Controls.Add(btnFaltaEnvidoUno);
            Controls.Add(btnRealEnvidoUno);
            Controls.Add(btnEnvidoUno);
            Name = "FrmMesaTruco";
            Text = "FrmMesa";
            Load += FrmMesaTruco_Load;
            gbxPosiciones.ResumeLayout(false);
            gbxPosiciones.PerformLayout();
            gbxMesa.ResumeLayout(false);
            gbxMesa.PerformLayout();
            gbxJugadorDos.ResumeLayout(false);
            gbxJugadorDos.PerformLayout();
            gbxJugadorUno.ResumeLayout(false);
            gbxJugadorUno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFechaYHora;
        private Label lblCantoJugador2;
        private Label lblCantoJugador1;
        private Button btnCancelarJuego;
        private GroupBox gbxPosiciones;
        private Label lblPosicion2;
        private Label lblPosicion1;
        private GroupBox gbxMesa;
        private Label lblEnvidoDos;
        private Label lblEnvidoUno;
        private Label lblTanto;
        private Label lblValorDelTruco;
        private Label lblCarta3B;
        private Label lblValorTanto;
        private Label lblCarta3A;
        private Label lblMano3;
        private Label lblCarta2B;
        private Label lblCarta2A;
        private Label lblMano2;
        private Label lblCarta1B;
        private Label lblCarta1A;
        private Label lblMano1;
        private Button btnIrseDos;
        private Button btnQuieroDos;
        private Button btnTrucoDos;
        private Button btnFlorDos;
        private Button btnFaltaEnvidoDos;
        private Button btnRealEnvidoDos;
        private Button btnEnvidoDos;
        private Button btnIrseUno;
        private GroupBox gbxJugadorDos;
        private Button btnJugarDos;
        private CheckBox chbOcultarDos;
        private RadioButton rBtn4;
        private RadioButton rBtn5;
        private RadioButton rBtn6;
        private GroupBox gbxJugadorUno;
        private Button btnJugarUno;
        private CheckBox chbOcultarUno;
        private RadioButton rBtn1;
        private RadioButton rBtn2;
        private RadioButton rBtn3;
        private Button btnQuieroUno;
        private Button btnTrucoUno;
        private Button btnFlorUno;
        private Button btnFaltaEnvidoUno;
        private Button btnRealEnvidoUno;
        private Button btnEnvidoUno;
    }
}