using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T04P08SUELDOS_Pérez_Aranda_Agustín
{
    public partial class Form1 : Form
    {
        int[] a_sueldos = new int[] { 0, 0, 0, 0 };
        int sueldo = 0, maxi = 0, mini = 0;
        double acumu = 0.0;
        double med = 0.0;
        int nSueldos = 0;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void anyadir_Click(object sender, EventArgs e)
        {
            nSueldos++;
            sueldo = int.Parse(sueldos.Text);
            if (nSueldos <= 4)
            {
                a_sueldos[nSueldos - 1] = sueldo;
                mostrar.Text = mostrar.Text + sueldos.Text + "\r\n";
                acumu = acumu + a_sueldos[cont];
                acum.Text = acumu.ToString();
                med = acumu / nSueldos;
                media.Text = med.ToString();
                cont++;
                for (int i = 0; i < 4; i++)
                {
                    if (a_sueldos[i] > maxi)
                    {
                        maxi = a_sueldos[i];
                        max.Text = maxi.ToString();
                    }
                    if (i == 0)
                    {
                        mini = a_sueldos[i];
                        min.Text = mini.ToString();
                    }
                    else
                    {
                        if ((a_sueldos[i] < mini) && (a_sueldos[i]) != 0)
                        {
                            mini = a_sueldos[i];
                            min.Text = mini.ToString();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Máximo de sueldos alcanzado", "Atención");
            }
        }
    }
}
