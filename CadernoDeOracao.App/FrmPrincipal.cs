using CadernoDeOracao.App.Handlers;

using System.Reflection;

namespace CadernoDeOracao.App
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            toolStripStatusVersao.Text = string.Format("Versão {0}", 
                Assembly.GetEntryAssembly().GetName().Version.ToString());
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
        }

        private void ToolStripButtonNovo_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void ToolStripButtonEditar_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void ToolStripButtonApagar_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void ToolStripButtonRespondido_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void ToolStripButtonNaoRespondido_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void ToolStripButtonConfiguracoes_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void ToolStripButtonSobre_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }
    }
}