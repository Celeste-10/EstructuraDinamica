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
    public partial class FrmPila : Form
    {
        Stack<int> pila= new Stack<int>(); //Creación de la pila
        public FrmPila()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int elemento= int.Parse(tbNumero.Text);
            pila.Push(elemento); //Agrega un elemento a la Pila

            lblPila.Text = MostrarElementos();
            tbNumero.Focus();

        }

        private string MostrarElementos()
        {
            string msn = "";

            foreach(int i in pila)
            {
                msn += " " + i.ToString() + " |";
            }

            return msn;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            { 
                pila.Pop();
                lblPila.Text = MostrarElementos();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("La pila está vacía, no se puede eliminar elementos, porque la pila esta vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMostrarUltimo_Click(object sender, EventArgs e)
        {
            pila.Peek();
            lblPila.Text = MostrarElementos();
        }

        private string MostrarUltimo()
        {
            
        }
    }

}
