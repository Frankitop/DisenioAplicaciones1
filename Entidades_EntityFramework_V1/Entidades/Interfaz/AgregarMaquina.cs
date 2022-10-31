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
using Entidades.Exceptions;

namespace Interfaz
{
    public partial class AgregarMaquina : UserControl
    {
        private MaquinaContext contextoMaquina;
        private PerifericoContext contextoPeriferico;
        private Maquina aEditar;
        public AgregarMaquina(Sistema sistema)
        {
            InitializeComponent();
            this.contextoMaquina = new MaquinaContext(sistema);
            this.contextoPeriferico = new PerifericoContext(sistema);
        }

        public AgregarMaquina(Sistema sistema, Maquina maquina) : this(sistema)
        {
            this.aEditar = maquina;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.aEditar == null)
                {
                    Maquina maquina = new Maquina();
                    maquina.RAM = (int)numRAM.Value;
                    maquina.EspacioEnDisco = (int)numEspacio.Value;
                    maquina.CantidadProcesadores = txtCantidadProcesadores.Text;
                    this.contextoMaquina.AgregarMaquina(maquina);
                    this.lblFeedback.Text = "Agregada";
                }
                else 
                {
                    aEditar.RAM = (int)numRAM.Value;
                    aEditar.EspacioEnDisco = (int)numEspacio.Value;
                    aEditar.CantidadProcesadores = txtCantidadProcesadores.Text;
                    aEditar.TieneMonitor = chkMonitor.Checked;
                    this.lblFeedback.Text = "Editada";
                    Periferico periferico  = cmbPeriferico.SelectedItem as Periferico;
                    aEditar.Perifericos.Add(periferico);
                    this.contextoMaquina.ActualizarMaquina(aEditar);
                }

                this.lblFeedback.ForeColor = Color.Green;
                this.lblFeedback.Visible = true;
                this.CleanForm();
            }
            catch (ExeptionValiacionNumero ex)
            {
                this.lblFeedback.Visible = true;
                this.lblFeedback.Text = ex.Message;
                this.lblFeedback.ForeColor = Color.Red;
            }
            catch(InvalidCastException ex)
            {
                this.lblFeedback.Visible = true;
                this.lblFeedback.Text = ex.Message;
                this.lblFeedback.ForeColor = Color.Red;
            }

        }

        private void CleanForm()
        { 
            numRAM.Value = numRAM.Minimum;
            numEspacio.Value = 0;
            txtCantidadProcesadores.Text = String.Empty;
            chkMonitor.Checked = false;
            chkMonitor.Visible = false;
            cmbPeriferico.Visible = false;
            lblPeriferico.Visible = false;
        }

        private void AgregarMaquina_Load(object sender, EventArgs e)
        {
            if (this.aEditar != null)
            {
                this.txtCantidadProcesadores.Text = this.aEditar.CantidadProcesadores;
                this.numRAM.Value = this.aEditar.RAM;
                this.numEspacio.Value = this.aEditar.EspacioEnDisco;
                this.chkMonitor.Visible = true;
                this.chkMonitor.Checked = this.aEditar.TieneMonitor;
                this.cmbPeriferico.DataSource = this.contextoPeriferico.ObtenerListadoPerifericos();
                this.cmbPeriferico.Visible = true;
                this.lblPeriferico.Visible = true;
            }
        }
    }
}
