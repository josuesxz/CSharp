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
    public partial class Home : Form
    {
        public int num;
        public Home()
        {
            InitializeComponent();
            num = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_input_name.Text == " "){ //condição se o elemento estiver vazio 
                MessageBox.Show("Digite um nome valido");
                txt_input_name.Focus(); //posiciona o cursor para digitar dentro deste text box
                return;
            }
            txt_output_name.Text += txt_input_name.Text + ", "; //adiciona na lista de forma concatenda
            txt_input_name.Clear(); //limpa apos adicionar
            txt_input_name.Focus(); //posiciona o cursor 
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            txt_output_name.Clear(); //deleta os dados na caixa de texto 
            txt_input_name.Clear();
            txt_input_name.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculo veiculo = new F_Veiculo(txt_output_name.Text, this); //instancia o objeto que é o formulario
            veiculo.ShowDialog(); //ao clicar este objeto é chamado 
        }

        private void btn_val_num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Check_Box fCheckBox = new F_Check_Box();
            fCheckBox.ShowDialog();
        }
    }
}
