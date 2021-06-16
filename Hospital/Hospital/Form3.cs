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
    public partial class Form3 : Form
    {
        public static double a, aa, bb, cc;
        public static double c;
        public static double Xo;
        public static double M;
        public static double n, modulo, m = 0, acumulador = 0, promedio, Zo;
        double pro1;
        double sum;
        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int a = 0; a <= 6; a++)
            {
                dataserviciosofrece.Rows.Add();
                
            }
            
            
            //Servicios
            dataserviciosofrece.Rows[0].Cells[1].Value = "Atencion de emergencia";
            dataserviciosofrece.Rows[1].Cells[1].Value = "Servicio de consulta familiar";
            dataserviciosofrece.Rows[2].Cells[1].Value = "Servicio de laboratorio";
            dataserviciosofrece.Rows[3].Cells[1].Value = "Operaciones menores";
            dataserviciosofrece.Rows[4].Cells[1].Value = "Operaciones especializadas";
            dataserviciosofrece.Rows[5].Cells[1].Value = "Campaña de vacuna y sanidad";
            dataserviciosofrece.Rows[6].Cells[1].Value = "Cuidados intensivos";
            //Probabilidad
            dataserviciosofrece.Rows[0].Cells[2].Value = 0.10;
            dataserviciosofrece.Rows[1].Cells[2].Value = 0.20;
            dataserviciosofrece.Rows[2].Cells[2].Value = 0.15;
            dataserviciosofrece.Rows[3].Cells[2].Value = 0.13;
            dataserviciosofrece.Rows[4].Cells[2].Value = 0.17;
            dataserviciosofrece.Rows[5].Cells[2].Value = 0.10;
            dataserviciosofrece.Rows[6].Cells[2].Value = 0.15;
            //limite inferior
            dataserviciosofrece.Rows[0].Cells[3].Value = 0;
            dataserviciosofrece.Rows[1].Cells[3].Value = 0.10;
            dataserviciosofrece.Rows[2].Cells[3].Value = 0.30;
            dataserviciosofrece.Rows[3].Cells[3].Value = 0.45;
            dataserviciosofrece.Rows[4].Cells[3].Value = 0.58;
            dataserviciosofrece.Rows[5].Cells[3].Value = 0.75;
            dataserviciosofrece.Rows[6].Cells[3].Value = 0.85;
            //limite inferior
            dataserviciosofrece.Rows[0].Cells[4].Value = 0.10;
            dataserviciosofrece.Rows[1].Cells[4].Value = 0.30;
            dataserviciosofrece.Rows[2].Cells[4].Value = 0.45;
            dataserviciosofrece.Rows[3].Cells[4].Value = 0.58;
            dataserviciosofrece.Rows[4].Cells[4].Value = 0.75;
            dataserviciosofrece.Rows[5].Cells[4].Value = 0.85;
            dataserviciosofrece.Rows[6].Cells[4].Value = 1;

            //ad = dataGridView1.Rows.Add();
            for (int b = 1; b < 6; b++)
            {
                //dataserviciosofrece.Rows.Add();
                ////double sum;
                //pro1 = double.Parse(dataserviciosofrece.Rows[b].Cells[1].Value.ToString());
                //sum = pro1 + 1;
                //dataserviciosofrece.Rows[ad].Cells[4].Value = sum.ToString();



                //pro += pro;
                ////inicio = pro;
                //dataGridView1.Rows[ad].Cells[2].Value = pro.ToString();
            }
        }

        public static double[] random = new double[100000];
        public static int ad;
        public static double redondeado;
        int indice;
        double rex1;
        public Form3()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            a = 101;
            c = 221;
            Xo = 17;
            M = 17001;
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
                
                if (redondeado <= puntocambio)
                {
                    double x1 = (aa + Math.Sqrt(ba * ca * redondeado));
                    rex1 = Math.Round(x1, 0);
                    //dataGridView1.Rows[ad].Cells[0].Value = rex1.ToString();
                }
                if (redondeado >= puntocambio)
                {
                    double x1 = (cc - Math.Sqrt(cb * ca * (1 - redondeado)));
                    rex1 = Math.Round(x1, 0);
                    //dataGridView1.Rows[ad].Cells[0].Value = rex2.ToString();
                }
                dataserviciosofrece.Rows[ad].Cells[0].Value = rex1.ToString();
                acumulador += random[i];
                m = modulo;
                Xo = m;
                
            }
            if (dataGridView1.Rows != null)
            {
                double sumatoria = 0;
                foreach (DataGridViewRow row in dataserviciosofrece.Rows)
                {
                    sumatoria += Convert.ToDouble(row.Cells["Cpp"].Value);
                }
                for (int b = 0; b < sumatoria; b++)
                {
                     dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[b].Value = (b + 1).ToString();
                }
            }
            

           


        }
    }
}
