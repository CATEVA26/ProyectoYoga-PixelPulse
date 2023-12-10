namespace ProyectoYoga_PixelPulse
{
    public partial class DiccionarioYoga : Form
    {
        public DiccionarioYoga()
        {
            InitializeComponent();

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int posX = (screenWidth - formWidth) / 2;
            int posY = (screenHeight - formHeight) / 2;

            // Establecer la posición de inicio de la ventana
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(posX, posY);


            ESTextBox.ReadOnly = true;
            ENTextBox.ReadOnly = true;
            MorfemaTextBox.ReadOnly = true;
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

        private async void BusquedaButton_Click(object sender, EventArgs e)
        {

            string textoAMorfema = BusquedaTextBox.Text;
            textoAMorfema = char.ToUpper(textoAMorfema[0]) + textoAMorfema.Substring(1).ToLower();

            // Verificar si el texto está vacío o solo contiene números
            if (string.IsNullOrWhiteSpace(textoAMorfema))
            {
                MessageBox.Show("Por favor, ingrese la palabra que deseas traducir");
                return;  // Salir del método si hay un error
            }
            if (textoAMorfema.All(char.IsDigit))
            {
                BusquedaTextBox.Text = "";
                MessageBox.Show("Por favor, ingrese un texto válido para la búsqueda.");
                return;  // Salir del método si hay un error
            }

            

            var Traductor = new Traductor();
            Postura postura = new Postura(textoAMorfema);
            //MorfemaTextBox.Text = string.Join("\r\n", postura.GetMorfemas());
            MorfemaTextBox.Text = string.Join("\r\n", postura.GetMorfemas()?.Where(m => m != null) ?? Enumerable.Empty<string>());

            ESTextBox.Text = postura.GetDescripción();
            ENTextBox.Text = await Traductor.Traducir(postura.GetDescripción());
            if (ENTextBox.Equals(string.Empty))
            {
                MessageBox.Show("Lo sentimos no se ha realizado la traducción");
            }
            string traduccionAEs = postura.TraducirAEs(textoAMorfema);
            if (traduccionAEs == null)
            {

                ENTextBox.Text = "";
                MessageBox.Show($"La palabra '{textoAMorfema}' no se encuentra en el diccionario");
                return;
            }
        }

        private void ENTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}