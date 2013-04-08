using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eQuiz
{
    class Estudiante
    {
        public Boolean crear(string nombre, string apellidos, string cedula, string usuario, string email, string pass)
        {
            Boolean resultado = true;
            string[] var = new string[6];
            string[] valor = new string[6];
            string url = "";
            var[0] = "nombre";
            valor[0] = nombre;
            var[1] = "apellidos";
            valor[1] = apellidos;
            var[2] = "cedula";
            valor[2] = cedula;
            var[3] = "username";
            valor[3] = usuario;
            var[4] = "email";
            valor[4] = email;
            var[5] = "password";
            valor[5] = pass;
            url = "http://localhost:3000/estudiantes/add.json";
            HttpConexion ejecutar = new HttpConexion();
            if (ejecutar.HttpPost(url, var, valor,"POST").Equals(""))
                resultado = false;
            return resultado;
        }
        public Boolean edit(string nombre, string apellidos, string cedula, string usuario, string email, string pass, string id)
        {
            Boolean resultado = true;
            string[] var = new string[6];
            string[] valor = new string[6];
            string url = "";
            var[0] = "nombre";
            valor[0] = nombre;
            var[1] = "apellidos";
            valor[1] = apellidos;
            var[2] = "cedula";
            valor[2] = cedula;
            var[3] = "username";
            valor[3] = usuario;
            var[4] = "email";
            valor[4] = email;
            var[5] = "password";
            valor[5] = pass;

            url = "http://localhost:3000/estudiantes/" + id + ".json";
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

            string url = "http://localhost:3000/estudiantes/" + id + ".json";
            HttpConexion ejecutar = new HttpConexion();
            if (ejecutar.HttpPost(url, var, valor, "DELETE").Equals(""))
                resultado = false;
            return resultado;
        }
    }
}
