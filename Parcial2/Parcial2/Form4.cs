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
    public partial class Form4 : Form
    {
        text txt = new text();
        GuardarFormulario guardarF = new GuardarFormulario();
        Form5 form5 = new Form5();
        string correoU;
        public string identificacion = "Cedula";
        public string sexo = "Masculino";
        public string nacionalidad = "Dominicana";
        public string tipoSolicitud;
        public string areaAcademica;
        public string TandaEstudio;
        public string periodoIngreso;
        public string tipos;
        public string area;
        public string nombreU;
        public string contraseña;
        public string miArchivo;

        public Form4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            Form3 form3 = new Form3();


            form5.Fecha = dateTimePicker1.Text;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dMyyyy";
            correoU = textBox2.Text + comboBox2.Text;


            form5.tipoS = tipoSolicitud;
            form5.areaA = areaAcademica;
            form5.TandaE = TandaEstudio;
            form5.periodoI = periodoIngreso;

            form5.nomR = textBox4.Text;
            form5.apellidoR = textBox1.Text;
            form5.docIdentidad = identificacion;
            form5.correo = correoU;
            form5.noIdentidad = maskedTextBox1.Text;
            form5.contraseña = textBox5.Text;

            form5.estadoC = comboBox1.Text;
            form5.sexo = sexo;
            form5.nacionalidad = nacionalidad;
            form5.fechasinSlash = dateTimePicker1.Text;

            form5.nombreU = nombreU;


            dateTimePicker1.Format = DateTimePickerFormat.Short;
            form5.Fecha = dateTimePicker1.Text;


            if (textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Debe llenar los campos");
            }

            else if (textBox5.Text.Length < 6 || textBox6.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener 6 caracteres como minimo");
            }

            else if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Las contraseñas deben ser iguales");
            }

            else if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Debes Ingresar tu numero de cedula completo");
            }

            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Debe Elegir el tipo de correo");
            }

            else
            {
                guardarF.recorgerDatosSolicitudAdmision(tipoSolicitud, areaAcademica, TandaEstudio, periodoIngreso);
                Hide();
                form5.ShowDialog();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                identificacion = "Cedula";
                maskedTextBox1.Mask = "000-00000000-0";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                sexo = "Masculino";
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBox4.SelectionStart == 0)
            {
                if (e.KeyChar == 32)
                {
                    e.Handled = true;

                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt.onlyNumber(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt.OnlyNumberandChar(e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                identificacion = "Pasaporte";
                maskedTextBox1.Mask = "";

            }


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                sexo = "Femenino";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                nacionalidad = "Dominicana";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                nacionalidad = "Extranjero";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }


        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (textBox4.SelectionStart == 0)
            {
                if (e.KeyChar == 32)
                {
                    e.Handled = true;

                }


            }
            txt.textOnlySpace(e);


        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (textBox2.SelectionStart == 0)
            {
                if (e.KeyChar == 32)
                {
                    e.Handled = true;

                }
            }

            txt.OnlyNumberandChar(e);
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txt.onlyNumber(e);
        }


        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt.OnlyNumberandChar(e);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {


        }
    }
}
