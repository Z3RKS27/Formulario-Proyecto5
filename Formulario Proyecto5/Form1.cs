using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulario_Proyecto5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            string nombres = textBox1.Text;
            string apellidos = textBox5.Text;
            string edad = textBox2.Text;
            string estatura = textBox3.Text;
            string telefono = textBox4.Text;

            string genero = "";
            if(RBHombre.Checked)
            {
                genero = "Hombre";
            }
            else if(RBMujer.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombres: {nombres} \r\nApellidos: {apellidos}\r\nTelefono: {telefono} kg\r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGenero: {genero}";

            string rutaArchivo = "C:/Users/perez/Documentos.txt";
            //File.WriteAllText(rutaArchivo, datos);
            //
            bool archivoExiste = File.Exists(rutaArchivo);

            Console.WriteLine(archivoExiste);
            if(archivoExiste == false) 
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) 
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
            }

            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            RBHombre.Checked = false;
            RBMujer.Checked = false;
        }
    }
}
