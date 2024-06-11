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
    public partial class F_Checked : Form
    {
        public F_Checked()
        {
            InitializeComponent();
        }

        private void btn_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach(string t in cb_transportes.CheckedItems){ //propriedade checkedItems ele cria uma coleção de somente os que foram selecionados 
                txt += t + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear(); // método que limpa todo os elementos do cb_transportes
        }

        private void btn_rst_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear(); //limpa para evitar acumulativo de itens

            /*cb_transportes.Items.Add("Carro", false); //adiciona um novo item
            cb_transportes.Items.Add("Avião", false);
            cb_transportes.Items.Add("Navio", false);
            cb_transportes.Items.Add("Ônibus", false);
            cb_transportes.Items.Add("Trem", false); */

            //Adiciona de uma forma mais profissional
            List<string> tr = new List<string>(); //criando uma lista pronta
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");
            cb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_novo.Text != " ") { 
            cb_transportes.Items.Add(txt_novo.Text, false);
            txt_novo.Clear();
            txt_novo.Focus();
            }

            else{
                MessageBox.Show("Não pode ficar vazio!");
            }
        }
    }
}
