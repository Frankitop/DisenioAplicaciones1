
namespace Interfaz
{
    partial class AgregarMaquina
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCantidadProcesadores = new System.Windows.Forms.TextBox();
            this.numRAM = new System.Windows.Forms.NumericUpDown();
            this.numEspacio = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPeriferico = new System.Windows.Forms.ComboBox();
            this.lblPeriferico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadProcesadores
            // 
            this.txtCantidadProcesadores.Location = new System.Drawing.Point(339, 140);
            this.txtCantidadProcesadores.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadProcesadores.Name = "txtCantidadProcesadores";
            this.txtCantidadProcesadores.Size = new System.Drawing.Size(159, 22);
            this.txtCantidadProcesadores.TabIndex = 1;
            // 
            // numRAM
            // 
            this.numRAM.Location = new System.Drawing.Point(339, 226);
            this.numRAM.Margin = new System.Windows.Forms.Padding(4);
            this.numRAM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRAM.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numRAM.Name = "numRAM";
            this.numRAM.Size = new System.Drawing.Size(160, 22);
            this.numRAM.TabIndex = 2;
            this.numRAM.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // numEspacio
            // 
            this.numEspacio.Location = new System.Drawing.Point(339, 318);
            this.numEspacio.Margin = new System.Windows.Forms.Padding(4);
            this.numEspacio.Name = "numEspacio";
            this.numEspacio.Size = new System.Drawing.Size(160, 22);
            this.numEspacio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Procesadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Disco";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(325, 504);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(185, 28);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFeedback.Location = new System.Drawing.Point(336, 457);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 16);
            this.lblFeedback.TabIndex = 8;
            this.lblFeedback.Visible = false;
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Location = new System.Drawing.Point(356, 361);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(111, 20);
            this.chkMonitor.TabIndex = 9;
            this.chkMonitor.Text = "Tiene monitor";
            this.chkMonitor.UseVisualStyleBackColor = true;
            this.chkMonitor.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Maquina";
            // 
            // cmbPeriferico
            // 
            this.cmbPeriferico.FormattingEnabled = true;
            this.cmbPeriferico.Location = new System.Drawing.Point(339, 430);
            this.cmbPeriferico.Name = "cmbPeriferico";
            this.cmbPeriferico.Size = new System.Drawing.Size(159, 24);
            this.cmbPeriferico.TabIndex = 10;
            this.cmbPeriferico.Visible = false;
            // 
            // lblPeriferico
            // 
            this.lblPeriferico.AutoSize = true;
            this.lblPeriferico.Location = new System.Drawing.Point(374, 399);
            this.lblPeriferico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriferico.Name = "lblPeriferico";
            this.lblPeriferico.Size = new System.Drawing.Size(64, 16);
            this.lblPeriferico.TabIndex = 11;
            this.lblPeriferico.Text = "Periferico";
            this.lblPeriferico.Visible = false;
            // 
            // AgregarMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPeriferico);
            this.Controls.Add(this.cmbPeriferico);
            this.Controls.Add(this.chkMonitor);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numEspacio);
            this.Controls.Add(this.numRAM);
            this.Controls.Add(this.txtCantidadProcesadores);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarMaquina";
            this.Size = new System.Drawing.Size(876, 590);
            this.Load += new System.EventHandler(this.AgregarMaquina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidadProcesadores;
        private System.Windows.Forms.NumericUpDown numRAM;
        private System.Windows.Forms.NumericUpDown numEspacio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPeriferico;
        private System.Windows.Forms.Label lblPeriferico;
    }
}
