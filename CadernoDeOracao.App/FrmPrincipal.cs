using CadernoDeOracao.App.Handlers;

using System.Reflection;

namespace CadernoDeOracao.App
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
#pragma warning disable CS8602 // Desrefer�ncia de uma refer�ncia possivelmente nula.
            toolStripStatusVersao.Text = string.Format("Vers�o {0}", 
                Assembly.GetEntryAssembly().GetName().Version.ToString());
#pragma warning restore CS8602 // Desrefer�ncia de uma refer�ncia possivelmente nula.
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