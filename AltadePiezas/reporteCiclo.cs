using Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltadePiezas
{
    public partial class reporteCiclo : Form
    {
        private string fecha;
        private string horno;
        private string nParte;
        private cCiclo ciclo;
        private int numeroCiclo;

        //Constructor 
        public reporteCiclo()
        {
            InitializeComponent();
        }

        //Eventos
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fecha = obtenerFecha();
            labelFecha.Text = fecha;
            llenarCiclos();

        }
        private void cbHornos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCiclos();
        }
        private void comboBoxCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarNumerosParte();
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

        private string obtenerFecha()
        {
            string[] fecha;
            string f = string.Empty;
            try
            {
                fecha = dateTimePicker.Value.ToString().Split();
                f = fecha[0];
            }
            catch
            {
                //No selecciono fecha
                return f;
            }
            return f;
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

        private void llenarNumerosParte()
        {
           // parteCiclo = new cParteCiclo();
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
          //  parteCiclo = null;

        }
        private void dividirCiclo(string ciclo)
        {
            string[] datosCiclo = ciclo.Split();
            numeroCiclo = Convert.ToInt32(datosCiclo[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString();
            string hor = horno;
            nParte = comboBoxNosParte.SelectedItem.ToString();
            string cantidad = "5";
            string operador = "admin1";
            string inspector = textBoxInspector.Text;
            string observaciones = textBoxObservaciones.Text;


            MessageBox.Show(" Informacion a exportar: " + " fecha: " + fecha + " horno: " + hor + " noParte: " + nParte +" cantidad: " + cantidad + " Operador: " + operador + " Inspector: "+ inspector + " Observaciones: " + observaciones);
        }

        private void comboBoxNosParte_SelectedIndexChanged(object sender, EventArgs e)
        {
           nParte = comboBoxNosParte.SelectedItem.ToString();
        }
    }
}
