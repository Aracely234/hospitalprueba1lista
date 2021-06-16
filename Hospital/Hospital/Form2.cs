using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form2 : Form
    {
        public static double a,aa,bb,cc;
        public static double c;
        public static double Xo;
        public static double M;
        public static double n, modulo, m = 0, acumulador = 0, promedio, Zo;
        public static double[] random = new double[100000];
        public static int ad;
        public static double redondeado;
        int indice;
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            a = 101;
            c = 221;
            Xo = 17;
            M = 17001;
            
            indice = comboBox1.SelectedIndex;
            if (indice == 0)
            {
                //Sacar la moda
                double.TryParse(tbnA.Text, out aa);
                double.TryParse(tbnB.Text, out bb);
                double.TryParse(tbnC.Text, out cc);

                double ba = bb - aa;
                double cb = cc - bb;
                double ca = cc - aa;

                double puntocambio = ba / ca;
                pc.Text = puntocambio.ToString();
                n = 30;
                //generar numeros 
                for (int i = 0; i < n; i++)
                {
                    modulo = (a * Xo + c) % M;
                    random[i] = modulo / M;
                    redondeado = (Math.Round(random[i], 5));

                    ad = dataGridView1.Rows.Add();
                    dataGridView1.Rows[ad].Cells[0].Value = (i + 1).ToString();
                    dataGridView1.Rows[ad].Cells[1].Value = redondeado.ToString();
                    if (redondeado <= puntocambio)
                    {
                        double x1 = (aa + Math.Sqrt(ba * ca * redondeado));
                        double rex1 = Math.Round(x1, 0);
                        dataGridView1.Rows[ad].Cells[2].Value = rex1.ToString();
                    }
                    if (redondeado >= puntocambio)
                    {
                        double x2 = (cc - Math.Sqrt(cb * ca * (1 - redondeado)));
                        double rex2 = Math.Round(x2, 0);
                        dataGridView1.Rows[ad].Cells[2].Value = rex2.ToString();
                    }

                    acumulador += random[i];

                    m = modulo;
                    Xo = m;


                }
                
                
                
            }
            
            
        }

       


        public Form2()
        {
            InitializeComponent();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
