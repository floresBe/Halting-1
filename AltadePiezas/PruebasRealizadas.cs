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
        string fecha;
        int pruebaR;
        int aprobada;
        int defecto;
        int serie;
        int pkSerie;
        DialogResult respuesta;

        public PruebasRealizadas()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string[] f = dateTimePicker.Value.ToString().Split();
            //////
            // HORNO
            /////
            string horno = string.Empty;
            fecha = f[0];
            labelFecha.Text = fecha;
            List<string> ciclos = ciclo.obtenerPorHornoyFecha(horno,fecha);
            cbCiclos.Items.Clear();
            if (ciclos.Count() == 0 || ciclos == null)
            {
                MessageBox.Show("No Existen ciclos en la fecha seleccionada.");
            }
            else
            {
                foreach (string ciclo in ciclos)
                {
                    cbCiclos.Items.Add(ciclo);
                }
            }
        }

        private void comboBoxCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sciclo = cbCiclos.SelectedItem.ToString().Split('|');
            //////
            // HORNO
            /////
            string horno = string.Empty;
            int ciclo = Convert.ToInt32(sciclo[1]);
            List<int> lotes = lote.ObtenerPorCiclo(horno,ciclo);
            if (lotes.Count != 0 && lotes != null)
            {
                comboBoxSerie.Items.Clear();

                foreach (var lote in lotes)
                {
                    foreach (var pieza in pieza.obtenerPiezasDeLote(lote))
                    {
                        comboBoxSerie.Items.Add(pieza);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se dieron piezas de alta en el ciclo seleccionado.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] prueba;
            if (comboBoxPruebas.SelectedItem != null)
            {
                prueba = comboBoxPruebas.SelectedItem.ToString().Split();
                pruebaR = Convert.ToInt32(prueba[1]);
            }
            else
            {
                MessageBox.Show("Seleccione Prueba.");
                return;
            }
            string[] defecto;
            if (radioButtonSi.Checked)
            {
                aprobada = 1;
            }
            else if (radioButtonNo.Checked)
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

            string sPrueba = "Prueba: " + pruebaR.ToString() + " Aprobada: " + aprobada;
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
            comboBoxDefecto.Visible = true;
            labelDefecto.Visible = true;
        }

        private void comboBoxPruebas_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSeleccionarPrueba.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelFecha.Text == "--/--/----")
            {
                MessageBox.Show("Seleccione fecha.");
                return;
            }
            if (cbCiclos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione Ciclo");
                return;
            }
            if (comboBoxSerie.SelectedItem != null)
            {
                serie = int.Parse(comboBoxSerie.SelectedItem.ToString());
                pkSerie = pieza.obtenerPKdeSerie(serie);
            }
            else
            {
                MessageBox.Show("Seleccione Serie.");
                return;
            }
            if (listBox1.Items.Count < 1)
            {
                MessageBox.Show("Debe capturar al menos 1 prueba.");
                return;
            }

            respuesta = MessageBox.Show("Seguro que desea agregar la(s) prueba(s) a la base de datos?", "Agregar Prueba", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                foreach (var item in listBox1.Items)
                {
                    string[] sprueba = item.ToString().Split();
                    int pruebaR = Convert.ToInt32(sprueba[1]);
                    int aprobada = Convert.ToInt32(sprueba[3]);
                    MessageBox.Show(pkSerie + " " + pruebaR + " " +aprobada + "" + defecto);
                    prueba.Insertar(fecha, pkSerie.ToString(), pruebaR, aprobada, defecto);
                }

                MessageBox.Show("Pruebas Agregadas");

                respuesta = MessageBox.Show("Agregar pruebas a otra pieza?", "Agregar Prueba", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    comboBoxSerie.SelectedItem = null;
                    comboBoxPruebas.SelectedItem = null;
                    labelSeleccionarPrueba.Visible = true;
                    radioButtonNo.Checked = false;
                    radioButtonSi.Checked = false;
                    labelDefecto.Visible = false;
                    comboBoxDefecto.Visible = false;
                    listBox1.Items.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void PruebasRealizadas_Load(object sender, EventArgs e)
        {
            List<string> pruebas = new List<string>();

            pruebas = this.pruebas.ObtenerTodos();
            if (pruebas != null && pruebas.Count > 0)
            {
                comboBoxPruebas.Items.Clear();
                foreach (var item in pruebas)
                {
                    comboBoxPruebas.Items.Add(item);
                }
            }

            List<string> defectos = new List<string>();
            defectos = this.defectos.ObtenerTodos();

            if(defectos != null && defectos.Count > 0)
            {
                foreach (var item in defectos)
                {
                    comboBoxDefecto.Items.Clear();
                    comboBoxDefecto.Items.Add(item);
                }
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
