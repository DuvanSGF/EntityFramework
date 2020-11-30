using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaDato;
using capaNegocio;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NegocioUniversidad metodosNegocio = new NegocioUniversidad();
        EntidadUniversidad entidadUniv = new EntidadUniversidad();

        private void Guardar()
        {
            entidadUniv.id = Convert.ToInt32(txtCod.Text);
            entidadUniv.first_name = txtUniv.Text;

            metodosNegocio.Guardar(entidadUniv);

        }

        private void LlenarGrid()
        {
            var datos = metodosNegocio.MostrarDatos();

            gridDatos.DataSource = datos;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            LlenarGrid();

        }
    }
}
