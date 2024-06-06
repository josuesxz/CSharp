using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus; 

namespace Comunica_FX5
{
    public partial class Form1 : Form
    {
        ModbusClient PLC = new ModbusClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLC.IPAddress = Convert.ToString(textBox1.Text);
            PLC.Port = Convert.ToInt32(textBox2.Text);

            try{
                PLC.Connect();
            }

            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

            if(PLC.Connected == true){
                label4.Text = "Connected";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PLC.Disconnect();
            label4.Text = "Disconnected";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            switch (PLC.Connected){
                case true:
                    // Padrão do M1 no Mobus é 8193
                    PLC.WriteSingleCoil(8193, checkBox2.Checked);
                    break;

                case false:
                    MessageBox.Show("CLP Desconectado");
                    break;

                default:
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (PLC.Connected) {
                case true:
                    // Padrão do M0 no Mobus é 8192
                    PLC.WriteSingleCoil(8192, checkBox1.Checked);
                    break;

                case false:
                    MessageBox.Show("CLP Desconectado");
                    break;

                default:
                    break;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            switch (PLC.Connected){
                case true:
                    // Padrão do Y0 no Mobus é 0
                    PLC.WriteSingleCoil(0, checkBox3.Checked);
                    break;

                case false:
                    MessageBox.Show("CLP Desconectado");
                    break;

                default:
                    break;
            }
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            switch (PLC.Connected) {
                case true:
                    // Padrão do Y1 no Mobus é 1
                    PLC.WriteSingleCoil(1, checkBox4.Checked);
                    break;

                case false:
                    MessageBox.Show("CLP Desconectado");
                    break;

                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch(PLC.Connected) {
                case true:
                    PLC.WriteSingleRegister(0, Convert.ToInt32(textBox3.Text)); //Os parametros são (qual registrador, o que vai ser enviado) 
                    PLC.WriteSingleRegister(1, Convert.ToInt32(textBox4.Text));
                    break;

                case false:
                    MessageBox.Show("CLP Desconectado");
                    break;

                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           switch (PLC.Connected) {
                case true:
                    // Leitura do D0, D1 e D2
                    int[] D = PLC.ReadHoldingRegisters(0, 3); //tamando do módulo do vetor
                    textBox5.Text = D[0].ToString();
                    textBox6.Text = D[1].ToString();
                    textBox7.Text = D[2].ToString();
                    break;

                case false:
                    MessageBox.Show("CLP Desconectado");
                    break;

                default:
                    break;
           }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
