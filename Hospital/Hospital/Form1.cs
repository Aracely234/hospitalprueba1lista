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
    public partial class Form1 : Form
    {
        //public static class clasecppmpartida
        //{
        //Declaracion de variables
        public static double a, aa, bb, cc;
        public static double c;
        public static double Xo;
        public static double M;
        public static double n, modulo, m = 0, acumulador = 0, promedio, Zo;
        public static double[] random = new double[100000];
        public static int ad;
        public static double redondeado;
        public static double rex1, rex2;
        public static double[] pacientes = new double[30];
        public static double sumatoria = 0,sumatoria2=0,sumatoriaingresos;
        public static double c1, c2, c3, c4, c5, c6, c7;
        public static string tiposervicio;
        public static double acumulador2=0,acumulador3=0, acumulador4=0, acumulador5=0, acumulador6=0, acumulador7=0,acumulador8=0;
        public static double numeroservicios1=0, numeroservicios2=0, numeroservicios3=0, numeroservicios4=0, numeroservicios5=0, numeroservicios6=0, numeroservicios7=0;
        public static double costoOperacion;
        public static double probabilidadanterior,nuevasuma;
        public static int nuevasfilas;
        public static double nuevoingresototal;
        public static double nuevospreciosumar;
        public static double sumatoriacostos;
        //variables quitar 2
        public static double probabilidadanterior2, nuevasuma2;
        public static int nuevasfilas2;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
        private void buDecision_Click(object sender, EventArgs e)
        {
            //datapersonas.Rows.Clear();
            probabilidadanterior = double.Parse(dataserviciosofrece.Rows[0].Cells[1].Value.ToString());
            //label8.Text = promedioanterior.ToString();
            dataserviciosofrece.Rows.Remove(dataserviciosofrece.Rows[0]);
            nuevasfilas = dataserviciosofrece.RowCount - 1;
            nuevasuma = probabilidadanterior / nuevasfilas;
            //label8.Text = Math.Round(nuevasuma,4).ToString();
            double liminf1 = 0;
            for (int a = 0; a < dataserviciosofrece.RowCount - 1; a++)
            {
                double promedioa = double.Parse(dataserviciosofrece.Rows[a].Cells[1].Value.ToString());
                double promedion = promedioa + nuevasuma;
                double pro1 = double.Parse(dataserviciosofrece.Rows[0].Cells[1].Value.ToString());
                double pro2= pro1 + (double.Parse(dataserviciosofrece.Rows[1].Cells[1].Value.ToString()));
                double pro3= pro2 + (double.Parse(dataserviciosofrece.Rows[2].Cells[1].Value.ToString()));
                double pro4= pro3 + (double.Parse(dataserviciosofrece.Rows[3].Cells[1].Value.ToString()));
                double pro5= pro4 + (double.Parse(dataserviciosofrece.Rows[4].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[a].Cells[1].Value = Math.Round(promedion,4);
                dataserviciosofrece.Rows[0].Cells[2].Value = liminf1;
                dataserviciosofrece.Rows[0].Cells[3].Value = pro1;
                dataserviciosofrece.Rows[1].Cells[2].Value = pro1;
                dataserviciosofrece.Rows[1].Cells[3].Value = pro1 + (double.Parse(dataserviciosofrece.Rows[1].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[2].Cells[2].Value = pro2;
                dataserviciosofrece.Rows[2].Cells[3].Value= pro2 + (double.Parse(dataserviciosofrece.Rows[2].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[3].Cells[2].Value = pro3;
                dataserviciosofrece.Rows[3].Cells[3].Value = pro3 + (double.Parse(dataserviciosofrece.Rows[3].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[4].Cells[2].Value = pro4;
                dataserviciosofrece.Rows[4].Cells[3].Value = pro4 + (double.Parse(dataserviciosofrece.Rows[4].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[5].Cells[2].Value = pro5;
                dataserviciosofrece.Rows[5].Cells[3].Value = pro5 + (double.Parse(dataserviciosofrece.Rows[5].Cells[1].Value.ToString()));
                
            }
            tablanuevaprimera();
            //NoPersonas();
            tablaserviciosmenosuno();
            nocompararmenosuno();
            sumatoriamenos1ingresos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a = 101;
            c = 221;
            Xo = 17;
            M = 17001;
            n = 31;
            //Sacar la moda
            double.TryParse(tbnA.Text, out aa);
            double.TryParse(tbnB.Text, out bb);
            double.TryParse(tbnC.Text, out cc);

            double ba = bb - aa;
            double cb = cc - bb;
            double ca = cc - aa;

            double puntocambio = ba / ca;
            pc.Text = puntocambio.ToString();
            
            //generar numeros 
            for (int i = 0; i < 30; i++)
            {
                modulo = (a * Xo + c) % M;
                random[i] = modulo / M;
                redondeado = (Math.Round(random[i], 5));
                ad = dataGridView2.Rows.Add();
                dataGridView2.Rows[ad].Cells[0].Value = (i + 1).ToString();
                dataGridView2.Rows[ad].Cells[1].Value = redondeado.ToString();
                if (redondeado <= puntocambio)
                {
                    double x1 = (aa + Math.Sqrt(ba * ca * redondeado));
                    rex1 = Math.Round(x1, 0);
                }
                else
                {
                    double x1 = (cc - Math.Sqrt(cb * ca * (1 - redondeado)));
                    rex1 = Math.Round(x1, 0);
                }
                dataGridView2.Rows[ad].Cells[2].Value = rex1.ToString();
                acumulador += random[i];
                pacientes[i] = rex1;
                m = modulo;
                    Xo = m;
                

            }
            NoPersonas();
            tablaservicios();
            nocomparar();
            //serviciostotal();
            Verificacion();
            tablasumatoriacostos();
        }
        public void NoPersonas()
        {
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                sumatoria += Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn3"].Value);
            }
            for (int b = 0; b < sumatoria; b++)
            {
                ad = datapersonas.Rows.Add();
                datapersonas.Rows[ad].Cells[0].Value = (b+1).ToString();
            }
            

        }
        public void nocomparar()
        {
            a = 101;
            c = 221;
            Xo = 17;
            M = 17001;
            n = 31;
            for (int b = 0; b <sumatoria; b++)
            {
                //generar numeros 
                modulo = (a * Xo + c) % M;
                random[b] = modulo / M;
                double redoneado = (Math.Round(random[b], 5));
                ad = datapersonas.Rows.Add();
                datapersonas.Rows[b].Cells[1].Value = redoneado.ToString();
                acumulador += random[b];
                m = modulo;
                Xo = m;
                //se asigna el valor de los intervalos inferiores y superiores
                double vi1 = double.Parse(dataserviciosofrece.Rows[0].Cells[2].Value.ToString());
                double vf1 = double.Parse(dataserviciosofrece.Rows[0].Cells[3].Value.ToString());
                double vi2 = double.Parse(dataserviciosofrece.Rows[1].Cells[2].Value.ToString());
                double vf2 = double.Parse(dataserviciosofrece.Rows[1].Cells[3].Value.ToString());
                double vi3 = double.Parse(dataserviciosofrece.Rows[2].Cells[2].Value.ToString());
                double vf3 = double.Parse(dataserviciosofrece.Rows[2].Cells[3].Value.ToString());
                double vi4 = double.Parse(dataserviciosofrece.Rows[3].Cells[2].Value.ToString());
                double vf4 = double.Parse(dataserviciosofrece.Rows[3].Cells[3].Value.ToString());
                double vi5 = double.Parse(dataserviciosofrece.Rows[4].Cells[2].Value.ToString());
                double vf5 = double.Parse(dataserviciosofrece.Rows[4].Cells[3].Value.ToString());
                double vi6 = double.Parse(dataserviciosofrece.Rows[5].Cells[2].Value.ToString());
                double vf6 = double.Parse(dataserviciosofrece.Rows[5].Cells[3].Value.ToString());
                double vi7 = double.Parse(dataserviciosofrece.Rows[6].Cells[2].Value.ToString());
                double vf7 = double.Parse(dataserviciosofrece.Rows[6].Cells[3].Value.ToString());
                //se asigna el valor del costo
                //c1 = double.Parse(dataserviciosofrece.Rows[0].Cells[5].Value.ToString());
                //c2 = double.Parse(dataserviciosofrece.Rows[1].Cells[5].Value.ToString());
                //c3 = double.Parse(dataserviciosofrece.Rows[2].Cells[5].Value.ToString());
                //c4 = double.Parse(dataserviciosofrece.Rows[3].Cells[5].Value.ToString());
                //c5 = double.Parse(dataserviciosofrece.Rows[4].Cells[5].Value.ToString());
                //c6 = double.Parse(dataserviciosofrece.Rows[5].Cells[5].Value.ToString());
                //c7 = double.Parse(dataserviciosofrece.Rows[6].Cells[5].Value.ToString());

                if (redoneado <= vf1 && redoneado >= vi1)
                {
                    // label6.Text = "AE";
                    tiposervicio = "AE";
                    c1 = 75;
                    acumulador2 = acumulador2 + c1;
                    numeroservicios1 = numeroservicios1 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c1.ToString();
                    

                }
                else if (redoneado <= vf2 && redoneado >= vi2)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "SCF";
                    c2 = 50;
                    acumulador3 = acumulador3 + c2;
                    numeroservicios2 = numeroservicios2 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c2.ToString();
                }
                else if (redoneado <= vf3 && redoneado >= vi3)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "SL";
                    c3 = 150;
                    acumulador4 = acumulador4 + c3;
                    numeroservicios3 = numeroservicios3 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c3.ToString();
                }
                else if (redoneado <= vf4 && redoneado >= vi4)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "OM";
                    c4 = 400;
                    acumulador5 = acumulador5 + c4;
                    numeroservicios4 = numeroservicios4 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c4.ToString();
                }
                else if (redoneado <= vf5 && redoneado >= vi5)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "OE";
                    c5 = 950;
                    acumulador6 = acumulador6 + c5;
                    numeroservicios5 = numeroservicios5 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c5.ToString();
                }
                else if (redoneado <= vf6 && redoneado >= vi6)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "CVyS";
                    c6 = 20;
                    acumulador7 = acumulador7 + c6;
                    numeroservicios6 = numeroservicios6 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c6.ToString();
                }
                else if (redoneado <= vf7 && redoneado >= vi7)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "CI";
                    c7 = 200;
                    acumulador8 = acumulador8 + c7;
                    numeroservicios7 = numeroservicios7 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c7.ToString();
                }
                serviciostotal();

            }
        }
        public void tablaservicios()
        {
            for (int a = 0; a <= 6; a++)
            {
                dataserviciosofrece.Rows.Add();

            }

            //Servicios
            dataserviciosofrece.Rows[0].Cells[0].Value = "Atencion de emergencia";
            dataserviciosofrece.Rows[1].Cells[0].Value = "Servicio de consulta familiar";
            dataserviciosofrece.Rows[2].Cells[0].Value = "Servicio de laboratorio";
            dataserviciosofrece.Rows[3].Cells[0].Value = "Operaciones menores";
            dataserviciosofrece.Rows[4].Cells[0].Value = "Operaciones especializadas";
            dataserviciosofrece.Rows[5].Cells[0].Value = "Campaña de vacuna y sanidad";
            dataserviciosofrece.Rows[6].Cells[0].Value = "Cuidados intensivos";
            //Probabilidad
            dataserviciosofrece.Rows[0].Cells[1].Value = 0.10;
            dataserviciosofrece.Rows[1].Cells[1].Value = 0.20;
            dataserviciosofrece.Rows[2].Cells[1].Value = 0.15;
            dataserviciosofrece.Rows[3].Cells[1].Value = 0.13;
            dataserviciosofrece.Rows[4].Cells[1].Value = 0.17;
            dataserviciosofrece.Rows[5].Cells[1].Value = 0.10;
            dataserviciosofrece.Rows[6].Cells[1].Value = 0.15;
            //limite inferior
            dataserviciosofrece.Rows[0].Cells[2].Value = 0;
            dataserviciosofrece.Rows[1].Cells[2].Value = 0.10;
            dataserviciosofrece.Rows[2].Cells[2].Value = 0.30;
            dataserviciosofrece.Rows[3].Cells[2].Value = 0.45;
            dataserviciosofrece.Rows[4].Cells[2].Value = 0.58;
            dataserviciosofrece.Rows[5].Cells[2].Value = 0.75;
            dataserviciosofrece.Rows[6].Cells[2].Value = 0.85;
            //limite superior
            dataserviciosofrece.Rows[0].Cells[3].Value = 0.10;
            dataserviciosofrece.Rows[1].Cells[3].Value = 0.30;
            dataserviciosofrece.Rows[2].Cells[3].Value = 0.45;
            dataserviciosofrece.Rows[3].Cells[3].Value = 0.58;
            dataserviciosofrece.Rows[4].Cells[3].Value = 0.75;
            dataserviciosofrece.Rows[5].Cells[3].Value = 0.85;
            dataserviciosofrece.Rows[6].Cells[3].Value = 1;
            //Siglas
            dataserviciosofrece.Rows[0].Cells[4].Value = "AE";
            dataserviciosofrece.Rows[1].Cells[4].Value = "SCF";
            dataserviciosofrece.Rows[2].Cells[4].Value = "SL";
            dataserviciosofrece.Rows[3].Cells[4].Value = "OM";
            dataserviciosofrece.Rows[4].Cells[4].Value = "OE";
            dataserviciosofrece.Rows[5].Cells[4].Value = "CVyS";
            dataserviciosofrece.Rows[6].Cells[4].Value = "CI";
            ////Costo
            dataserviciosofrece.Rows[0].Cells[5].Value = 75;
            dataserviciosofrece.Rows[1].Cells[5].Value = 50;
            dataserviciosofrece.Rows[2].Cells[5].Value = 150;
            dataserviciosofrece.Rows[3].Cells[5].Value = 400;
            dataserviciosofrece.Rows[4].Cells[5].Value = 950;
            dataserviciosofrece.Rows[5].Cells[5].Value = 20;
            dataserviciosofrece.Rows[6].Cells[5].Value = 200;

            
        }
        public void serviciostotal()
        {
            if (tiposervicio == "AE")
            {
                dataserviciosofrece.Rows[0].Cells[7].Value = acumulador2.ToString();
                dataserviciosofrece.Rows[0].Cells[6].Value = numeroservicios1.ToString();
            }
            if (tiposervicio == "SCF")
            {
                dataserviciosofrece.Rows[1].Cells[7].Value = acumulador3.ToString();
                dataserviciosofrece.Rows[1].Cells[6].Value = numeroservicios2.ToString();
            }
            if (tiposervicio == "SL")
            {
                dataserviciosofrece.Rows[2].Cells[7].Value = acumulador4.ToString();
                dataserviciosofrece.Rows[2].Cells[6].Value = numeroservicios3.ToString();
            }
            if (tiposervicio == "OM")
            {
                dataserviciosofrece.Rows[3].Cells[7].Value = acumulador5.ToString();
                dataserviciosofrece.Rows[3].Cells[6].Value = numeroservicios4.ToString();
            }
            if (tiposervicio == "OE")
            {
                dataserviciosofrece.Rows[4].Cells[7].Value = acumulador6.ToString();
                dataserviciosofrece.Rows[4].Cells[6].Value = numeroservicios5.ToString();
            }
            if (tiposervicio == "CVyS")
            {
                dataserviciosofrece.Rows[5].Cells[7].Value = acumulador7.ToString();
                dataserviciosofrece.Rows[5].Cells[6].Value = numeroservicios6.ToString();
            }
            if (tiposervicio == "CI")
            {
                dataserviciosofrece.Rows[6].Cells[7].Value = acumulador8.ToString();
                dataserviciosofrece.Rows[6].Cells[6].Value = numeroservicios7.ToString();
            }

        }
        public void Verificacion()
        {
            double.TryParse(txCostoOpera.Text, out costoOperacion);
            foreach (DataGridViewRow row in dataserviciosofrece.Rows)
            {
                sumatoriaingresos += Convert.ToDouble(row.Cells["Ingresos"].Value);
            }
            txingresototal.Text = sumatoriaingresos.ToString();
            if (sumatoriaingresos > costoOperacion)
            {
                labelresultado.Text = "El costo de operacion si es optimo";
            }
            else
            {
                labelresultado.Text = "El costo de operacion no es optimo";
            }
            
            
        }
        //nuevas pruebas --------------------------------------------------------------
        public void tablanuevaprimera()
        {
            a = 101;
            c = 221;
            Xo = 17;
            M = 17001;
            n = 31;
            //Sacar la moda
            double.TryParse(tbnA.Text, out aa);
            double.TryParse(tbnB.Text, out bb);
            double.TryParse(tbnC.Text, out cc);

            double ba = bb - aa;
            double cb = cc - bb;
            double ca = cc - aa;

            double puntocambio = ba / ca;
            pc.Text = puntocambio.ToString();

            //generar numeros 
            for (int i = 0; i < 30; i++)
            {
                modulo = (a * Xo + c) % M;
                random[i] = modulo / M;
                redondeado = (Math.Round(random[i], 5));
                ad = dataGridView2.Rows.Add();
                dataGridView2.Rows[ad].Cells[0].Value = (i + 1).ToString();
                dataGridView2.Rows[ad].Cells[1].Value = redondeado.ToString();
                if (redondeado <= puntocambio)
                {
                    double x1 = (aa + Math.Sqrt(ba * ca * redondeado));
                    rex1 = Math.Round(x1, 0);
                }
                else
                {
                    double x1 = (cc - Math.Sqrt(cb * ca * (1 - redondeado)));
                    rex1 = Math.Round(x1, 0);
                }
                dataGridView2.Rows[ad].Cells[2].Value = rex1.ToString();
                acumulador += random[i];
                pacientes[i] = rex1;
                m = modulo;
                Xo = m;


            }
        }
        public void tablasumatoriacostos()
        {
            foreach (DataGridViewRow row in dataserviciosofrece.Rows)
            {
                sumatoriacostos += Convert.ToDouble(row.Cells["CCOSTO"].Value);
            }
            label8.Text = sumatoriacostos.ToString();
        }
        public void tablaserviciosmenosuno()
        {
            for (int a = 0; a <= 6; a++)
            {
                dataserviciosofrece.Rows.Add();

            }
            nuevoingresototal = sumatoriacostos - 75;
            nuevospreciosumar = nuevoingresototal /6;
            //label8.Text = nuevospreciosumar.ToString();
            //Costo
            dataserviciosofrece.Rows[0].Cells[5].Value = 50+nuevospreciosumar;
            dataserviciosofrece.Rows[1].Cells[5].Value = 150+nuevospreciosumar;
            dataserviciosofrece.Rows[2].Cells[5].Value = 400+nuevospreciosumar;
            dataserviciosofrece.Rows[3].Cells[5].Value = 950+nuevospreciosumar;
            dataserviciosofrece.Rows[4].Cells[5].Value = 20+nuevospreciosumar;
            dataserviciosofrece.Rows[5].Cells[5].Value = 200+nuevospreciosumar;
        }
        public void nocompararmenosuno()
        {
            a = 101;
            c = 221;
            Xo = 17;
            M = 17001;
            n = 31;
            acumulador2 = 0; acumulador3 = 0; acumulador4 = 0; acumulador5 = 0; acumulador6 = 0; acumulador7 = 0; acumulador8 = 0;
            numeroservicios1 = 0; numeroservicios2 = 0; numeroservicios3 = 0; numeroservicios4 = 0; numeroservicios5 = 0; numeroservicios6 = 0; numeroservicios7 = 0;

            for (int b = 0; b < sumatoria; b++)
            {
                //generar numeros 
                modulo = (a * Xo + c) % M;
                random[b] = modulo / M;
                double redoneado = (Math.Round(random[b], 5));
                ad = datapersonas.Rows.Add();
                datapersonas.Rows[b].Cells[1].Value = redoneado.ToString();
                acumulador += random[b];
                m = modulo;
                Xo = m;
                //se asigna el valor de los intervalos inferiores y superiores
                double vi1 = double.Parse(dataserviciosofrece.Rows[0].Cells[2].Value.ToString());
                double vf1 = double.Parse(dataserviciosofrece.Rows[0].Cells[3].Value.ToString());
                double vi2 = double.Parse(dataserviciosofrece.Rows[1].Cells[2].Value.ToString());
                double vf2 = double.Parse(dataserviciosofrece.Rows[1].Cells[3].Value.ToString());
                double vi3 = double.Parse(dataserviciosofrece.Rows[2].Cells[2].Value.ToString());
                double vf3 = double.Parse(dataserviciosofrece.Rows[2].Cells[3].Value.ToString());
                double vi4 = double.Parse(dataserviciosofrece.Rows[3].Cells[2].Value.ToString());
                double vf4 = double.Parse(dataserviciosofrece.Rows[3].Cells[3].Value.ToString());
                double vi5 = double.Parse(dataserviciosofrece.Rows[4].Cells[2].Value.ToString());
                double vf5 = double.Parse(dataserviciosofrece.Rows[4].Cells[3].Value.ToString());
                double vi6 = double.Parse(dataserviciosofrece.Rows[5].Cells[2].Value.ToString());
                double vf6 = double.Parse(dataserviciosofrece.Rows[5].Cells[3].Value.ToString());
                //double vi7 = double.Parse(dataserviciosofrece.Rows[6].Cells[2].Value.ToString());
                //double vf7 = double.Parse(dataserviciosofrece.Rows[6].Cells[3].Value.ToString());
                //se asigna el valor del costo
                //c1 = double.Parse(dataserviciosofrece.Rows[0].Cells[5].Value.ToString());
                //c2 = double.Parse(dataserviciosofrece.Rows[1].Cells[5].Value.ToString());
                //c3 = double.Parse(dataserviciosofrece.Rows[2].Cells[5].Value.ToString());
                //c4 = double.Parse(dataserviciosofrece.Rows[3].Cells[5].Value.ToString());
                //c5 = double.Parse(dataserviciosofrece.Rows[4].Cells[5].Value.ToString());
                //c6 = double.Parse(dataserviciosofrece.Rows[5].Cells[5].Value.ToString());
                //c7 = double.Parse(dataserviciosofrece.Rows[6].Cells[5].Value.ToString());
                if (redoneado <= vf1 && redoneado >= vi1)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "SCF";
                    c2 = 50 + nuevospreciosumar;
                    acumulador3 = acumulador3 + c2;
                    numeroservicios2 = numeroservicios2 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c2.ToString();


                }
                else if (redoneado <= vf2 && redoneado >= vi2)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "SL";
                    c3 = 150 + nuevospreciosumar;
                    acumulador4 = acumulador4 + c3;
                    numeroservicios3 = numeroservicios3 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c3.ToString();
                }
                else if (redoneado <= vf3 && redoneado >= vi3)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "OM";
                    c4 = 400 + nuevospreciosumar;
                    acumulador5 = acumulador5 + c4;
                    numeroservicios4 = numeroservicios4 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c4.ToString();
                }
                else if (redoneado <= vf4 && redoneado >= vi4)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "OE";
                    c5 = 950 + nuevospreciosumar;
                    acumulador6 = acumulador6 + c5;
                    numeroservicios5 = numeroservicios5 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c5.ToString();
                }
                else if (redoneado <= vf5 && redoneado >= vi5)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "CVyS";
                    c6 = 20 + nuevospreciosumar;
                    acumulador7 = acumulador7 + c6;
                    numeroservicios6 = numeroservicios6 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c6.ToString();
                }
                else if (redoneado <= vf6 && redoneado >= vi6)
                {
                    //label6.Text = "SCF";
                    tiposervicio = "CI";
                    c7 = 200 + nuevospreciosumar;
                    acumulador8 = acumulador8 + c7;
                    numeroservicios7 = numeroservicios7 + 1;
                    datapersonas.Rows[b].Cells[2].Value = tiposervicio;
                    datapersonas.Rows[b].Cells[3].Value = c7.ToString();
                }
               
                nuevoserviciostotalmenosuno();

            }
        }
        public void nuevoserviciostotalmenosuno()
        {
           
            if (tiposervicio == "SCF")
            {
                dataserviciosofrece.Rows[0].Cells[7].Value = acumulador3.ToString();
                dataserviciosofrece.Rows[0].Cells[6].Value = numeroservicios2.ToString();
            }
            if (tiposervicio == "SL")
            {
                dataserviciosofrece.Rows[1].Cells[7].Value = acumulador4.ToString();
                dataserviciosofrece.Rows[1].Cells[6].Value = numeroservicios3.ToString();
            }
            if (tiposervicio == "OM")
            {
                dataserviciosofrece.Rows[2].Cells[7].Value = acumulador5.ToString();
                dataserviciosofrece.Rows[2].Cells[6].Value = numeroservicios4.ToString();
            }
            if (tiposervicio == "OE")
            {
                dataserviciosofrece.Rows[3].Cells[7].Value = acumulador6.ToString();
                dataserviciosofrece.Rows[3].Cells[6].Value = numeroservicios5.ToString();
            }
            if (tiposervicio == "CVyS")
            {
                dataserviciosofrece.Rows[4].Cells[7].Value = acumulador7.ToString();
                dataserviciosofrece.Rows[4].Cells[6].Value = numeroservicios6.ToString();
            }
            if (tiposervicio == "CI")
            {
                dataserviciosofrece.Rows[5].Cells[7].Value = acumulador8.ToString();
                dataserviciosofrece.Rows[5].Cells[6].Value = numeroservicios7.ToString();
            }
        }
        public void sumatoriamenos1ingresos()
        {
            sumatoriaingresos = 0;
            double.TryParse(txCostoOpera.Text, out costoOperacion);
            foreach (DataGridViewRow row in dataserviciosofrece.Rows)
            {
                sumatoriaingresos += Convert.ToDouble(row.Cells["Ingresos"].Value);
            }
            txingresototal.Text = sumatoriaingresos.ToString();
            if (sumatoriaingresos > costoOperacion)
            {
                labelresultado.Text = "El costo de operacion si es optimo";
            }
            else
            {
                labelresultado.Text = "El costo de operacion no es optimo";
            }
        }
        //nuevas pruebas 2-----------------------------------------------------------------------------------------------------
        private void btquitar2_Click(object sender, EventArgs e)
        {
            //datapersonas.Rows.Clear();
            probabilidadanterior2 = double.Parse(dataserviciosofrece.Rows[0].Cells[1].Value.ToString());
            //label8.Text = promedioanterior.ToString();
            dataserviciosofrece.Rows.Remove(dataserviciosofrece.Rows[0]);
            nuevasfilas2 = 5;
            nuevasuma2 = probabilidadanterior2 / nuevasfilas2;
            label8.Text = Math.Round(nuevasuma,4).ToString();
            double liminf1 = 0;
            for (int a = 0; a < 5; a++)
            {
                double promedioa2 = double.Parse(dataserviciosofrece.Rows[a].Cells[1].Value.ToString());
                double promedion2 = promedioa2 + nuevasuma2;
                double pro11 = double.Parse(dataserviciosofrece.Rows[0].Cells[1].Value.ToString());
                double pro22 = pro11 + (double.Parse(dataserviciosofrece.Rows[1].Cells[1].Value.ToString()));
                double pro33 = pro22 + (double.Parse(dataserviciosofrece.Rows[2].Cells[1].Value.ToString()));
                double pro44 = pro33 + (double.Parse(dataserviciosofrece.Rows[3].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[a].Cells[1].Value = Math.Round(promedion2, 4);
                dataserviciosofrece.Rows[0].Cells[2].Value = liminf1;
                dataserviciosofrece.Rows[0].Cells[3].Value = pro11;
                dataserviciosofrece.Rows[1].Cells[2].Value = pro11;
                dataserviciosofrece.Rows[1].Cells[3].Value = pro11 + (double.Parse(dataserviciosofrece.Rows[1].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[2].Cells[2].Value = pro22;
                dataserviciosofrece.Rows[2].Cells[3].Value = pro22 + (double.Parse(dataserviciosofrece.Rows[2].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[3].Cells[2].Value = pro33;
                dataserviciosofrece.Rows[3].Cells[3].Value = pro33 + (double.Parse(dataserviciosofrece.Rows[3].Cells[1].Value.ToString()));
                dataserviciosofrece.Rows[4].Cells[2].Value = pro44;
                dataserviciosofrece.Rows[4].Cells[3].Value = pro44 + (double.Parse(dataserviciosofrece.Rows[4].Cells[1].Value.ToString()));
                

            }
            tablanuevasegunda();
            ////NoPersonas();
            tablaserviciosmenosdos();
            //nocompararmenosuno();
            //sumatoriamenos1ingresos();
        }
        public void tablanuevasegunda()
        {
            a = 101;
            c = 221;
            Xo = 17;
            M = 17001;
            n = 31;
            //Sacar la moda
            double.TryParse(tbnA.Text, out aa);
            double.TryParse(tbnB.Text, out bb);
            double.TryParse(tbnC.Text, out cc);

            double ba = bb - aa;
            double cb = cc - bb;
            double ca = cc - aa;

            double puntocambio = ba / ca;
            pc.Text = puntocambio.ToString();

            //generar numeros 
            for (int i = 0; i < 30; i++)
            {
                modulo = (a * Xo + c) % M;
                random[i] = modulo / M;
                redondeado = (Math.Round(random[i], 5));
                ad = dataGridView2.Rows.Add();
                dataGridView2.Rows[ad].Cells[0].Value = (i + 1).ToString();
                dataGridView2.Rows[ad].Cells[1].Value = redondeado.ToString();
                if (redondeado <= puntocambio)
                {
                    double x1 = (aa + Math.Sqrt(ba * ca * redondeado));
                    rex1 = Math.Round(x1, 0);
                }
                else
                {
                    double x1 = (cc - Math.Sqrt(cb * ca * (1 - redondeado)));
                    rex1 = Math.Round(x1, 0);
                }
                dataGridView2.Rows[ad].Cells[2].Value = rex1.ToString();
                acumulador += random[i];
                pacientes[i] = rex1;
                m = modulo;
                Xo = m;


            }
        }
        public void tablaserviciosmenosdos()
        {
            for (int a = 0; a <= 5; a++)
            {
                dataserviciosofrece.Rows.Add();

            }
            nuevoingresototal = sumatoriacostos - 75;
            nuevospreciosumar = nuevoingresototal / 5;
            //label8.Text = nuevospreciosumar.ToString();
            //Costo
            dataserviciosofrece.Rows[1].Cells[5].Value = 150 + nuevospreciosumar;
            dataserviciosofrece.Rows[2].Cells[5].Value = 400 + nuevospreciosumar;
            dataserviciosofrece.Rows[3].Cells[5].Value = 950 + nuevospreciosumar;
            dataserviciosofrece.Rows[4].Cells[5].Value = 20 + nuevospreciosumar;
            dataserviciosofrece.Rows[5].Cells[5].Value = 200 + nuevospreciosumar;
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
