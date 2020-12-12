using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercicio6
{
    public partial class frmConversorDeMilhaParaKm : Form
    {
        public frmConversorDeMilhaParaKm()
        {
            InitializeComponent();
            lblKm.Text = "0";
        }

        private void clickou_converter(object sender, EventArgs e)
        {
            MilhaMar n1 = new MilhaMar(double.Parse(txtMilha.Text));
            n1.ConverterMilhaMarParaMetros();
            lblKm.Text = (n1.GetConvertido()/1000).ToString() + " " + "km";
        }
    }
}
