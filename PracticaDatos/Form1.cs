﻿using System;
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
