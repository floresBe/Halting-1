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

 //Add comment
namespace AltadePiezas
{
    public partial class AltadePiezas : Form
    {
        string[] fecha;//fecha obtenida de datetimepike
        string[] c; //Ciclo obtenido de comboboxciclos
        string horn = string.Empty;
        int cicl;
        List<String> ciclos = new List<string>();
        cCiclo ciclo = new cCiclo();
        cLote lote = new cLote();
        cPieza pieza = new cPieza();
        cDefecto defecto = new cDefecto();
        cParteCiclo parteCiclo = new cParteCiclo();
        DialogResult respuesta;

        public AltadePiezas()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cbHornos.SelectedIndex != 0)
            {
                llenarCiclos();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoAprobado.Checked)
            {
                labelDefecto.Visible = true;
                comboBoxDefecto.Visible = true;
                rbRebrace.Visible = true;
                rbReparo.Visible = true;
                groupBoxRebraze.Visible = true;
            }
            else
            {
                labelDefecto.Visible = false;
                comboBoxDefecto.Visible = false;
                rbRebrace.Visible = false;
                rbReparo.Visible = false;
                groupBoxRebraze.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Program.fechaAlta = DateTime.Now.ToString();
            if (labelFecha.Text != "--/--/----")
            {
                Program.fechaHorneo = labelFecha.Text;
            }
            else
            {
                MessageBox.Show("Seleccione fecha.");
                return;
            }
            if (comboBoxCiclos.SelectedItem != null)
            {
                c = comboBoxCiclos.SelectedItem.ToString().Split();
                Program.noC = c[0];
                Program.pkC = Convert.ToInt32(c[1]);
            }
            else
            {
                MessageBox.Show("Seleccione Ciclo.");
                return;
            }
            Program.serie = generarSerie();//Lista de series

            if (Program.serie == null)
            {
                return;
            }
            if (radioButtonSiAprobado.Checked)
            {
                Program.aprobado = 1;
            }
            else if (radioButtonNoAprobado.Checked)
            {
                Program.aprobado = 0;
                if (comboBoxDefecto.SelectedItem != null)
                {
                    string[] defecto = comboBoxDefecto.SelectedItem.ToString().Split();
                    Program.defecto = Convert.ToInt32(defecto[0]);
                }
                else
                {
                    MessageBox.Show("Seleccione defecto.");
                    return;
                }

                if (rbRebrace.Checked)
                {
                    Program.rebraze = 1;
                }
                else if (rbReparo.Checked)
                {
                    Program.reparo = 1;
                }
                else
                {
                    MessageBox.Show("Indique si el lote/pieza necesita rebraze.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Indique si el lote/pieza fue o no aprobada.");
                return;
            }
            respuesta = MessageBox.Show("Seguro que desea agregar la pieza a la base de datos?", "Agregar Pieza", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                string parte = comboBox2.SelectedItem.ToString();
                Program.lote = darDeAlta(Program.usuario, Program.fechaHorneo, Program.fechaAlta, Program.pkC, Program.serie, Program.aprobado, Program.defecto, Program.rebraze, parte);
                MessageBox.Show("Pieza/Lote dado de alta exitosamente.");
                respuesta = MessageBox.Show("Agregar una nueva pieza/Lote?", "Agregar Pieza", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    txtNoSerie.Text = obtenerUltimoNumeroDeSerie().ToString();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelDefecto.Visible = false;
            comboBoxDefecto.Visible = false;
            rbRebrace.Visible = false;
            rbReparo.Visible = false;
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            if (textBoxSerieRango.Visible)
            {
                textBoxSerieRango.Visible = false;
                buttonMas.Text = "+";
            }
            else
            {
                textBoxSerieRango.Visible = true;
                buttonMas.Text = "-";
            }
        }

        private List<int> generarSerie()
        {
            List<int> series = null;

            if (textBoxSerieRango.Visible == true)
            {
                if (textBoxSerieRango.Text != string.Empty && textBoxSerieRango.Text != null)
                {
                    try
                    {
                        //////
                        // NUMERO DE SERIE
                        /////
                        int serie1 = int.Parse(txtNoSerie.Text);
                        int serie2 = Convert.ToInt32(textBoxSerieRango.Text);
                        series = new List<int>();
                        for (int i = serie1; i <= serie2; i++)
                        {
                            series.Add(i);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Datos del rango no validos");
                        return null;
                    }
                }
                else
                {
                    respuesta = MessageBox.Show("El campo de rango se encuentra vacio, desea agregar un rango de piezas?", "Agregar Rango", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        textBoxSerieRango.Focus();
                        return null;
                    }
                    else
                    {
                        textBoxSerieRango.Visible = false;
                        int serie = 0;
                        try
                        {
                            //////
                            // NUMERO DE SERIE
                            /////
                            serie = int.Parse(txtNoSerie.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Dato no valido");
                            return null;
                        }
                        series = new List<int>();
                        series.Add(serie);
                    }
                }

            }
            else
            {
                int serie = 0;
                try
                {
                    //////
                    // NUMERO DE SERIE
                    /////
                    serie = int.Parse(txtNoSerie.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Dato no valido");
                    return null;
                }
                series = new List<int>();
                series.Add(serie);
            }
            return series;
        }

        private int darDeAlta(int usuario, string fechaHorneo, string fechaAlta, int ciclo, List<int> serie, int aprobado, int defecto, int rebraze, string parte)
        {
            string horno = obtenerHorno();

            string prefijoHorno = Utilerias.generarPrefijo(horno, ciclo);
            int lotePK = lote.Insertar(prefijoHorno, ciclo, usuario, fechaHorneo, fechaAlta);

            foreach (var item in serie)
            {
                pieza.Insertar(item, lotePK, defecto, aprobado, rebraze, parte,Program.reparo);
            }
            limpiarCampos();
            return lotePK;
        }

        private void AltadePiezas_Load(object sender, EventArgs e)
        {
            List<string> defectos = new List<string>();

            defectos = defecto.ObtenerTodos();
            if (defectos.Count != 0 && defectos != null)
            {
                foreach (var item in defectos)
                {
                    comboBoxDefecto.Items.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCiclos();
        }

        private string obtenerHorno()
        {
            int h = 0;
            string horno = string.Empty;
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
            return horno;
        }

        private void llenarCiclos()
        {
            ciclo = new cCiclo();
            string horno = string.Empty;
            horno = obtenerHorno();
            try
            {
                fecha = dateTimePicker.Value.ToString().Split();
                labelFecha.Text = fecha[0];
            }
            catch
            {
                //No selecciono fecha
                return;
            }
            ciclos = ciclo.obtenerPorHornoyFecha(horno, fecha[0]);
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

        private void dividirCiclo(string ciclo)
        {
            string[] datos = ciclo.Split();
            horn = datos[0];
            cicl = Convert.ToInt32(datos[1]);
        }

        private void comboBoxCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> nosParte = null;
            string c = comboBoxCiclos.SelectedItem.ToString();
            try
            {
                dividirCiclo(c);
                nosParte = parteCiclo.obtenerNumerosPartePorCiclo(horn, cicl);
            }
            catch (Exception ex)
            {
                return;
            }

            foreach (var item in nosParte)
            {
                comboBox2.Items.Add(item);
            }
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoSerie.Text = obtenerUltimoNumeroDeSerie().ToString();
        }

        private int obtenerUltimoNumeroDeSerie()
        {
            string parte = comboBox2.SelectedItem.ToString();
            cPieza pza = new cPieza();
            return pza.obtenerUltimoSeriePorNoParte(parte);
        }

        private void limpiarCampos()
        {
            Program.reparo = 0;
            Program.rebraze = 0;
        }
    }
}
