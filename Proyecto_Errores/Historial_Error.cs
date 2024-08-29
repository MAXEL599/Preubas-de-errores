using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Errores
{
    public partial class Historial_Error : Form
    {
        private List<Tuple<double, double, double, double, double>> resultados;

        public Historial_Error(List<Tuple<double, double, double, double, double>> resultados)
        {
            InitializeComponent();
            this.resultados = resultados;
            foreach (var resultado in resultados)
            {
                Tabla_error.Rows.Add(resultado.Item1, resultado.Item2, resultado.Item3, resultado.Item4, resultado.Item5);
            }
        }

        private void Historial_Error_Load(object sender, EventArgs e)
        {
            // Código de inicialización si es necesario
        }

        public void AgregarFila(double ValorReal, double ValorCalculado, double errorAbsoluto, double errorRelativo, double errorPorcentual)
        {
            Tabla_error.Rows.Add(ValorReal, ValorCalculado, errorAbsoluto, errorRelativo, errorPorcentual);
        }
    }
}
