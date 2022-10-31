using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class AgregarPeriferico : UserControl
    {
        private PerifericoContext contextoPeriferico;
        public AgregarPeriferico(Sistema sistema)
        {
            InitializeComponent();
            this.contextoPeriferico = new PerifericoContext(sistema);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Periferico periferico = new Periferico();
            periferico.Nombre = this.txtNombrePeriferico.Text;

            this.contextoPeriferico.AgregarPeriferico(periferico);

            txtNombrePeriferico.Text = string.Empty;
        }
    }
}
