using System.Windows.Forms;
//using Simulacion_de_Montecarlo.Algoritmo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Simulacion_de_Montecarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Ejecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejecutando la simulación de Monte Carlo");
            // Condicion de vacio
            if (textBox1.Text.Equals("") ||
               textBox2.Text.Equals("")  ||
               textBox3.Text.Equals("")  ||
               textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }

            // Inicialización de parámetros
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);

            // Condiciones
            if (c >= d)
            {
                MessageBox.Show("El valor del rango inferior tiene que ser menor que el del rango superior");
                return;
            }
            if (d <= c)
            {
                MessageBox.Show("El valor del rango superior tiene que ser mayor que el del rango inferior");
                return;
            }

            // Imprecisión
            Simulacion algoritmo = new Simulacion();
            List<int> listaEnteros = algoritmo.MonteCarlo(a, b, c, d);
            LlenarDataGrid(listaEnteros);
        }
        private void LlenarDataGrid(List<int> lista)
        {
            // Número de columnas
            // Tiene que ser por el for 1+(numero de experimentos)

            // Cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            // n experimentos
            dataGridView1.Columns.Add(numeroColumnaFINAL, "X(i)");
            // Nombres # numero de experimentos
            // Nombre "X(i)"

            //Llenas los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                // n experimentos
            }
        }
        public void DescargasExcel(DataGridView data)
        {
            // Instalar excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            // Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }

            // Construyes filas y Llenas valores
            int indiceFilas = 0;
            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }
        // Descarga Excel no se hizo con el doble click al botón
        private void button0_Click_1(object sender, EventArgs e)
        {
            DescargasExcel(dataGridView1);
        }
    }
}