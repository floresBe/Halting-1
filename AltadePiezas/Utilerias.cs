using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltadePiezas
{
    public class Utilerias
    {
        public static string generarPrefijo(string horno, int ciclo)
        {
            string prefijo = string.Empty;
            if(ciclo < 10)
            {
                prefijo =  horno + "000";
            }
            else if(ciclo < 100)
            {
                prefijo = horno + "00";
            }
            else if(ciclo < 1000)
            {
                prefijo = horno + "0";                
            }
            else
            {
                prefijo = horno;
            }
            return prefijo;
        }
        public static string generarCodigoSerie()
        {
            string resultado = string.Empty;
            DateTime fecha = DateTime.Now;
            cInicio initDAO = new cInicio();
            inicio _inicio = initDAO.obtenerInicio();
            string []s = fecha.ToString("dd-MM-yyyy").Split('-');

            resultado += obtenerLetraAno(_inicio.posicion,_inicio.ano,s[2]);

            return resultado;
        }
        public static string obtenerLetraAno(int? inicio,int? _ano,string s)
        {
            string respuesta = string.Empty;
            int ano = int.Parse(s);
            if(ano > _ano)
            {
                cambiarInicio();
            }
            int? posicion = inicio;
            if(posicion > 26)
            {
                reiniciarPosicion();                
            }

            switch (posicion)
            {
                case 1:
                    respuesta = "A";
                    break;
                case 2:
                    respuesta = "B";
                    break;
                case 3:
                    respuesta = "C";
                    break;
                case 4:
                    respuesta = "D";
                    break;
                case 5:
                    respuesta = "E";
                    break;
                case 6:
                    respuesta = "F";
                    break;
                case 7:
                    respuesta = "G";
                    break;
                case 8:
                    respuesta = "H";
                    break;
                case 9:
                    respuesta = "I";
                    break;
                case 10:
                    respuesta = "J";
                    break;
                case 11:
                    respuesta = "K";
                    break;
                case 12:
                    respuesta = "L";
                    break;
                case 13:
                    respuesta = "M";
                    break;
                case 14:
                    respuesta = "N";
                    break;
                case 15:
                    respuesta = "O";
                    break;
                case 16:
                    respuesta = "P";
                    break;
                case 17:
                    respuesta = "Q";
                    break;
                case 18:
                    respuesta = "R";
                    break;
                case 19:
                    respuesta = "S";
                    break;
                case 20:
                    respuesta = "T";
                    break;
                case 21:
                    respuesta = "U";
                    break;
                case 22:
                    respuesta = "V";
                    break;
                case 23:
                    respuesta = "W";
                    break;
                case 24:
                    respuesta = "X";
                    break;
                case 25:
                    respuesta = "Y";
                    break;
                case 26:
                    respuesta = "Z";
                    break;
            }


            return respuesta;
        }
        public static void cambiarInicio()
        {

        }
        public static void reiniciarPosicion()
        {

        }
    }
}
