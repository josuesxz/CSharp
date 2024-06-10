using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao_01
{
    public partial class F_Check_Box : Form
    {
        public F_Check_Box()
        {
            InitializeComponent();
        }

        private void btn_transporte_Click(object sender, EventArgs e)
        {
            string txt = "";
            if (cb_carro.Checked){ //verifica se foi clicado
                txt += cb_carro.Text + ", ";
            }
            if (cb_aviao.Checked){
                txt += cb_aviao.Text + ", ";
            }
            if (cb_navio.Checked){
                txt += cb_navio.Text + ", ";
            }
            if (cb_onibus.Checked){
                txt += cb_onibus.Text + ", ";
            }

            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked){
                MessageBox.Show(cb_patinete.Text);
            }
        }
    }
}
