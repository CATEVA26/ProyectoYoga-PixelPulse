namespace ProyectoYoga_PixelPulse
{
    public partial class DiccionarioYoga : Form
    {
        public DiccionarioYoga()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BusquedaButton_Click(object sender, EventArgs e)
        {
            string textoAMorfema = BusquedaTextBox.Text;
            Postura postura = new Postura(textoAMorfema);
            MorfemaTextBox.Text = string.Join("\r\n", postura.GetMorfemas());
            ESTextBox.Text = postura.GetDescripción();
        }
    }
}