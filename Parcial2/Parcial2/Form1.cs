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
    public partial class Form1 : Form
    {
        Form3 form3 = new Form3();
        

        public string nombre;
        public string apellido;
        public string nombreU;
        public string contraseña;
        public string miArchivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string carpetaU = Application.StartupPath + @"./Usuarios";
            string carpetaF = Application.StartupPath + @"./Formulario";

            if (!Directory.Exists(carpetaU))
            {
                Directory.CreateDirectory(carpetaU);
            }

            if (!Directory.Exists(carpetaF))
            {
                Directory.CreateDirectory(carpetaF);
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            Hide();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombreUsuario = textBox1.Text;
            string contraseñaUsuario = textBox2.Text;


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Hay Campos Vacíos");
            }            

            else
            {
                if (File.Exists("./Usuarios/" + textBox1.Text + ".txt"))
                {


                    char[] separadorRegistro = { ':' };
                    string[] lineas = File.ReadAllLines("./Usuarios/" + textBox1.Text + ".txt");
                    string[] separadas = new string[2];
                    string[] separadas2 = new string[2];
                    string[] separadas3 = new string[2];
                    string nombreUline;
                    string contraseñaline;
                    string archivoline;

                    nombreUline = lineas[2];
                    contraseñaline = lineas[3];
                    archivoline = lineas[4];

                    separadas = nombreUline.Split(separadorRegistro);
                    separadas2 = contraseñaline.Split(separadorRegistro);
                    separadas3 = archivoline.Split(separadorRegistro);


                    if (separadas2[1].Trim().Equals(contraseñaUsuario))
                    {
                        if(File.Exists("./Formulario/"+separadas3[1]+".txt"))
                        {
                            DialogResult mensajebox = MessageBox.Show("Ya tienes un registro creado, si continúas el registro que tienes actualmente se reemplazará por este nuevo registro, seguro que quieres hacerlo?", "Confirmation", MessageBoxButtons.YesNo);
                            if(mensajebox == DialogResult.Yes)
                            {
                                form3.nombreU = textBox1.Text;
                                Hide();
                                form3.ShowDialog();
                            }

                            else
                            {
                                mensajebox = DialogResult.Cancel;
                            }
                        }

                        else
                        {
                            form3.nombreU = textBox1.Text;
                            Hide();
                            form3.ShowDialog();
                        }
                        

                        
                    }

                    else
                    {
                        MessageBox.Show("Contraseña Incorrecta");

                    }



                }

                else
                {
                    MessageBox.Show("Este Usuario no Existe, Debe Registrarse");

                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
