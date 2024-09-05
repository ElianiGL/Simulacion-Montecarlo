using System;
using System.Collections.Generic;
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
            Random random = new Random();
            // Tamaño muestra
            int muestra = 50;
            // # Variables
            int variables = 2;

            // Loop sobre variables
            for (int j = 0; j < variables + 1; j++)
            {
                List<int> listaEnteros = new List<int>(muestra);
                // Generador numeros aleatorios
                for (int i = 0; i < muestra; i++)
                {
                    int numAleatorio = random.Next(1, 11);
                    listaEnteros.Add(numAleatorio);
                }
                // Llenar el grid
                LlenarDataGrid(listaEnteros, j + 1);
                listaEnteros.Clear();
            }
        }
        private void LlenarDataGrid(List<int> lista, int columna)
        {
            // Indicas el numero de columnas
            string numeroColumna2 = columna.ToString();
            // Determinas la cantidad de columnas
            dataGridView1.Columns.Add(numeroColumna2, "Valor" + (columna).ToString());
            // Recorres el grid para cada fila llenas los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
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
        private void Descargar_Click(object sender, EventArgs e)
        {
            DescargasExcel(dataGridView1);
        }
    }
}