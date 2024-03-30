namespace puertoMasAlegre
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            string login, password;
            login = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();
            if (login == "Puerto" && password == "mas alegre")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            paginaPrincipas frm = new paginaPrincipas();
            frm.Show();
        }
    }
}
