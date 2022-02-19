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

        private void toolStripButtonNovo_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void toolStripButtonApagar_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void toolStripButtonRespondido_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void toolStripButtonNaoRespondido_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void toolStripButtonConfiguracoes_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }

        private void toolStripButtonSobre_Click(object sender, EventArgs e)
        {
            NaoImplementadoHandler.MostrarAviso();
        }
    }
}