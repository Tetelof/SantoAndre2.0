namespace SantoAndre
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro(){}

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new Usuario();
            user.Nome = txtCadastroNome.Text;
            user.CPF = txtCadastroCPF.Text;
            user.Telefone = txtCadastroTelefone.Text;
            user.Endereco = $"{txtCadastroRua.Text}, "+
                $"{txtCadastroNumero.Text}, "+
                $"{txtCadastroBairro.Text}, "+
                $"{txtCadastroCidade.Text}, "+
                $"{cbxCadastroEstado.Text}";

            if (txtCadastroSenha.Text == txtConfimaSenha.Text)
            {
                user.Senha = txtCadastroSenha.Text;
                user.NovoUsuario();

                MessageBox.Show("É um prazer ter você conosco!:) \n" +
                    "Sua agencia e conta são: \n" +
                    $"Agencia: {user.Agencia}, Conta: {user.Conta}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Senhas não coincidem!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfimaSenha_Leave(object sender, EventArgs e)
        {
            if (txtCadastroSenha.Text != txtConfimaSenha.Text)
            {
                lblAlertaSenha.Visible = true;
            }
            else
            {
                lblAlertaSenha.Visible = false;
            }
        }

        private void txtConfimaSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCadastroSenha.Text != txtConfimaSenha.Text)
            {
                lblAlertaSenha.Visible = true;
            }
            else
            {
                lblAlertaSenha.Visible = false;
            }
        }
    }
}