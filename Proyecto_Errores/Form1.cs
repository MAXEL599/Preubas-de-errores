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

        private void button1_Click(object sender, EventArgs e)
        {
            Historial_Error historialError = new Historial_Error();
            historialError.Show(); // Muestra la ventana de forma no modal
            // historialError.ShowDialog(); // Muestra la ventana de forma modal
        }
    }
}
