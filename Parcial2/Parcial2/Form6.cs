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
    public partial class Form6 : Form
    {
        public string pTrabaja = "Si trabaja";
        public string pCostear = "Recursos Propios";
        public string dependE = "No";
        public string ingresoF = "0 - 15,000";
        public string usarTransporte = "No";
        public string fecha;
        public string nombre;
        public string apellido;
        public string documentoIndentidad;
        public string correoElectronico;
        public string noDocumentoIdentidad;
        public string fechaNacimiento;
        public string contraseñaRegistro;
        public string estadoCivil;
        public string sexo;
        public string nacionalidad;
        public string tipoSolicitud;
        public string areaAcademica;
        public string TandaEstudio;
        public string periodoIngreso;
        public string direccion;
        public string provincia;
        public string municipios;
        public string sector;
        public string nombrE;
        public string apellidO;
        public string nombreU;
        public string contraseña;
        public string miArchivo;
        public string DirecP;





        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        text txt = new text();
        GuardarFormulario guardarF = new GuardarFormulario();
        GuardarUsuario guardarU = new GuardarUsuario();
        public Form6()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                pCostear = textBox1.Text;
            }

            if (textBox2.Enabled == true)
            {
                dependE = textBox2.Text;
            }


            if (textBox1.Text == "" && radioButton7.Checked == true && textBox1.Enabled == true|| textBox2.Text == "" && radioButton9.Checked == true && textBox2.Enabled == true)
            {
                MessageBox.Show("Hay Campos Vacíos");
            }


            else
            {

                string[] espacios = new string[5];
                char[] separadorRegistro = { ':' };
                string[] lines = File.ReadAllLines("./Usuarios/" + nombreU + ".txt");
                string archivoline;
                string[] separadas = new string[2];

                archivoline = lines[4];
                separadas = archivoline.Split(separadorRegistro);


                if (File.Exists("./Formulario/" + separadas[1].Trim() + ".txt"))
                {

                   File.Delete("./Formulario/" + separadas[1] + ".txt");
                    miArchivo = nombre.Trim() + apellido.Trim() + fecha;
                    DirecP = "./Usuarios/" + nombreU + ".txt";
                    guardarF.recogerDatosGenerales(nombre, apellido, documentoIndentidad, correoElectronico, noDocumentoIdentidad, fechaNacimiento, contraseñaRegistro, estadoCivil, nacionalidad, sexo);
                    guardarF.recorgerDatosSolicitudAdmision(tipoSolicitud, areaAcademica, TandaEstudio, periodoIngreso);
                    guardarF.recogerDatosDomicilio(direccion, provincia, municipios, sector);
                    guardarF.InfoFinanciera(pTrabaja, pCostear, dependE, ingresoF, usarTransporte);
                    guardarF.crearfecha(fecha);
                    guardarU.reemplazaArchivo(DirecP, miArchivo.Trim());
                    guardarF.GuardarFormEstudio();
                    MessageBox.Show("Tu Formulario ha sido guardado exitosamente!");
                    Close();

                }

                else
                {
                    DirecP = "./Usuarios/" + nombreU + ".txt";
                    miArchivo = nombre + apellido + fecha;
                    guardarF.recogerDatosGenerales(nombre, apellido, documentoIndentidad, correoElectronico, noDocumentoIdentidad, fechaNacimiento, contraseñaRegistro, estadoCivil, nacionalidad, sexo);
                    guardarF.recorgerDatosSolicitudAdmision(tipoSolicitud, areaAcademica, TandaEstudio, periodoIngreso);
                    guardarF.recogerDatosDomicilio(direccion, provincia, municipios, sector);
                    guardarF.InfoFinanciera(pTrabaja, pCostear, dependE, ingresoF, usarTransporte);
                    guardarF.crearfecha(fecha);
                    guardarU.reemplazaArchivo(DirecP, miArchivo);
                    guardarF.GuardarFormEstudio();
                    MessageBox.Show("Tu Formulario ha sido guardado exitosamente!");
                    Close();
                }



            }
                      
           
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pTrabaja = "Si trabaja";
            }

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pTrabaja = "No trabaja";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                pTrabaja = "Recursos Propios";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                pCostear = "Beca";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                pCostear = "Credito Educativo";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                pCostear = "Ayuda Familiar";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                textBox1.Enabled = true;
                pCostear = textBox1.Text;
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                dependE = "No";
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                textBox2.Enabled = true;
                dependE = textBox2.Text;

            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                ingresoF = "0 - 15,000";
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                ingresoF = "15,001 - 25,000";
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                ingresoF = "25,001 - 45,000";
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                ingresoF = "Más De 45,000";
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton14.Checked == true)
            {
                usarTransporte = "No";
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                usarTransporte = "Si";
            }
        }



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt.onlyNumber(e);
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


        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            form5.ShowDialog();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
