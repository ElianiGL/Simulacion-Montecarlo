using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_de_Montecarlo.Algoritmos
{
    public class Simulacion
    {
        public Simulacion() { }
    }
    public List<int> GenerarValores(int n)
    {
        List<int> listaSalida = new List<int>();
        for (int i = 0; i < n; i++)
        {
            listaSalida.Add(5 * (i + 1));
        }
        return listaSalida;
    }
    public List<int> SimulacionMontecarlo(int a, int b, int c, int d)
    {
    }
}