namespace ProyectoYoga_PixelPulse
{
    public partial class Form1 : Form
    {
        public Form1()
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
            MorfemaTextBox.Text = string.Join("\r\n", Morfema.TraducirMorfema(textoAMorfema));
        }
    }
}