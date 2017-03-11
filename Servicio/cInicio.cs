using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class cInicio
    {
        public bool Insertar(int _ano, int _posicion)
        {
            bool respuesta = false;

                using (var entidad = new MuestrasHornosEntities())
                {
                    inicio start = null;
                    try
                    {
                        start = new inicio
                        {
                            ano = _ano,
                            posicion = _posicion
                        };
                        entidad.inicio.Add(start);
                        entidad.SaveChanges();
                    respuesta = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            return respuesta;
        }

        public inicio obtenerInicio()
        {
            List<inicio> respuesta = null;
            using (var entidad = new MuestrasHornosEntities())
            {
                var consultaUsuario = from c in entidad.inicio
                                      select c;
                respuesta = consultaUsuario.ToList();
            }
            return respuesta.LastOrDefault();
        }
    }
}
