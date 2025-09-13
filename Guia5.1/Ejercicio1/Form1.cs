using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            List<string> listaPatentes = new List<string> { "OXY 333", "AA1234", "AA123AAA", "OYZ 013", "AAA 123", "BCD 456", "AB 123 CD", "YZ5432EF", "QW 3456 AB" };

            IProceso proceso = null;
            if(rbString.Checked) {
                proceso = new StringProceso();
            }
            else 
            if (rbRegex.Checked) {
                proceso = new RegexProceso();
            }
            else
            {
                MessageBox.Show("Debes seleccionar alguna opción!");
            }

            lsbVer.Items.Clear();
            foreach(string patente in listaPatentes)
            {
                string descripcion = proceso.Procesar(patente);
                lsbVer.Items.Add($"Patente: {patente} - Descripción: {descripcion}");
            }
        }
    }
}
