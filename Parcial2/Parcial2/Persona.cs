using Parcial2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{

    public class Persona : IGuardar
    {

        public string nombre;
        public string apellido;
        public string nombreUsuario;
        public string contraseña;
        public string tipoSolicitud;
        public string areaAcademica;
        public string TandaEstudio;
        public string periodoIngreso;
        public string documentoIndentidad;
        public string noDocumentoIdentidad;
        public string fechaNacimiento;
        public string estadoCivil;
        public string sexo;
        public string correoElectronico;
        public string contraseñaRegistro;
        public string nacionalidad;
        public string direccion;
        public string municipios;
        public string provincia;
        public string sector;
        public string Ptrabajar;
        public string Pestudios;
        public string Peconomia;
        public string Pingreso;
        public string PingresoF;
        public string Ptransporte;
        public string pathFile;
        public string archivo;
        public List<string[]> ListaPersonas = new List<string[]>();
        public string[] campos;

        public string guardarFile(string path)
        {
            return path;
        }

        



    }

    public class GuardarUsuario : Persona
    {
        public void GuardarArchivo(string nombreR, string apellidoR, string nombreUsuarioR, string contraseñaR)
        {
            string path = "./Usuarios/" + nombreUsuarioR + ".txt";
            campos = new string[5];

            nombre = nombreR;
            apellido = apellidoR;
            nombreUsuario = nombreUsuarioR;
            contraseña = contraseñaR;

            campos[0] = nombre;
            campos[1] = apellido;
            campos[2] = nombreUsuario;
            campos[3] = contraseña;

            ListaPersonas.Add(campos);


            using (StreamWriter escribir = new StreamWriter(guardarFile(path), true))
            {
                foreach (string[] x in ListaPersonas)
                {
                    escribir.WriteLine("Nombre:" + x[0]);
                    escribir.WriteLine("Apellido:" + x[1]);
                    escribir.WriteLine("Nombre de Usuario:" + x[2]);
                    escribir.WriteLine("Contraseña:" + x[3]);
                    escribir.WriteLine("archivo:" + x[4]);

                }


            }

        }

        public void reemplazaArchivo(string path,string archivo)
        {




            char[] separadorRegistro = { ':' };
            string[] lines = File.ReadAllLines(path);
            string[] separadas1 = new string[2];
            string[] separadas2 = new string[2];
            string[] separadas3 = new string[2];
            string[] separadas4 = new string[2];
            string[] separadas5 = new string[2];
            string nombreline;
            string apellidoline;
            string nombreUline;
            string contraseñaline;
            string archivoline;

            nombreline = lines[0];
            apellidoline = lines[1];
            nombreUline = lines[2];
            contraseñaline = lines[3];
            archivoline = lines[4];

            separadas1 = nombreline.Split(separadorRegistro);
            separadas2 = apellidoline.Split(separadorRegistro);
            separadas3 = nombreUline.Split(separadorRegistro);
            separadas4 = contraseñaline.Split(separadorRegistro);
            separadas5 = archivoline.Split(separadorRegistro);
   
               
            if (!separadas5[1].Trim().Equals(archivo))
            {

                using (StreamWriter escribir = new StreamWriter(path))
                {

                    escribir.WriteLine("Nombre:" + separadas1[1]);
                    escribir.WriteLine("Apellido:" + separadas2[1]);
                    escribir.WriteLine("Nombre de Usuario:" + separadas3[1]);
                    escribir.WriteLine("Contraseña:" + separadas4[1]);
                    escribir.WriteLine("archivo:" + archivo);

                }

            }
                            

        }

      
        

    }

    class GuardarFormulario : Persona
    {
        
        public void recorgerDatosSolicitudAdmision(string tiposolicitud, string area, string tanda, string periodo)
        {
            tipoSolicitud = tiposolicitud;
            areaAcademica = area;
            TandaEstudio = tanda;
            periodoIngreso = periodo;
        }

        public void recogerDatosGenerales(string nombreR, string apellidoR, string documentoI, string correo, string nodocumento, string fechaN, string contraseñaR, string estadoC, string pais, string sex)
        {
            nombre = nombreR;
            apellido = apellidoR;
            documentoIndentidad = documentoI;
            correoElectronico = correo;
            noDocumentoIdentidad = nodocumento;
            fechaNacimiento = fechaN;
            contraseñaRegistro = contraseñaR;
            estadoCivil = estadoC;
            nacionalidad = pais;
            sexo = sex;
        }

        public void recogerDatosDomicilio(string direccionR, string provinciaR, string municipiosR, string sectorR)
        {
            direccion = direccionR;
            provincia = provinciaR;
            municipios = municipiosR;
            sector = sectorR;

        }

        public void InfoFinanciera(string preguntaTrabajo, string preguntaE, string preguntaEco, string iFamiliar, string preguntaTransporte)
        {
            Ptrabajar = preguntaTrabajo;
            Pestudios = preguntaE;
            Peconomia = preguntaEco;
            PingresoF = iFamiliar;
            Ptransporte = preguntaTransporte;

        }

 

        public void crearfecha(string fecha)
        {

            pathFile = nombre + apellido + fecha;

        }



        public void GuardarFormEstudio()
        {
            string path = "./Formulario/" + pathFile + ".txt";
            campos = new string[23];


            campos[0] = nombre;
            campos[1] = apellido;
            campos[2] = documentoIndentidad;
            campos[3] = correoElectronico;
            campos[4] = noDocumentoIdentidad;
            campos[5] = fechaNacimiento;
            campos[6] = contraseñaRegistro;
            campos[7] = estadoCivil;
            campos[8] = sexo;
            campos[9] = nacionalidad;
            campos[10] = tipoSolicitud;
            campos[11] = areaAcademica;
            campos[12] = TandaEstudio;
            campos[13] = periodoIngreso;
            campos[14] = direccion;
            campos[15] = provincia;
            campos[16] = municipios;
            campos[17] = sector;
            campos[18] = Ptrabajar;
            campos[19] = Pestudios;
            campos[20] = Peconomia;
            campos[21] = PingresoF;
            campos[22] = Ptransporte;



            ListaPersonas.Add(campos);



            using (StreamWriter escribir = new StreamWriter(guardarFile(path)))
            {
                foreach (string[] x in ListaPersonas)
                {
                    escribir.WriteLine("Nombre:" + x[0]);
                    escribir.WriteLine("Apellido:" + x[1]);
                    escribir.WriteLine("Documento de identidad:" + x[2]);
                    escribir.WriteLine("Correo Electronico:" + x[3]);
                    escribir.WriteLine("Numero de Documento de Identidad:" + x[4]);
                    escribir.WriteLine("Fecha de Nacimiento:" + x[5]);
                    escribir.WriteLine("Contraseña Registro:" + x[6]);
                    escribir.WriteLine("Estado Civil:" + x[7]);
                    escribir.WriteLine("Sexo:" + x[8]);
                    escribir.WriteLine("Nacionalidad:" + x[9]);
                    escribir.WriteLine("Tipo de Solicitud:" + x[10]);
                    escribir.WriteLine("Area Academica:" + x[11]);
                    escribir.WriteLine("Tanda de Estudios:" + x[12]);
                    escribir.WriteLine("Periodo de Ingreso:" + x[13]);
                    escribir.WriteLine("Direccion:" + x[14]);
                    escribir.WriteLine("Provincia:" + x[15]);
                    escribir.WriteLine("Municipios:" + x[16]);
                    escribir.WriteLine("Sector:" + x[17]);
                    escribir.WriteLine("Trabaja Actualmente?:" + x[18]);
                    escribir.WriteLine("Cómo Costeará Sus Estudios?::" + x[19]);
                    escribir.WriteLine("Alguien Depende Económicamente De Ústed?:" + x[20]);
                    escribir.WriteLine("Ingreso Familiar Mensual Asciende A:" + x[21]);
                    escribir.WriteLine("¿Usaras el transporte de la institución?" + x[22]);


                }


            }

        }

    }

    }

    public interface IGuardar
    {
        string guardarFile(string path);
    }

    class text
    {
        public void onlyChar(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void onlyNumber(KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void OnlyNumberandChar(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void textOnlySpace(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

 
    }
  



