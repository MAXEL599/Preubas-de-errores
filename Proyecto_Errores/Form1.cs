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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Tuple<double, double, double, double, double>> resultados = new List<Tuple<double, double, double, double, double>>();


        private void button1_Click(object sender, EventArgs e)
        {
            Historial_Error historialError = new Historial_Error(resultados);
            historialError.Show(); // Muestra la ventana de forma no modal
            // historialError.ShowDialog(); // Muestra la ventana de forma modal
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            if (double.TryParse(txtReal.Text, out double valorReal) && double.TryParse(txtCalculo.Text, out double valorCalculo))
            {
                // Calcular el error absoluto
                double errorAbsoluto = Math.Round(Math.Abs(valorReal - valorCalculo), 2);

                // Calcular el error relativo
                double errorRelativo = errorAbsoluto / Math.Abs(valorReal);

                // Calcular el error porcentual
                double errorPorcentual = errorRelativo * 100;

                // Agregar los resultados a la lista
                resultados.Add(new Tuple<double, double, double, double, double>(valorReal, valorCalculo, errorAbsoluto, errorRelativo, errorPorcentual));

                // Mostrar los resultados
                MessageBox.Show($"Error Absoluto: {errorAbsoluto}\nError Relativo: {errorRelativo}\nError Porcentual: {errorPorcentual}%", "Resultados de Cálculo");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en ambos campos.", "Error de Entrada");
            }
        }
    }
}
