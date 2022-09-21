using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Interfaz
{
    public partial class ListarMaquinas : UserControl
    {
        private Sistema sistema;
        private Panel plnMain;
        private Maquina maquinaSeleccionada;
        public ListarMaquinas(Sistema sistema, Panel plnMain)
        {
            InitializeComponent();
            this.sistema = sistema;
            this.plnMain = plnMain;
        }

        private void ListarMaquinas_Load(object sender, EventArgs e)
        {
            this.lstMaquinas.DataSource = this.sistema.Maquinas;
        }

        private void lstMaquinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maquina seleccionada = (Maquina)this.lstMaquinas.SelectedItem;
            this.maquinaSeleccionada = seleccionada;

        }

        private void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            this.plnMain.Controls.Clear();
            this.plnMain.Controls.Add(new AgregarMaquina(this.sistema));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.maquinaSeleccionada != null)
            {
                this.plnMain.Controls.Clear();
                this.plnMain.Controls.Add(new AgregarMaquina(this.sistema, this.maquinaSeleccionada));
            }
            else 
            {
                MessageBox.Show("Debe seleccionar una maquina", "Error");
            }
        }
    }
}
