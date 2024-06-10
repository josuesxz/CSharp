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
    public partial class F_Veiculo : Form
    {
        Home f_home; //cria um objeto que todo o formulario pode ter acesso
        public F_Veiculo(string v, Home home) //parametro dos dados (o parametro de input será passado para este formulario)
        { // o home é uma instância do fomrulario princiapal, nos deu acesso para usar
            InitializeComponent();
            txt_lista_veiculo.Text = v; // a caixa de texto recebo o valor do parametro v que é o input de nomes
            home.num = 10; //envia essa informação para o formulario home 
            f_home = home; //atribui os parâmetros do formulario principal para essa classe 
        }

        private void Veiculo_Load(object sender, EventArgs e)
        {

        }

        private void txt_lista_veiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Veiculo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Propriedade do fomrulario de umevento que ele irá fechar
            f_home.txt_output_name.Text = txt_lista_veiculo.Text; //lembrar de deixar esse componente publico em sua propriedade modifiers (por pdarao ele é private)
         }
    }
}
