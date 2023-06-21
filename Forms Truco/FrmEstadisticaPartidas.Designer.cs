namespace Forms_Truco
{
    partial class FrmEstadisticaPartidas
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
            dataGridViewEstadistica = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstadistica).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEstadistica
            // 
            dataGridViewEstadistica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstadistica.Dock = DockStyle.Fill;
            dataGridViewEstadistica.Location = new Point(0, 0);
            dataGridViewEstadistica.Name = "dataGridViewEstadistica";
            dataGridViewEstadistica.RowTemplate.Height = 25;
            dataGridViewEstadistica.Size = new Size(800, 450);
            dataGridViewEstadistica.TabIndex = 0;
            // 
            // FrmEstadisticaPartidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewEstadistica);
            Name = "FrmEstadisticaPartidas";
            Text = "FrmEstadisticaPartidas";
            Load += FrmEstadisticaPartidas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstadistica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEstadistica;
    }
}