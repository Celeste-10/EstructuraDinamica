using EstructuraDinamica.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDinamica.Formularios
{
    public partial class FrmPila2 : Form
    {
        Stack<Expediente> pila= new Stack<Expediente>(); 
        public FrmPila2()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Expediente est=new Expediente();
            est.Nombres= tbNombres.Text;
            est.Apellidos= tbApellidos.Text;
            est.Promedio= int.Parse(tbPromedio.Text);
            pila.Push(est);
            LlenarList();
        }

        private void LlenarList()
        {
            lstPromedios.Items.Clear();
            foreach(Expediente est in pila.Reverse())
            {
                lstPromedios.Items.Add(est.Promedio);
            }
        }

        private void lstPromedios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
