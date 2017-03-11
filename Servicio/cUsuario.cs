﻿using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio
{
    public class cUsuario
    {
        /// <summary>
        ///         //Inserta un nuevo usuario
        /// </summary>
        /// <param name="noEmpleado">Numero de empleado</param>
        /// <param name="nombre">Nombre</param>
        /// <param name="ap">Apellido Paterno</param>
        /// <param name="am">Apellido Materno</param>
        /// <param name="contrasena">Contraseña</param>
        /// <param name="nivel">Nivel</param>
        /// <param name="turno">Turno</param>
        /// <returns></returns>
        public int Insertar(string usuario, string nombre, string ap, string am, string contrasena, int nivel, string turno)
        {
            bool existe = existeUsuario(usuario);
            if (!existe)
            {
                using (var entidad = new MuestrasHornosEntities())
                {
                    Usuarios us = null;
                    try
                    {
                        us = new Usuarios
                        {
                            No_Empleado = usuario,
                            Nombre = nombre,
                            aPaterno = ap,
                            aMaterno = am,
                            Contraseña = contrasena,
                            Nivel = nivel,
                            Turno = turno,
                            Activo = 1
                        };
                        entidad.Usuarios.Add(us);
                        entidad.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    return us.PK_Usuario;
                }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Inicia Sesion (Confirma usuario y contrasena)
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contrasena"></param>
        /// <returns></returns>
        public int IniciarSesion(string usuario, string contrasena)
        {
            int confirmacion = 0;
            try
            {
                var lista = new List<Usuarios>();
                using (var entidad = new MuestrasHornosEntities())
                {
                    var consultaUsuario = from c in entidad.Usuarios
                                          where c.No_Empleado.Equals(usuario)
                                          select c;
                    lista = consultaUsuario.ToList();
                    if (lista.Count > 0)
                    {
                        foreach (var item in lista)
                        {
                            if (item.Contraseña == contrasena)
                            {
                                confirmacion = 1;
                            }
                            else
                            {
                                MessageBox.Show("Contraseña inconrrecta.", "Atención");
                                confirmacion = 2;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el usuario: " + usuario, "Atención");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al acceder a la base de datos: " + ex);
            }
            return confirmacion;
        }
        /// <summary>
        /// Regresa el nivel del usuario ingresado por parametro
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int obtenerNivel(string usuario)
        {
            int nivel = 0;
            var lista = new List<Usuarios>();
            using (var entidad = new MuestrasHornosEntities())
            {
                var consultaUsuario = from c in entidad.Usuarios
                                      where c.No_Empleado.Equals(usuario)
                                      select c;
                lista = consultaUsuario.ToList();
                int usuarios = lista.Count;
                if (usuarios == 1)
                {
                    foreach (var item in lista)
                    {
                        nivel = item.Nivel;

                    }
                }
                else if (usuarios > 1)
                {
                    MessageBox.Show("ERROR. Existe mas de un usuario con el nombre: " + usuario, "Atención");
                    nivel = 0;
                }
                else
                {
                    MessageBox.Show("El usuario" + usuario + " no existe.");
                    nivel = 0;
                }
            }
            return nivel;
        }
        /// <summary>
        /// Regresa la clave principal del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int obtenerPK(string usuario)
        {
            int nivel = 0;
            var lista = new List<Usuarios>();
            using (var entidad = new MuestrasHornosEntities())
            {
                var consultaUsuario = from c in entidad.Usuarios
                                      where c.No_Empleado.Equals(usuario)
                                      select c;
                lista = consultaUsuario.ToList();
                int usuarios = lista.Count;
                if (usuarios == 1)
                {
                    foreach (var item in lista)
                    {
                        nivel = item.PK_Usuario;

                    }
                }
                else if (usuarios > 1)
                {
                    MessageBox.Show("ERROR. Existe mas de un usuario con el nombre: " + usuario, "Atención");
                    nivel = 0;
                }
                else
                {
                    MessageBox.Show("El usuario" + usuario + " no existe.");
                    nivel = 0;
                }
            }
            return nivel;
        }

        public void desactivarUsuario(string usuario)
        {
            var lista = new List<Usuarios>();
            try
            {
                using (var entidad = new MuestrasHornosEntities())
                {
                    var consultaUsuario = from c in entidad.Usuarios
                                          where c.No_Empleado.Equals(usuario)
                                          select c;
                    lista = consultaUsuario.ToList();
                    int usuarios = lista.Count;
                    if (usuarios == 1)
                    {
                        foreach (Usuarios user in lista)
                        {
                            user.Activo = 0;
                        }
                        entidad.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("El usuario" + usuario + " no existe.");

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        private bool existeUsuario(string usuario)
        {
            bool existe = false;
            var lista = new List<Usuarios>();
            try
            {
                using (var entidad = new MuestrasHornosEntities())
                {
                    var consultaUsuario = from c in entidad.Usuarios
                                          where c.No_Empleado.Equals(usuario)
                                          select c;
                    lista = consultaUsuario.ToList();
                    int usuarios = lista.Count;
                    if (usuarios > 0)
                    {
                        existe = true;
                    }
                    else
                    {
                        existe = false;

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return existe;
        }

        public Usuarios obtenerUsuario(int usuario)
        {
            Usuarios respuesta = null;
            using (var entidad = new MuestrasHornosEntities())
            {
                var consultaUsuario = from c in entidad.Usuarios
                                      where c.PK_Usuario.Equals(usuario)
                                      select c;
                respuesta = (Usuarios)consultaUsuario;
            }
            return respuesta;
        }
    }
}