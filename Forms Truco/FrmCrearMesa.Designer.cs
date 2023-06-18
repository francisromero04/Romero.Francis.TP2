namespace Forms_Truco
{
    partial class FrmCrearMesa
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
            btnJugar = new Button();
            txtJugador2 = new TextBox();
            txtJugador1 = new TextBox();
            lblJugador2 = new Label();
            lblJugador1 = new Label();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.BackColor = SystemColors.AppWorkspace;
            btnJugar.Location = new Point(85, 80);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(103, 30);
            btnJugar.TabIndex = 4;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnCrear_Click;
            // 
            // txtJugador2
            // 
            txtJugador2.BackColor = SystemColors.AppWorkspace;
            txtJugador2.Location = new Point(162, 46);
            txtJugador2.MaxLength = 20;
            txtJugador2.Name = "txtJugador2";
            txtJugador2.PlaceholderText = "Jugador 2";
            txtJugador2.Size = new Size(100, 23);
            txtJugador2.TabIndex = 8;
            // 
            // txtJugador1
            // 
            txtJugador1.BackColor = SystemColors.AppWorkspace;
            txtJugador1.Location = new Point(162, 17);
            txtJugador1.MaxLength = 20;
            txtJugador1.Name = "txtJugador1";
            txtJugador1.PlaceholderText = "Jugador 1";
            txtJugador1.Size = new Size(100, 23);
            txtJugador1.TabIndex = 7;
            // 
            // lblJugador2
            // 
            lblJugador2.AutoSize = true;
            lblJugador2.Location = new Point(10, 49);
            lblJugador2.Name = "lblJugador2";
            lblJugador2.Size = new Size(125, 15);
            lblJugador2.TabIndex = 6;
            lblJugador2.Text = "Nombre Jugador Nº 2:";
            // 
            // lblJugador1
            // 
            lblJugador1.AutoSize = true;
            lblJugador1.Location = new Point(10, 20);
            lblJugador1.Name = "lblJugador1";
            lblJugador1.Size = new Size(125, 15);
            lblJugador1.TabIndex = 5;
            lblJugador1.Text = "Nombre Jugador Nº 1:";
            // 
            // FrmCrearMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(274, 122);
            Controls.Add(btnJugar);
            Controls.Add(txtJugador2);
            Controls.Add(txtJugador1);
            Controls.Add(lblJugador2);
            Controls.Add(lblJugador1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCrearMesa";
            Text = "FrmCrearMesa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJugar;
        private TextBox txtJugador2;
        private TextBox txtJugador1;
        private Label lblJugador2;
        private Label lblJugador1;
    }
}