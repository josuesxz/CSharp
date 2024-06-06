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
    public partial class Veiculo : Form
    {
        public Veiculo(string v) //parametro dos dados (o parametro de input será passado para este formulario)
        {
            InitializeComponent();
            txt_lista_veiculo.Text = v; // a caixa de texto recebo o valor do parametro v que é o input de nomes
        }

        private void Veiculo_Load(object sender, EventArgs e)
        {

        }

        private void txt_lista_veiculo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
