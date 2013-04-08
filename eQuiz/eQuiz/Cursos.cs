using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eQuiz
{
    class Cursos
    {
        public Boolean crear(string codigo, string nombre, string descripcion)
        {
            Boolean resultado = true;
            string[] var = new string[6];
            string[] valor = new string[6];
            string url = "";
            var[0] = "codigo";
            valor[0] = codigo;
            var[1] = "nombre";
            valor[1] = nombre;
            var[2] = "descripcion";
            valor[2] = descripcion;

            url = "http://localhost:3000/cursos.json";
            HttpConexion ejecutar = new HttpConexion();
            if (ejecutar.HttpPost(url, var, valor, "POST").Equals(""))
                resultado = false;
            return resultado;
        }
        public Boolean edit(string codigo, string nombre, string descripcion, string id)
        {
            Boolean resultado = true;
            string[] var = new string[6];
            string[] valor = new string[6];
            string url = "";
            var[0] = "codigo";
            valor[0] = codigo;
            var[1] = "nombre";
            valor[1] = nombre;
            var[2] = "descripcion";
            valor[2] = descripcion;
            url = "http://localhost:3000/cursos/" + id + ".json";
            HttpConexion ejecutar = new HttpConexion();
            if (ejecutar.HttpPost(url, var, valor, "PUT").Equals(""))
                resultado = false;
            return resultado;
        }
        public Boolean delete(string id)
        {
            Boolean resultado = true;
            string[] var = new string[1];
            string[] valor = new string[1];
            var[0] = "id";
            valor[0] = id;

            string url = "http://localhost:3000/cursos/" + id + ".json";
            HttpConexion ejecutar = new HttpConexion();
            if (ejecutar.HttpPost(url, var, valor, "DELETE").Equals(""))
                resultado = false;
            return resultado;
        }
    }
}
