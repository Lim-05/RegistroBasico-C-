using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
=======
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> e74846d0fec4ec84bc6783c2384e20d9c225e7de

namespace PracticaDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD

            //Agregar controladores de eventos TextChanged a los c;
            tbEdad.TextChanged += validarEdad;
            tbEstatura.TextChanged += validarEstatura;
            //tbTelefono.TextChanged += validarTelefono;
            tbTelefono.Leave += validarTelefono;
            tbNombre.TextChanged += validarNombre;
            tbApellidos.TextChanged += validarApellidos;

=======
>>>>>>> e74846d0fec4ec84bc6783c2384e20d9c225e7de
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telefono = tbTelefono.Text;
            string genero = "";
            if (rbHombre.Checked) {
                genero = "Hombre";

            }
            else if(rbMujer.Checked){
                genero = "Mujer";

            }
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telefono}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nGenero: {genero}";
            string rutaArchivo = "C:\\Users\\moral\\Downloads\\3Mdatos24.txt";
            // verificar si el archivo ya esxiste
            bool archivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            // Mostrar un mensaje con los datos capturados 
            MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

<<<<<<< HEAD
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsTextoValido (string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una edad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Ingrese una estaura valida", "Error estatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text.Length == 10 && EsEnteroValidoDe10Digitos(textBox.Text))
            {
                textBox.BackColor = Color.Green;
            }
            else
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Ingrese un telefono de 10 digitos", "Error telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }
        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese un nombre valido", "Error nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Ingrese un apellido valido", "Error apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
=======
>>>>>>> e74846d0fec4ec84bc6783c2384e20d9c225e7de
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            tbEstatura.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}
