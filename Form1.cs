using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Graphics area;
        int puntoinicio, puntofin;
        public Form1()
        {
            InitializeComponent();
            area = panel1.CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);

            switch (comboBox1.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
                default:
                    //Console.WriteLine("Default case");
                    lapicero = new Pen(Color.Aquamarine);
                    break;

            }


            //SE validan los controles 
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text)  ||String.IsNullOrEmpty(textBox4.Text)) 
            {
                //MessageBox.Show("Valores estan Nulos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Valores estan Nulos","Validacion",MessageBoxButtons.OK,MessageBoxIcon.Error // for Warning  
                                                                                                             //MessageBoxIcon.Error // for Error 
                                                                                                             //MessageBoxIcon.Information  // for Information
                                                                                                             //MessageBoxIcon.Question // for Question
                                );//Probando los msj
            }
            else
            {

                int interacciones = int.Parse(textBox1.Text);//Cantidad de Lineas
                int espacio = int.Parse(textBox2.Text);
                puntoinicio = int.Parse(textBox3.Text);//se establece punto Inicio
                puntofin = int.Parse(textBox4.Text);//se establece punto Fin
                area.Clear(Color.White);

                //int puntoinicio = 50;
                for (int i = 0; i < interacciones; i++)
                {
                    // area.DrawLine(lapicero, 20, puntoinicio , 300, puntofin);
                    area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 300, puntofin + (espacio * i));
                }
            }
           

        }
    }
}
