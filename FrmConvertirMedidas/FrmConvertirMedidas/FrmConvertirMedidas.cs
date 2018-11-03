using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConvertirMedidas
{
    public partial class FrmConvertirMedidas : Form
    {
        public FrmConvertirMedidas()
        {
            InitializeComponent();
        }

        private void btnConvertirPulgadasEnCentimetros_Click(object sender, EventArgs e)
        {
            LogicaOperaciones logica = new LogicaOperaciones();
            tbCentimetros.Text = logica.Operar(tbPulgadas.Text,
                                             btnConvertirPulgadasEnCentimetros.Text);
        }

        private void btnConvertirCentimetrosEnPulgadas_Click(object sender, EventArgs e)
        {
            LogicaOperaciones logica = new LogicaOperaciones();
            tbPulgadas.Text = logica.Operar(tbCentimetros.Text,
                                             btnConvertirCentimetrosEnPulgadas.Text);
        }
    }
}
