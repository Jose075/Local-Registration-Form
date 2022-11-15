using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form3 : Form
    {
        GuardarFormulario guardarF = new GuardarFormulario();
        Form6 form6 = new Form6();
        Form4 form4 = new Form4();
        


        public string area;
        public string tanda;
        public string periodo;
        public string nombreU;



        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("Debes llenar los campos");
            }
            else
            {

                form4.tipoSolicitud = comboBox1.Text;
                form4.areaAcademica = comboBox2.Text;
                form4.TandaEstudio = comboBox3.Text;
                form4.periodoIngreso = comboBox4.Text;
                form4.nombreU = nombreU;
                Hide();
                form4.ShowDialog();

            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
