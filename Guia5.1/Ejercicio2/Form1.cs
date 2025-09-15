using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbString.Enabled = false;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            IProceso proceso = null;
            Intimacion intimacion = null;

            if(rbRegex.Checked) {
                proceso = new RegexProceso();
                intimacion = proceso.ProcesarDatos(tbTexto.Text);

                lsbResultado.Items.Clear();
                lsbResultado.Items.AddRange(intimacion.ToString());
            }
            else
            if(rbString.Checked) {
                proceso = new StringProceso();
                intimacion = proceso.ProcesarDatos(tbTexto.Text);
            }

            lsbResultado.Items.Clear();
            lsbResultado.Items.AddRange(intimacion.ToString());

        }
    }
}
