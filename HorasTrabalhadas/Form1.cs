namespace HorasTrabalhadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Cpf = int.Parse(txtCpf.Text); 
            funcionario.Nome = txtNome.Text;
            funcionario.ValorHora = int.Parse(txtVh.Text);
            funcionario.Horas = int.Parse(txtHt.Text);
            funcionario.CalculaSalario();

            txtSalario.Text = funcionario.Salario.ToString("n2");
        }
    }
}