namespace CadernoDeOracao.App.Handlers
{
    public class NaoImplementadoHandler
    {
        public static void MostrarAviso()
        {
            _ = MessageBox.Show(
                "Esta função ainda não foi implementada.",
                "Não Implementado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
