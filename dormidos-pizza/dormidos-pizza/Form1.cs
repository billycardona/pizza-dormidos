using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dormidos_pizza
{
    public partial class pizza : Form
    {
        public pizza()
        {
            InitializeComponent();
        }
        //confirmacion msj
        private void mesajeconfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "dormidoz pizza", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void mesajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "dormidoz pizza", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //acciones de la tabla 
        private void accionestabla()
        {
            data_listado.Columns[0].Visible = false;

            data_listado.Columns[1].HeaderText = "nombre";
            data_listado.Columns[2].HeaderText = "descripcion ";



        }
        //mostrar registros 
        private void mostrarregistro()
        {
            data_listado.DataSource = txt_Nombre.Text;
            accionestabla();
        }

        private void buscarregistro()
        {
            data_listado.DataSource = txt_descripcion.Text;
            
            accionestabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txt_descripcion.Text;

            MessageBox.Show(nombre);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
