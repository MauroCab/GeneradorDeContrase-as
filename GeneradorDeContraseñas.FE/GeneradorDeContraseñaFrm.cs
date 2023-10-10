using System;
using GeneradorDeContraseñas.BE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorDeContraseñas.FE
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        public void btGenerar_Click(object sender, EventArgs e)
        {
            Generador generador = new Generador();

            int longitud = Convert.ToInt32(txtbxLongitud.Text);

            bool incluirMayusculas = chkMayusculas.Checked;
            bool incluirNumeros = chkNumeros.Checked;
            bool incluirSimbolos = chkSimbolos.Checked;

            string contraseña = generador.GenerarContraseña(longitud, incluirMayusculas, incluirNumeros, incluirSimbolos);

            lblResultado.Text = "La contraseña generada es" + contraseña;
            

        }

        
    }
}
