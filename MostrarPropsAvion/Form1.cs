using LibreriaAviones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarPropsAvion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPropsAvionComercial_Click(object sender, EventArgs e)
        {
         AvionComercial nuevoAvion = new AvionComercial("Pablo", "Javier", "Laura.", 200, "Aerolíneas Argentinas");

         MessageBox.Show($"{nuevoAvion}");

        }
    }
}
