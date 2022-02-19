using CadernoDeOracao.App.Handlers;

namespace CadernoDeOracao.App
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
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