using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        string[] nombres = new string[10];
        string[] apellidos = new string[10];
        string[] direcciones = new string[10];
        string[] correos = new string[10];
        //string[] telefonos = new string[10];
        string[,] telefonos = new string[10, 100];
        int[] contadorTelefonos = new int[10];

        string[,] palabrasClave = new string[10, 100];
        int[] contadorPalabras = new int[10];

        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)//Eliminar palabra clave
        {
            int pos = listBox1.SelectedIndex;
            int posPal = listBox3.SelectedIndex;
            if ( listBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la palabra que desea eliminar");
                return;
            }

            for (int j = posPal; j < contadorPalabras[pos] - 1; j++)
            {
                palabrasClave[pos, j] = palabrasClave[pos, j + 1];
            }

            contadorPalabras[pos]--;

            listBox3.Items.RemoveAt(posPal);
        }

        private void button7_Click(object sender, EventArgs e)//AGregar palabra clave
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un contacto");
                return;
            }

            int pos = listBox1.SelectedIndex;

            palabrasClave[pos, contadorPalabras[pos]] = textBoxPalabra.Text;

            listBox3.Items.Add(textBoxPalabra.Text);

            contadorPalabras[pos]++;
        }

        private void button6_Click(object sender, EventArgs e)//boton eliminar telefono
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un teléfono");
                return;
            }
            int pos = listBox1.SelectedIndex;
            int posTel = listBox2.SelectedIndex;

            for (int j = posTel; j < contadorTelefonos[pos] - 1; j++)
            {
                telefonos[pos, j] = telefonos[pos, j + 1];
            }

            contadorTelefonos[pos]--;

            listBox2.Items.RemoveAt(posTel);

        }

        private void button5_Click(object sender, EventArgs e)//agregar telefono
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un contacto");
                return;
            }
            int pos = listBox1.SelectedIndex;

            telefonos[pos, contadorTelefonos[pos]] = textBoxTelefono.Text;

            listBox2.Items.Add(textBoxTelefono.Text);

            contadorTelefonos[pos]++;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)//BOTOTN AGREGAR CONTACTO

        {
            string nuevoNombre = textBox1.Text.ToLower();
            string nuevoApellido = textBox2.Text.ToLower();

            bool existe = false;

            for (int j = 0; j < i; j++)
            {
                if (nombres[j].ToLower() == nuevoNombre &&
                    apellidos[j].ToLower() == nuevoApellido)
                {
                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                MessageBox.Show("Este contacto ya existe.");
                return; // Detiene el botón y no guarda
            }
            string name = textBox2.Text;
            string apellido = textBox3.Text;
            string direccion = textBox4.Text;
            string correo = textBox1.Text;
            nombres[i] = textBox1.Text; //ARREGLOS CON INDICE
            apellidos[i] = textBox2.Text;
            direcciones[i] = textBox3.Text;
            correos[i] = textBox4.Text;

            palabrasClave[i, 0] = textBox1.Text; //agrega el nombre como palabra clave
            palabrasClave[i, 1] = textBox2.Text; //agrega el apellido como palabra clave
            contadorPalabras[i] = 2; // dos palabras clave



            listBox1.Items.Add(nombres[i]+ " " + apellidos[i]);//AGREGA EL NOMBRE Y APELLIDO DEL CONTACTO EN LA CAJA DE TEXTO
            i++;//INCREMENTE EN CONTADOR
            MessageBox.Show("CONTACTO GUARDADO CORRECTAMENTE");
        }

        private void button3_Click(object sender, EventArgs e)//BOTON VER
        {
            if (listBox1.SelectedIndex == -1) //condicional si no ha seleccionado nada
            {
                MessageBox.Show("Seleccione un contacto primero");
                return;
            }

            int posicion = listBox1.SelectedIndex; //Toma la posición del contacto seleccionado

            textBox1.Text = nombres[posicion];
            textBox2.Text = apellidos[posicion];
            textBox3.Text = direcciones[posicion];
            textBox4.Text = correos[posicion];

            listBox2.Items.Clear();//Limpiar la caja de texto de los telefonos
            for (int j = 0; j< contadorTelefonos[posicion]; j++)
            {
                listBox2.Items.Add(telefonos[posicion, j]);

            }
            listBox3.Items.Clear();//Limpiar la caja de texto de las palabras clave
            for (int j = 0; j < contadorPalabras[posicion]; j++) 
            {
                listBox3.Items.Add(palabrasClave[posicion, j]);
            }
        }

        private void button11_Click(object sender, EventArgs e)//BOTON LIMPIAR
        {
            //CONANDO CLEAR PARA LIMPIAR CADA UNA DE LAS CFAJAS DE TEXTO
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBoxTelefono.Clear();
            textBoxPalabra.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int posicion = listBox1.SelectedIndex;

            nombres[posicion] = textBox1.Text;
            apellidos[posicion] = textBox2.Text;
            direcciones[posicion] = textBox3.Text;
            correos[posicion] = textBox4.Text;

            listBox1.Items[posicion] = textBox1.Text + " " + textBox2.Text;

        }

        private void button1_Click(object sender, EventArgs e)//botón ver todos los contactos
        {
            listBox1.Items.Clear();

            for (int j = 0; j < i; j++)
            {
                listBox1.Items.Add(nombres[j] + " " + apellidos[j]);
            }
        }

        private void button2_Click(object sender, EventArgs e)//botón buscar por palabra clave
        {
            string palabra = textBoxBuscar.Text.ToLower();

            listBox1.Items.Clear();

            for (int j = 0; j < i; j++)
            {
                bool coincide = false;

                // Buscar en nombre y aoellido que son palabras clave
                if (nombres[j].ToLower().Contains(palabra) ||
                    apellidos[j].ToLower().Contains(palabra))
                {
                    coincide = true;
                }

                // Buscar en palabras clave
                for (int k = 0; k < contadorPalabras[j]; k++)
                {
                    if (palabrasClave[j, k].ToLower().Contains(palabra))
                    {
                        coincide = true;
                        break; // ya encontró coincidencia
                    }
                }

                if (coincide)
                {
                    listBox1.Items.Add(nombres[j] + " " + apellidos[j]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)//Eliminar contacto
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un contacto");
                return;
            }

            int pos = listBox1.SelectedIndex;

            // Mover todos los datos una posición hacia arriba
            for (int j = pos; j < i - 1; j++)
            {
                nombres[j] = nombres[j + 1];
                apellidos[j] = apellidos[j + 1];
                direcciones[j] = direcciones[j + 1];
                correos[j] = correos[j + 1];

                // Mover teléfonos
                for (int k = 0; k < contadorTelefonos[j + 1]; k++)
                {
                    telefonos[j, k] = telefonos[j + 1, k];
                }
                contadorTelefonos[j] = contadorTelefonos[j + 1];

                // Mover palabras clave
                for (int k = 0; k < contadorPalabras[j + 1]; k++)
                {
                    palabrasClave[j, k] = palabrasClave[j + 1, k];
                }
                contadorPalabras[j] = contadorPalabras[j + 1];
            }

            i--;

            listBox1.Items.RemoveAt(pos);
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            MessageBox.Show("Contacto eliminado correctamente");
        }
    }
}
