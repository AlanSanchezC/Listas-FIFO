using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasFIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random r;
        Fifo colaTortillas;

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Random();
            colaTortillas = new Fifo(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ciclo de 200
            for (int i = 1; i <= 15; i++)
            {
                int num = r.Next(1, 5);
                if (num == 1)
                {
                    Proceso p1 = new Proceso();
                    if (colaTortillas.sacarElemento() != null)
                    {
                        colaTortillas.agregar(p1);
                        colaTortillas.avanzar();
                    }
                    else        
                        colaTortillas.agregar(p1);
                } else 
                    colaTortillas.avanzar();

                num = 0;
                procedimiento();  
            }

            int suma = 0;
            Proceso p = colaTortillas.sacarElemento();
            if (p != null)
            {
                do
                {
                    suma += p.tiempo;
                    p = p.siguiente;
                } while (p != null);
            }

            txtReporte.Text += "Ciclos vacíos: " + colaTortillas.ciclosVacios.ToString() + Environment.NewLine;
            txtReporte.Text += "Tiempo restante de cola: " + suma.ToString();
        }


       /*
        * Extra
        */

        private void procedimiento()
        {
            Proceso pr = colaTortillas.sacarElemento();
            if (pr != null)
            {
                do
                {
                    string espacios = "  ";
                    if (pr.tiempo > 9) espacios = " ";

                    txtProcedimiento.Text += pr.tiempo.ToString() + espacios;
                    pr = pr.siguiente;

                } while (pr != null);
                txtProcedimiento.Text += Environment.NewLine;
            }
        }

    }
}
