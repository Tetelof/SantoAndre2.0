namespace SantoAndre
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Usuario user = UsuarioSingleton.GetUsuario();
            lblBoasVindas.Text = $"Olá {user.Nome}!";
            lblSaldo.Text = "Saldo R$2.300";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var frmprimeiroContato = new FrmPrimeiroContato();
            frmprimeiroContato.MdiParent = MDISigleton.GetMDIParent();
            frmprimeiroContato.Show();
            this.Close();
        }

        private void btnPix_Click(object sender, EventArgs e)
        {
            pnlPix.Visible = true;
        }

        private void btnPixVoltar_Click(object sender, EventArgs e)
        {
            pnlPix.Visible = false;
        }
    }
}