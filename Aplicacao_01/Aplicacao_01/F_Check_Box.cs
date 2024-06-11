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
        List<CheckBox> trans = new List<CheckBox>();
        public F_Check_Box()
        {
            InitializeComponent();
            trans.Add(cb_carro);
            trans.Add(cb_aviao);
            trans.Add(cb_navio);
            trans.Add(cb_onibus);
        }

        private void btn_transporte_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox t in trans){ // faz uma varredura em cada elemento da lista
                if (t.Checked){
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked){
                MessageBox.Show(cb_patinete.Text); //ao ser clicado gera uma mensagem automaticamente
            }
        }
    }
}
