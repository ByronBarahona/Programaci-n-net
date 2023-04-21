using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba1.Model;

namespace Prueba1.GUI
{
    public partial class Home_Form : Form
    {
        Atributos atr = new Atributos();
        public Home_Form()
        {
            InitializeComponent();
            CargaDatos();
        }

        public void CargaDatos()
        {
            foreach(var x in atr.Cliente)
            {
                Cbox_Cliente.Items.Add(x);
            }
            foreach(var x in atr.Categoria)
            {
                Cbox_Categoria.Items.Add(x);
            }
        }


    }
}
