namespace Forms_Truco
{
    partial class FrmInicio
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
            menuStripPrincipal = new MenuStrip();
            CrearPartidaToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            historialDeManosRepartidasXMLToolStripMenuItem = new ToolStripMenuItem();
            historialDeResultadosSQLToolStripMenuItem = new ToolStripMenuItem();
            historialDeFloresTXTToolStripMenuItem = new ToolStripMenuItem();
            historialDeFloresJSONToolStripMenuItem = new ToolStripMenuItem();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { CrearPartidaToolStripMenuItem, historialToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(686, 24);
            menuStripPrincipal.TabIndex = 4;
            menuStripPrincipal.Text = "menuStrip1";
            // 
            // CrearPartidaToolStripMenuItem
            // 
            CrearPartidaToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            CrearPartidaToolStripMenuItem.Name = "CrearPartidaToolStripMenuItem";
            CrearPartidaToolStripMenuItem.Size = new Size(84, 20);
            CrearPartidaToolStripMenuItem.Text = "CrearPartida";
            CrearPartidaToolStripMenuItem.Click += CrearPartidaToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialDeManosRepartidasXMLToolStripMenuItem, historialDeResultadosSQLToolStripMenuItem, historialDeFloresTXTToolStripMenuItem, historialDeFloresJSONToolStripMenuItem });
            historialToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(76, 20);
            historialToolStripMenuItem.Text = "Estadisticas";
            // 
            // historialDeManosRepartidasXMLToolStripMenuItem
            // 
            historialDeManosRepartidasXMLToolStripMenuItem.Name = "historialDeManosRepartidasXMLToolStripMenuItem";
            historialDeManosRepartidasXMLToolStripMenuItem.Size = new Size(257, 22);
            historialDeManosRepartidasXMLToolStripMenuItem.Text = "Historial de Manos Repartidas (XML)";
            // 
            // historialDeResultadosSQLToolStripMenuItem
            // 
            historialDeResultadosSQLToolStripMenuItem.Name = "historialDeResultadosSQLToolStripMenuItem";
            historialDeResultadosSQLToolStripMenuItem.Size = new Size(257, 22);
            historialDeResultadosSQLToolStripMenuItem.Text = "Historial de Resultados (SQL)";
            // 
            // historialDeFloresTXTToolStripMenuItem
            // 
            historialDeFloresTXTToolStripMenuItem.Name = "historialDeFloresTXTToolStripMenuItem";
            historialDeFloresTXTToolStripMenuItem.Size = new Size(254, 22);
            historialDeFloresTXTToolStripMenuItem.Text = "Historial de Pardas (TXT)";
            // 
            // historialDeFloresJSONToolStripMenuItem
            // 
            historialDeFloresJSONToolStripMenuItem.Name = "historialDeFloresJSONToolStripMenuItem";
            historialDeFloresJSONToolStripMenuItem.Size = new Size(254, 22);
            historialDeFloresJSONToolStripMenuItem.Text = "Historial de Flores (JSON)";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(686, 450);
            Controls.Add(menuStripPrincipal);
            Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            IsMdiContainer = true;
            Name = "FrmInicio";
            Text = "Truco Argentino";
            WindowState = FormWindowState.Maximized;
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem CrearPartidaToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem historialDeManosRepartidasXMLToolStripMenuItem;
        private ToolStripMenuItem historialDeResultadosSQLToolStripMenuItem;
        private ToolStripMenuItem historialDeFloresTXTToolStripMenuItem;
        private ToolStripMenuItem historialDeFloresJSONToolStripMenuItem;
    }
}