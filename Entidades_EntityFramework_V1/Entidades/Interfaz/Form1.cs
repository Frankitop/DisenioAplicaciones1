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
    public partial class Form1 : Form
    {
        private Sistema sistema;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AgregarMaquina(this.sistema));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sistema = new Sistema();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ListarMaquinas(this.sistema, this.panel1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new AgregarPeriferico(this.sistema));
        }
    }
}
