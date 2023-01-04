namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Int32.Parse(txtValorA.Text)  + Int32.Parse(txtValorB.Text)).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Int32.Parse(txtValorA.Text) - Int32.Parse(txtValorB.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Int32.Parse(txtValorA.Text) * Int32.Parse(txtValorB.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Int32.Parse(txtValorA.Text) / Int32.Parse(txtValorB.Text)).ToString();
        }
    }
}