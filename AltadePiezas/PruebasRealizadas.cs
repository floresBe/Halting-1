using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicio;

namespace AltadePiezas
{
    public partial class PruebasRealizadas : Form
    {
        cCiclo ciclo = new cCiclo();
        cLote lote = new cLote();
        cPieza pieza = new cPieza();
        cPruebaPieza prueba = new cPruebaPieza();
        cPrueba pruebas = new cPrueba();
        cDefecto defectos = new cDefecto();
        cParteCiclo parteCiclo = new cParteCiclo();
        string fecha;
        int pruebaR;
        int aprobada;
        int defecto;
        int serie;
        int pkSerie;
        DialogResult respuesta;
        private string horno;
        private int numeroCiclo;

        public PruebasRealizadas()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fecha = obtenerFecha();
            labelFecha.Text = fecha;
            llenarCiclos();


            //string[] f = dateTimePicker.Value.ToString().Split();
            ////////
            //// HORNO
            ///////
            //string horno = string.Empty;
            //fecha = f[0];
            //labelFecha.Text = fecha;
            //List<string> ciclos = ciclo.obtenerPorHornoyFecha(horno,fecha);
            //cbCiclos.Items.Clear();
            //if (ciclos.Count() == 0 || ciclos == null)
            //{
            //    MessageBox.Show("No Existen ciclos en la fecha seleccionada.");
            //}
            //else
            //{
            //    foreach (string ciclo in ciclos)
            //    {
            //        cbCiclos.Items.Add(ciclo);
            //    }
            //}
        }
        private void comboBoxCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] sciclo = cbCiclos.SelectedItem.ToString().Split('|');
            ////////
            //// HORNO
            ///////
            //string horno = string.Empty;
            //int ciclo = Convert.ToInt32(sciclo[1]);
            //List<int> lotes = lote.ObtenerPorCiclo(horno,ciclo);
            //if (lotes.Count != 0 && lotes != null)
            //{
            //    comboBoxSerie.Items.Clear();

            //    foreach (var lote in lotes)
            //    {
            //        foreach (var pieza in pieza.obtenerPiezasDeLote(lote))
            //        {
            //            comboBoxSerie.Items.Add(pieza);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No se dieron piezas de alta en el ciclo seleccionado.");
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string prueba;
            if (comboBoxPruebas.SelectedItem != null)
            {
                prueba = comboBoxPruebas.SelectedItem.ToString();
               // pruebaR = Convert.ToInt32(prueba[1]);
            }
            else
            {
                MessageBox.Show("Seleccione Prueba.");
                return;
            }
            string[] defecto;
            if (radioButtonPaso.Checked)
            {
                aprobada = 1;
            }
            else if (radioButtonReparo.Checked)
            {
                aprobada = 2;
            }
            else if (radioButton2reparo.Checked)
            {
                aprobada = 3;
            }
            else if (radioButtonNoPaso.Checked)
            {
                aprobada = 0;
                if (comboBoxDefecto.SelectedItem != null)
                {
                    defecto = comboBoxDefecto.SelectedItem.ToString().Split();
                    this.defecto = Convert.ToInt32(defecto[1]);
                }
                else
                {
                    MessageBox.Show("Seleccione defecto.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Indique si la prueba fue o no aprobada.");
                return;
            }
            string sPrueba = "Prueba: " + prueba + " Aprobada: " + aprobada;
            if (aprobada == 0)
            {
                sPrueba += " Defecto: " + this.defecto.ToString();
            }
            listBox1.Items.Add(sPrueba);
        }
        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDefecto.Visible = false;
            labelDefecto.Visible = false;
        }
        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dividirCiclo(string ciclo)
        {
            string[] datosCiclo = ciclo.Split();
            numeroCiclo = Convert.ToInt32(datosCiclo[1]);
        }

        private void comboBoxPruebas_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSeleccionarPrueba.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (labelFecha.Text == "--/--/----")
            //{
            //    MessageBox.Show("Seleccione fecha.");
            //    return;
            //}
            //if (cbCiclos.SelectedItem == null)
            //{
            //    MessageBox.Show("Seleccione Ciclo");
            //    return;
            //}
            //if (comboBoxSerie.SelectedItem != null)
            //{
            //    serie = int.Parse(comboBoxSerie.SelectedItem.ToString());
            //    pkSerie = pieza.obtenerPKdeSerie(serie);
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione Serie.");
            //    return;
            //}
            //if (listBox1.Items.Count < 1)
            //{
            //    MessageBox.Show("Debe capturar al menos 1 prueba.");
            //    return;
            //}

            respuesta = MessageBox.Show("Seguro que desea agregar la(s) prueba(s) a la base de datos?", "Agregar Prueba", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                //    foreach (var item in listBox1.Items)
                //    {
                //        string[] sprueba = item.ToString().Split();
                //        int pruebaR = Convert.ToInt32(sprueba[1]);
                //        int aprobada = Convert.ToInt32(sprueba[3]);
                //        MessageBox.Show(pkSerie + " " + pruebaR + " " +aprobada + "" + defecto);
                //        prueba.Insertar(fecha, pkSerie.ToString(), pruebaR, aprobada, defecto);
                //    }

                MessageBox.Show("Pruebas Agregadas");
                this.Close();
            }
            //    respuesta = MessageBox.Show("Agregar pruebas a otra pieza?", "Agregar Prueba", MessageBoxButtons.YesNo);
            //    if (respuesta == DialogResult.Yes)
            //    {
            //        comboBoxSerie.SelectedItem = null;
            //        comboBoxPruebas.SelectedItem = null;
            //        labelSeleccionarPrueba.Visible = true;
            //        radioButtonNo.Checked = false;
            //        radioButtonSi.Checked = false;
            //        labelDefecto.Visible = false;
            //        comboBoxDefecto.Visible = false;
            //        listBox1.Items.Clear();
            //    }
            //    else
            //    {
            //        this.Close();
            //    }
            //}
        }

        private void PruebasRealizadas_Load(object sender, EventArgs e)
        {
            
            //List<string> pruebas = new List<string>();

            //pruebas = this.pruebas.ObtenerTodos();
            //if (pruebas != null && pruebas.Count > 0)
            //{
            //    comboBoxPruebas.Items.Clear();
            //    foreach (var item in pruebas)
            //    {
            //        comboBoxPruebas.Items.Add(item);
            //    }
            //}

            //List<string> defectos = new List<string>();
            //defectos = this.defectos.ObtenerTodos();

            //if(defectos != null && defectos.Count > 0)
            //{
            //    foreach (var item in defectos)
            //    {
            //        comboBoxDefecto.Items.Clear();
            //        comboBoxDefecto.Items.Add(item);
            //    }
            //}


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private string obtenerFecha()
        {
            string[] fecha;
            string f = string.Empty;
            try
            {
                fecha = dateTimePicker1.Value.ToString().Split();
                f = fecha[0];
            }
            catch
            {
                //No selecciono fecha
                return f;
            }
            return f;
        }
        private void llenarCiclos()
        {
            List<String> ciclos = new List<string>();
            ciclo = new cCiclo();
            horno = obtenerHorno();
            if (horno == string.Empty)
            {
                return;
            }
            //ciclos = ciclo.obtenerPorHornoyFecha(horno, fecha);
            //llenado de ciclos para aplicacion tonta
            string c;
            for (int i = 1; i < 10; i++)
            {
                c = generarCiclo(horno, i);
                ciclos.Add(c);
            }
            //
            if (ciclos.Count() == 0 || ciclos == null)
            {
                MessageBox.Show("No Existen ciclos con los datos selccionados.");
                comboBoxCiclos.Enabled = false;
                return;
            }
            else
            {
                comboBoxCiclos.Enabled = true;
                comboBoxCiclos.Items.Clear();
                foreach (string ciclo in ciclos)
                {
                    comboBoxCiclos.Items.Add(ciclo);
                }
            }
            ciclo = null;
        }
        private string obtenerHorno()
        {
            int h = 0;
            string horno = string.Empty;
            try
            {
                h = cbHornos.SelectedIndex;
                switch (h)
                {
                    case 0:
                        horno = "A";
                        break;
                    case 1:
                        horno = "I";
                        break;
                    case 2:
                        horno = "H";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                //no selecciono horno
                return horno;
            }
            return horno;
        }
        private string generarCiclo(string horno, int ciclo)
        {
            if (ciclo < 10)
            {
                horno += "000";
            }
            else if (ciclo < 100)
            {
                horno += "00";
            }
            else if (ciclo < 1000)
            {
                horno += "0";
            }
            return horno + " " + ciclo.ToString();
        }
        private void llenarNumerosParte()
        {
            parteCiclo = new cParteCiclo();
            List<string> nosParte = new List<string>();
            try
            {
                string cicloSeleccionado = comboBoxCiclos.SelectedItem.ToString();
                dividirCiclo(cicloSeleccionado);
                //nosParte = parteCiclo.obtenerNumerosPartePorCiclo(horno, numeroCiclo);

                //llenado de partes para aplicacion tonta
                nosParte.Clear();
                nosParte.Add("464080-0001");
                nosParte.Add("464080-5001");
                nosParte.Add("469288-5003");
            }
            catch (Exception ex)
            {
                //no selecciono ciclo
                return;
            }

            foreach (string noParte in nosParte)
            {
                comboBoxNosParte.Items.Add(noParte);
            }
            comboBoxNosParte.Enabled = true;
            parteCiclo = null;

        }
        private void cbHornos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCiclos();
        }

        private void comboBoxCiclos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            llenarNumerosParte();
        }

        private void comboBoxNosParte_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {

                string nSerie = generarCiclo(horno, numeroCiclo) + "-0" + i.ToString();
                comboBoxSerie.Items.Add(nSerie);

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoPaso.Checked)
            {
                comboBoxDefecto.Visible = true;
                labelDefecto.Visible = true;
            }else
            {
                comboBoxDefecto.Visible = false;
                labelDefecto.Visible = false;
            }
        }

        private void dateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            fecha = obtenerFecha();
            labelFecha.Text = fecha;
            llenarCiclos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha = obtenerFecha();
            labelFecha.Text = fecha;
            llenarCiclos();
        }
    }


}
