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
    public partial class Form5 : Form
    {
        text txt = new text();
        public string nada;
        public string tipoS;
        public string areaA;
        public string TandaE;
        public string periodoI;

        public string nomR;
        public string apellidoR;
        public string docIdentidad;
        public string correo;
        public string noIdentidad;
        public string contraseña;
        public string Fecha;
        public string estadoC;
        public string sexo;
        public string nacionalidad;
        public string fechasinSlash;

        public string nombreU;



        public Form5()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Debes Llenar Todos Los Campos");
            }

            else if (comboBox1.Text == textBox2.Text || comboBox1.Text == textBox3.Text || textBox2.Text == comboBox1.Text || textBox2.Text == textBox3.Text
                || textBox2.Text == comboBox2.Text || textBox3.Text == comboBox1.Text || textBox3.Text == textBox2.Text || textBox2.Text == comboBox2.Text 
                || comboBox2.Text == textBox2.Text || comboBox2.Text == textBox3.Text)
            {
                MessageBox.Show("Estos Campos no deberian coincidir");
            }
            else
            {
                Form6 form6 = new Form6();
                form6.direccion = textBox3.Text;
                form6.provincia = comboBox1.Text;
                form6.municipios = comboBox2.Text;
                form6.sector = textBox2.Text;

                form6.tipoSolicitud = tipoS;
                form6.areaAcademica = areaA;
                form6.TandaEstudio = TandaE;
                form6.periodoIngreso = periodoI;

                form6.nombre = nomR;
                form6.apellido = apellidoR;
                form6.documentoIndentidad = docIdentidad;
                form6.correoElectronico = correo;
                form6.noDocumentoIdentidad = noIdentidad;
                form6.contraseñaRegistro = contraseña;
                form6.fechaNacimiento = Fecha;
                form6.estadoCivil = estadoC;
                form6.sexo = sexo;
                form6.nacionalidad = nacionalidad;
                form6.fecha = fechasinSlash;

                form6.nombreU = nombreU;

                Hide();
                form6.ShowDialog();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Hide();
            form4.ShowDialog();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] mAzua = new string[10];
            mAzua[0] = "Azua de Compostela";
            mAzua[1] = "Estebanía";
            mAzua[2] = "Guayabal";
            mAzua[3] = "Las Charcas";
            mAzua[4] = "Las Yayas de Viajama";
            mAzua[5] = "Padre Las Casas";
            mAzua[6] = "Peralta";
            mAzua[7] = "Pueblo Viejo";
            mAzua[8] = "Sabana Yegua";
            mAzua[9] = "Tábara Arriba";

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mAzua.Length; i++)
                {
                    comboBox2.Items.Add(mAzua[i]);
                }

            }

            //----------------------------------------------------------------------------------------------------------

            string[] mBaoruco = new string[5];
            mBaoruco[0] = "Neiba";
            mBaoruco[1] = "Galván";
            mBaoruco[2] = "Los Ríos";
            mBaoruco[3] = "Tamayo";
            mBaoruco[4] = "Villa Jaragua";

            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mBaoruco.Length; i++)
                {
                    comboBox2.Items.Add(mBaoruco[i]);
                }

            }

            //----------------------------------------------------------------------------------------------------------

            string[] mBarahona = new string[11];
            mBarahona[0] = "Barahona";
            mBarahona[1] = "Cabral";
            mBarahona[2] = "El Peñón";
            mBarahona[3] = "Enriquillo";
            mBarahona[4] = "Fundación";
            mBarahona[5] = "Jaquimeyes";
            mBarahona[6] = "La Ciénaga";
            mBarahona[7] = "Las Salinas";
            mBarahona[8] = "Paraíso";
            mBarahona[9] = "Polo";
            mBarahona[10] = "Vicente Noble";


            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mBarahona.Length; i++)
                {
                    comboBox2.Items.Add(mBarahona[i]);
                }

            }

            //----------------------------------------------------------------------------------------------------------

            string[] mDajabón = new string[5];
            mDajabón[0] = "Dajabón";
            mDajabón[1] = "El Pino";
            mDajabón[2] = "Loma de Cabrera";
            mDajabón[3] = "Partido";
            mDajabón[4] = "Restauración";


            if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mDajabón.Length; i++)
                {
                    comboBox2.Items.Add(mDajabón[i]);
                }

            }

            //----------------------------------------------------------------------------------------------------------

            string[] mDuarte = new string[7];
            mDuarte[0] = "San Francisco de Macorís";
            mDuarte[1] = "Arenoso";
            mDuarte[2] = "Castillo";
            mDuarte[3] = "Eugenio María de Hostos";
            mDuarte[4] = "Las Guáranas";
            mDuarte[5] = "Pimentel";
            mDuarte[6] = "Villa Riva";



            if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mDuarte.Length; i++)
                {
                    comboBox2.Items.Add(mDuarte[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mElíasPiña = new string[6];
            mElíasPiña[0] = "Comendador";
            mElíasPiña[1] = "Bánica";
            mElíasPiña[2] = "El Llano";
            mElíasPiña[3] = "Hondo Valle";
            mElíasPiña[4] = "Juan Santiago";
            mElíasPiña[5] = "Juan Santiago";


            if (comboBox1.SelectedIndex == 5)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mElíasPiña.Length; i++)
                {
                    comboBox2.Items.Add(mElíasPiña[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mElSeibo = new string[2];
            mElSeibo[0] = "El Seibo";
            mElSeibo[1] = "Miches";


            if (comboBox1.SelectedIndex == 6)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mElSeibo.Length; i++)
                {
                    comboBox2.Items.Add(mElSeibo[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mEspaillat = new string[4];
            mEspaillat[0] = "Moca";
            mEspaillat[1] = "Cayetano Germosén";
            mEspaillat[2] = "Gaspar Hernández";
            mEspaillat[3] = "Gaspar Hernández";


            if (comboBox1.SelectedIndex == 7)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mEspaillat.Length; i++)
                {
                    comboBox2.Items.Add(mEspaillat[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mHatoMayor = new string[3];
            mHatoMayor[0] = "Hato Mayor del Rey";
            mHatoMayor[1] = "El Valle";
            mHatoMayor[2] = "Sabana de la Mar";



            if (comboBox1.SelectedIndex == 8)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mHatoMayor.Length; i++)
                {
                    comboBox2.Items.Add(mHatoMayor[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mHermanasMirabal = new string[3];
            mHermanasMirabal[0] = "Salcedo";
            mHermanasMirabal[1] = "Tenares";
            mHermanasMirabal[2] = "Villa Tapia";



            if (comboBox1.SelectedIndex == 9)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mHermanasMirabal.Length; i++)
                {
                    comboBox2.Items.Add(mHermanasMirabal[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mIndependencia = new string[6];
            mIndependencia[0] = "Jimaní";
            mIndependencia[1] = "Cristóbal";
            mIndependencia[2] = "Duvergé";
            mIndependencia[3] = "La Descubierta";
            mIndependencia[4] = "Mella";
            mIndependencia[5] = "Postrer Río";



            if (comboBox1.SelectedIndex == 10)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mIndependencia.Length; i++)
                {
                    comboBox2.Items.Add(mIndependencia[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mLaAltagracia = new string[2];
            mLaAltagracia[0] = "Higüey";
            mLaAltagracia[1] = "San Rafael del Yuma";


            if (comboBox1.SelectedIndex == 11)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mLaAltagracia.Length; i++)
                {
                    comboBox2.Items.Add(mLaAltagracia[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mLaRomana = new string[3];
            mLaRomana[0] = "La Romana";
            mLaRomana[1] = "Guaymate";
            mLaRomana[2] = "Villa Hermosa";


            if (comboBox1.SelectedIndex == 12)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mLaRomana.Length; i++)
                {
                    comboBox2.Items.Add(mLaRomana[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mLaVega = new string[4];
            mLaVega[0] = "La Concepción de La Vega";
            mLaVega[1] = "Constanza";
            mLaVega[2] = "Jarabacoa";
            mLaVega[3] = "Jima Abajo";




            if (comboBox1.SelectedIndex == 13)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mLaVega.Length; i++)
                {
                    comboBox2.Items.Add(mLaVega[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mMaríaTrinidadSánchez = new string[4];
            mMaríaTrinidadSánchez[0] = "Nagua";
            mMaríaTrinidadSánchez[1] = "Cabrera";
            mMaríaTrinidadSánchez[2] = "El Factor";
            mMaríaTrinidadSánchez[3] = "Río San Juan";


            if (comboBox1.SelectedIndex == 14)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mMaríaTrinidadSánchez.Length; i++)
                {
                    comboBox2.Items.Add(mMaríaTrinidadSánchez[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mMonseñorNouel = new string[3];
            mMonseñorNouel[0] = "Bonao";
            mMonseñorNouel[1] = "Maimón";
            mMonseñorNouel[2] = "Piedra Blanca";



            if (comboBox1.SelectedIndex == 15)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mMonseñorNouel.Length; i++)
                {
                    comboBox2.Items.Add(mMonseñorNouel[i]);
                }

            }

            //----------------------------------------------------------------------------------------------------------

            string[] mMontecristi = new string[6];
            mMontecristi[0] = "Montecristi";
            mMontecristi[1] = "Castañuela";
            mMontecristi[2] = "Guayubín";
            mMontecristi[3] = "Las Matas de Santa Cruz";
            mMontecristi[4] = "Pepillo Salcedo";
            mMontecristi[5] = "Villa Vásquez";



            if (comboBox1.SelectedIndex == 16)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mMontecristi.Length; i++)
                {
                    comboBox2.Items.Add(mMontecristi[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mMontePlata = new string[5];
            mMontePlata[0] = "Monte Plata";
            mMontePlata[1] = "Bayaguana";
            mMontePlata[2] = "Peralvillo";
            mMontePlata[3] = "Sabana Grande de Boyá";
            mMontePlata[4] = "Yamasá";


            if (comboBox1.SelectedIndex == 17)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mMontePlata.Length; i++)
                {
                    comboBox2.Items.Add(mMontePlata[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mPedernales = new string[2];
            mPedernales[0] = "Monte Plata";
            mPedernales[1] = "Bayaguana";



            if (comboBox1.SelectedIndex == 18)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mPedernales.Length; i++)
                {
                    comboBox2.Items.Add(mPedernales[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mPeravia = new string[2];
            mPeravia[0] = "Baní";
            mPeravia[1] = "Nizao";



            if (comboBox1.SelectedIndex == 19)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mPeravia.Length; i++)
                {
                    comboBox2.Items.Add(mPeravia[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mPuertoPlata = new string[9];
            mPuertoPlata[0] = "Puerto Plata";
            mPuertoPlata[1] = "Altamira";
            mPuertoPlata[2] = "Guananico";
            mPuertoPlata[3] = "Imbert";
            mPuertoPlata[4] = "Los Hidalgos";
            mPuertoPlata[5] = "Luperón";
            mPuertoPlata[6] = "Sosúa";
            mPuertoPlata[7] = "Villa Isabela";
            mPuertoPlata[8] = "Villa Montellano";


            if (comboBox1.SelectedIndex == 20)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mPuertoPlata.Length; i++)
                {
                    comboBox2.Items.Add(mPuertoPlata[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mSamaná = new string[3];
            mSamaná[0] = "Samaná";
            mSamaná[1] = "Altamira";
            mSamaná[2] = "Guananico";



            if (comboBox1.SelectedIndex == 21)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSamaná.Length; i++)
                {
                    comboBox2.Items.Add(mSamaná[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] mSanCristóbal = new string[8];
            mSanCristóbal[0] = "San Cristóbal";
            mSanCristóbal[1] = "Bajos de Haina";
            mSanCristóbal[2] = "Cambita Garabito";
            mSanCristóbal[3] = "Los Cacaos";
            mSanCristóbal[4] = "Sabana Grande de Palenque";
            mSanCristóbal[5] = "San Gregorio de Nigua";
            mSanCristóbal[6] = "Villa Altagracia";
            mSanCristóbal[7] = "Yaguate";


            if (comboBox1.SelectedIndex == 22)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSanCristóbal.Length; i++)
                {
                    comboBox2.Items.Add(mSanCristóbal[i]);
                }

            }




            //----------------------------------------------------------------------------------------------------------

            string[] mSanJosédeOcoa = new string[3];
            mSanJosédeOcoa[0] = "San José de Ocoa";
            mSanJosédeOcoa[1] = "Rancho  Arriba";
            mSanJosédeOcoa[2] = "Sabana Larga";



            if (comboBox1.SelectedIndex == 23)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSanJosédeOcoa.Length; i++)
                {
                    comboBox2.Items.Add(mSanJosédeOcoa[i]);
                }

            }





            //----------------------------------------------------------------------------------------------------------

            string[] mSanJuan = new string[6];
            mSanJuan[0] = "San Juan de la Maguana";
            mSanJuan[1] = "Bohechío";
            mSanJuan[2] = "El Cercado";
            mSanJuan[3] = "Juan de Herrera";
            mSanJuan[4] = "Las Matas de Farfán";
            mSanJuan[5] = "Vallejuelo";



            if (comboBox1.SelectedIndex == 24)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSanJuan.Length; i++)
                {
                    comboBox2.Items.Add(mSanJuan[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mSanPedrodeMacorís = new string[4];
            mSanPedrodeMacorís[0] = "San Pedro de Macorís";
            mSanPedrodeMacorís[1] = "Consuelo";
            mSanPedrodeMacorís[2] = "Guayacanes";
            mSanPedrodeMacorís[3] = "San José de Los Llanos";
            mSanPedrodeMacorís[2] = "Quisqueya";
            mSanPedrodeMacorís[3] = "Ramón Santana";


            if (comboBox1.SelectedIndex == 25)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSanPedrodeMacorís.Length; i++)
                {
                    comboBox2.Items.Add(mSanPedrodeMacorís[i]);
                }

            }




            //----------------------------------------------------------------------------------------------------------

            string[] mSánchezRamírez = new string[4];
            mSánchezRamírez[0] = "Cotuí";
            mSánchezRamírez[1] = "Cevicos";
            mSánchezRamírez[2] = "Fantino";
            mSánchezRamírez[3] = "La Mata";



            if (comboBox1.SelectedIndex == 26)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSánchezRamírez.Length; i++)
                {
                    comboBox2.Items.Add(mSánchezRamírez[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mSantiago = new string[9];
            mSantiago[0] = "Santiago";
            mSantiago[1] = "Bisonó";
            mSantiago[2] = "Jánico";
            mSantiago[3] = "Licey al Medio	";
            mSantiago[4] = "Puñal";
            mSantiago[5] = "Sabana Iglesia";
            mSantiago[6] = "San José de las Matas";
            mSantiago[7] = "Tamboril";
            mSantiago[8] = "Villa González";



            if (comboBox1.SelectedIndex == 27)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSantiago.Length; i++)
                {
                    comboBox2.Items.Add(mSantiago[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] mSantiagoRodríguez = new string[3];
            mSantiagoRodríguez[0] = "San Ignacio de Sabaneta";
            mSantiagoRodríguez[1] = "Los Almácigos";
            mSantiagoRodríguez[2] = "Monción";


            if (comboBox1.SelectedIndex == 28)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSantiagoRodríguez.Length; i++)
                {
                    comboBox2.Items.Add(mSantiagoRodríguez[i]);
                }

            }



            //----------------------------------------------------------------------------------------------------------

            string[] SantoDomingo = new string[7];
            SantoDomingo[0] = "Santo Domingo Este";
            SantoDomingo[1] = "Boca Chica";
            SantoDomingo[2] = "Los Alcarrizos";
            SantoDomingo[3] = "Pedro Brand";
            SantoDomingo[4] = "San Antonio de Guerra";
            SantoDomingo[5] = "Santo Domingo Norte";
            SantoDomingo[6] = "Santo Domingo Oeste";


            if (comboBox1.SelectedIndex == 29)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < mSantiagoRodríguez.Length; i++)
                {
                    comboBox2.Items.Add(mSantiagoRodríguez[i]);
                }

            }


            //----------------------------------------------------------------------------------------------------------

            string[] Valverde = new string[3];
            Valverde[0] = "Mao";
            Valverde[1] = "Esperanza";
            Valverde[2] = "Laguna Salada";



            if (comboBox1.SelectedIndex == 30)
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < Valverde.Length; i++)
                {
                    comboBox2.Items.Add(Valverde[i]);
                }

            }




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
