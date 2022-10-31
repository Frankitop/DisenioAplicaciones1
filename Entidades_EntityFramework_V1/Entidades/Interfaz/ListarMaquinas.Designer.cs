
namespace Interfaz
{
    partial class ListarMaquinas
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
            this.lstMaquinas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMaquina = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMaquinas
            // 
            this.lstMaquinas.FormattingEnabled = true;
            this.lstMaquinas.ItemHeight = 16;
            this.lstMaquinas.Location = new System.Drawing.Point(126, 80);
            this.lstMaquinas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMaquinas.Name = "lstMaquinas";
            this.lstMaquinas.Size = new System.Drawing.Size(484, 244);
            this.lstMaquinas.TabIndex = 0;
            this.lstMaquinas.SelectedIndexChanged += new System.EventHandler(this.lstMaquinas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado De Maquinas";
            // 
            // btnAgregarMaquina
            // 
            this.btnAgregarMaquina.Location = new System.Drawing.Point(126, 340);
            this.btnAgregarMaquina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarMaquina.Name = "btnAgregarMaquina";
            this.btnAgregarMaquina.Size = new System.Drawing.Size(184, 26);
            this.btnAgregarMaquina.TabIndex = 2;
            this.btnAgregarMaquina.Text = "Agregar Maquina";
            this.btnAgregarMaquina.UseVisualStyleBackColor = true;
            this.btnAgregarMaquina.Click += new System.EventHandler(this.btnAgregarMaquina_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(366, 340);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(178, 26);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Maquina";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ListarMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarMaquina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMaquinas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListarMaquinas";
            this.Size = new System.Drawing.Size(753, 393);
            this.Load += new System.EventHandler(this.ListarMaquinas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMaquinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMaquina;
        private System.Windows.Forms.Button btnEditar;
    }
}
