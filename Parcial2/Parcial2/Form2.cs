using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Form2 : Form
    {
        Persona per = new Persona();
        GuardarFormulario guardar = new GuardarFormulario();
        GuardarUsuario guardarU = new GuardarUsuario();
        
        text txt = new text();
        string nombreDado;
        string apellidoDado;
        string nombreUsuarioDado;
        string contraseñaDada;
        public Form2()
        {            
            InitializeComponent();
        }

        Form1 form = new Form1();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            nombreDado = textBox1.Text;
            apellidoDado = textBox2.Text;
            nombreUsuarioDado = textBox3.Text;
            contraseñaDada = textBox4.Text;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor");
            }

            else if(textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Las contraseñas deben ser iguales");
            }

            else if(textBox4.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener 6 caracteres como minimo");
            }

            else
            {
                if(File.Exists("./Usuarios/" + textBox3.Text +  ".txt"))
                {
                    MessageBox.Show("Este nombre de usuario ya está tomado");
                }
                
                else
                {
                    guardarU.GuardarArchivo(nombreDado, apellidoDado, nombreUsuarioDado, contraseñaDada);
                    Close();
                    form.Show();
                }
                    

            }



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.SelectionStart == 0)
            {
                if (e.KeyChar == 32)
                {
                    e.Handled = true;

                }

                
            }
            txt.textOnlySpace(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.SelectionStart == 0)
            {
                if (e.KeyChar == 32)
                {
                    e.Handled = true;

                }


            }
            txt.textOnlySpace(e);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            form.Show();
        }
    }
}
