using System;
using System.Windows.Forms;
using AltadePiezas;
using Servicio;

namespace BDMuestras
{
    public partial class IniciarSesion : Form
    {
        public static string usuario;
        public static string contrasena;

        cUsuario cUsuario = new cUsuario(); // se utiliza para manipular usuarios de la BD
        //Inicio
        public IniciarSesion()
        {
            InitializeComponent();
            textBoxUsuario.LostFocus += TextBoxUsuario_LostFocus;
        }
        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            textBoxUsuario.Focus();
        }
        //Eventos
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            acceder();
        }
        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == string.Empty)
            {
                labelUsuario.Visible = true;
            }
            else
            {
                labelUsuario.Visible = false;
            }
        }
        private void TextBoxUsuario_LostFocus(object sender, EventArgs e)
        {
            usuario = textBoxUsuario.Text;
        }
        //Mettodos
        private void acceder()
        {
            if (textBoxUsuario.Text == string.Empty)
            {
                MessageBox.Show("No se ingreso usuarió", "Atención");
                textBoxUsuario.Focus();
            }
            else if (textBoxContraseña.Text == string.Empty)
            {
                MessageBox.Show("No se ingresó contraseña", "Atención");
                textBoxContraseña.Focus();
            }
            else
            {
                try
                {
                    //usuario = textBoxUsuario.Text;
                    contrasena = textBoxContraseña.Text;
                    //se validan nombre y contraseña
                    int confirmado = cUsuario.IniciarSesion(usuario, contrasena);
                    if (confirmado == 1)
                    {
                        Program.usuario = cUsuario.obtenerPK(usuario);
                        //se vacían los campos
                        textBoxUsuario.Text = string.Empty;
                        textBoxContraseña.Text = string.Empty;
                        textBoxUsuario.Focus();
                            AltadePiezas.Menu VentanaMenu = new AltadePiezas.Menu();
                            VentanaMenu.Show();
                            this.Hide();
                    }
                    else if (confirmado == 2)
                    {
                        textBoxContraseña.Focus();
                        textBoxContraseña.Text = string.Empty;
                        VerificarTextbox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex);
                }
            }
        }
        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "\r\n")
            {
                textBoxContraseña.Text = string.Empty;
            }
            VerificarTextbox();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Focus();
        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {
            textBoxContraseña.Focus();
        }

        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                usuario = textBoxUsuario.Text;
                textBoxContraseña.Focus();
                textBoxUsuario.Text = string.Empty;
                textBoxUsuario.Text = usuario;
            }
        }

        private void textBoxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                acceder();
                textBoxContraseña.Text = string.Empty;
            }
        }

        private void VerificarTextbox()
        {
            if (textBoxContraseña.Text == string.Empty)
            {
                labelContraseña.Visible = true;
            }
            else
            {
                labelContraseña.Visible = false;
            }
        }
    }
}

