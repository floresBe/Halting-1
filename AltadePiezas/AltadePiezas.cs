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
        string fecha =  string.Empty;
        string horno = string.Empty;
        string numeroParte = string.Empty;
        int numeroCiclo = 0; 
        int cantidadPiezas = 0;
        List<string> numerosSerie;
        cLote lote;
        cPieza pieza;
        cParteCiclo parteCiclo;
        DialogResult respuesta;

        //Constructor
        public AltadePiezas()
        {
            InitializeComponent();
        }

        //Eventos
        //Seleccionar Fecha
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha = obtenerFecha();
            labelFecha.Text = fecha;
            llenarCiclos();
        }       
        //Seleccionar Horno
        private void cbHornos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCiclos();
        }
        //Seleccionar Ciclo
        private void comboBoxCiclos_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarNumerosParte();
        }
        //Seleccionar Numero de parte
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeroParte = comboBoxNosParte.SelectedItem.ToString();
            cantidadPiezas = obtenerPiezas(numeroParte);
            textBoxPiezas.Text = cantidadPiezas.ToString();

            primeraPosicion.SelectedItem = "01";
            segundaPosicion.SelectedItem = "01";
        }
        //Seleccionar primera posicion
        private void posicion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarSeries();
        }
        //Seleccionar Segunda posicion
        private void segundaPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarSeries();
        }
        //Agregar Series
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            respuesta = MessageBox.Show("Seguro que desea agregar las series a la base de datos?", "Agregar Pieza", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                //string parte = comboBox2.SelectedItem.ToString();
                //Program.lote = darDeAlta(Program.usuario, Program.fechaHorneo, Program.fechaAlta, Program.pkC, Program.serie, Program.aprobado, Program.defecto, Program.rebraze, parte);
                MessageBox.Show("Pieza/Lote dado de alta exitosamente.");
                this.Close();
            }
        }
        //Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodos
        private void llenarCiclos()
        {
            List<String> ciclos = new List<string>();
            cCiclo ciclo = new cCiclo();
            horno = obtenerHorno();
            if (horno == string.Empty)
            {
                //No selecciono horno
                return;
            }
            ciclos = ciclo.obtenerPorHornoyFecha(horno, fecha);
            ////llenado de ciclos para aplicacion tonta
            //string c;
            //for (int i = 1; i < 10; i++)
            //{
            //    c = generarCiclo(horno, i);
            //    ciclos.Add(c);
            //}
            ////
            if (ciclos.Count() == 0 || ciclos == null)
            {
                MessageBox.Show("No Existen ciclos con los datos selccionados.");
                return;
            }
            else
            {
                comboBoxCiclos.Items.Clear();
                foreach (string c in ciclos)
                {
                    comboBoxCiclos.Items.Add(c);
                }
            }
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
            cParteCiclo parteCiclo = new cParteCiclo();
            List<string> nosParte = new List<string>();
            string cicloSeleccionado = string.Empty;
            try
            {
                cicloSeleccionado = comboBoxCiclos.SelectedItem.ToString();
                ////llenado de partes para aplicacion tonta
                //nosParte.Clear();
                //nosParte.Add("464080-0001");
                //nosParte.Add("464080-5001");
                //nosParte.Add("469288-5003");
            }
            catch (Exception ex)
            {
                //no selecciono ciclo
                return;
            }
            numeroCiclo = obtenerNumero(cicloSeleccionado);
            nosParte = parteCiclo.obtenerNumerosPartePorCiclo(horno, numeroCiclo);
            if (nosParte != null && nosParte.Count > 0)
            {
                foreach (string noParte in nosParte)
                {
                    comboBoxNosParte.Items.Add(noParte);
                }
            }
        }
        private int obtenerNumero(string ciclo)
        {
            string[] datosCiclo = ciclo.Split();
            return Convert.ToInt32(datosCiclo[1]);
        }
        private int obtenerPiezas(string noParte)
        {
            //Cantidad de piezas que se dieron de alta durante el ciclo seleccionado (horno+numeroCiclo) 
            //se obtiene de la tabla parteCiclo 
            cParteCiclo parteCiclo = new cParteCiclo();
            parteCiclo.obtenerDatos(horno,numeroCiclo,noParte);
            return comboBoxNosParte.SelectedIndex + 2;
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

        private string generarColaPieza(int i)
        {
            if (i < 10)
                return "0" + i.ToString();
            else
                return i.ToString();

        }

        private List<string> generarSerie()
        {
            List<string> series = new List<string>();
            string serie = string.Empty;
            string posicion;
            string ciclo = generarCiclo(horno, numeroCiclo);
            int piezasAuxiliar = segundaPosicion.SelectedIndex - primeraPosicion.SelectedIndex + 1;
            if (piezasAuxiliar > piezas)
            {
                MessageBox.Show("La cantidad seleccionada sobrepasa la cantidad de piezas dadas de alta durante el ciclo.");
                return series;
            }
            else if (piezasAuxiliar <= 0)
            {
                try
                {
                    posicion = primeraPosicion.SelectedItem.ToString();
                    serie = ciclo + "-" + posicion;
                    series.Add(serie);
                }
                catch (Exception ex)
                {
                    //no selecciono posisciones
                }
            }
            else if (piezasAuxiliar >= 1)

            {
                for (int i = primeraPosicion.SelectedIndex + 1; i <= segundaPosicion.SelectedIndex + 1; i++)
                {
                    serie = ciclo + "-" + generarColaPieza(i);
                    series.Add(serie);
                }
            }
            return series;

            //if (textBoxSerieRango.Visible == true)
            //{
            //    if (textBoxSerieRango.Text != string.Empty && textBoxSerieRango.Text != null)
            //    {
            //        try
            //        {
            //            //////
            //            // NUMERO DE SERIE
            //            /////
            //            int serie1 = int.Parse(txtNoSerie.Text);
            //            int serie2 = Convert.ToInt32(textBoxSerieRango.Text);
            //            series = new List<int>();
            //            for (int i = serie1; i <= serie2; i++)
            //            {
            //                series.Add(i);
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Datos del rango no validos");
            //            return null;
            //        }
            //    }
            //    else
            //    {
            //        respuesta = MessageBox.Show("El campo de rango se encuentra vacio, desea agregar un rango de piezas?", "Agregar Rango", MessageBoxButtons.YesNo);
            //        if (respuesta == DialogResult.Yes)
            //        {
            //            textBoxSerieRango.Focus();
            //            return null;
            //        }
            //        else
            //        {
            //            textBoxSerieRango.Visible = false;
            //            int serie = 0;
            //            try
            //            {
            //                //////
            //                // NUMERO DE SERIE
            //                /////
            //                serie = int.Parse(txtNoSerie.Text);
            //            }
            //            catch (Exception)
            //            {
            //                MessageBox.Show("Dato no valido");
            //                return null;
            //            }
            //            series = new List<int>();
            //            series.Add(serie);
            //        }
            //    }

            //}
            //else
            //{
            //    int serie = 0;
            //    try
            //    {
            //        //////
            //        // NUMERO DE SERIE
            //        /////
            //        serie = int.Parse(txtNoSerie.Text);
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Dato no valido");
            //        return null;
            //    }
            //    series = new List<int>();
            //    series.Add(serie);
            //}

        }

        private int darDeAlta(int usuario, string fechaHorneo, string fechaAlta, int ciclo, List<int> serie, int aprobado, int defecto, int rebraze, string parte)
        {
            //string horno = obtenerHorno();

            //string prefijoHorno = Utilerias.generarPrefijo(horno, ciclo);
            //int lotePK = lote.Insertar(prefijoHorno, ciclo, usuario, fechaHorneo, fechaAlta);

            //foreach (var item in serie)
            //{
            //    pieza.Insertar(item, lotePK, defecto, aprobado, rebraze, parte,Program.reparo);
            //}
            //limpiarCampos();
            //return lotePK;
            return 1;
        }

        private void AltadePiezas_Load(object sender, EventArgs e)
        {
            //List<string> defectos = new List<string>();

            //defectos = defecto.ObtenerTodos();
            //if (defectos.Count != 0 && defectos != null)
            //{
            //    foreach (var item in defectos)
            //    {
            //        comboBoxDefecto.Items.Add(item);
            //    }
            //}
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

        
        

        
        private int obtenerUltimoNumeroDeSerie()
        {
            string parte = comboBoxNosParte.SelectedItem.ToString();
            cPieza pza = new cPieza();
            return pza.obtenerUltimoSeriePorNoParte(parte);
        }

        private void limpiarCampos()
        {
            Program.reparo = 0;
            Program.rebraze = 0;
        }
        
        private void mostrarSeries()
        {
            nosSerie = generarSerie();
            checkedListBoxNosSerie.Items.Clear();
            foreach (string noSerie in nosSerie)
            {
                checkedListBoxNosSerie.Items.Add(noSerie);
            }
        }

    }
}
