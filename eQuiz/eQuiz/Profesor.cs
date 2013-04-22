using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eQuiz
{
    class Profesor
    {
        HttpConexion ejecutar = new HttpConexion();
        public DataSet obtenerCursos(string prof_id)
        {
            string url = "http://localhost:3000/profesore/" + prof_id + "/cursos.xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }

        public Boolean crear(string nombre, string apellidos, string cedula, string usuario, string email, string pass) {
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
            url = "http://localhost:3000/profesores/add.json";
            
            if(ejecutar.HttpPost(url, var, valor,"POST").Equals(""))
                resultado = false;
            return resultado;         
        }

        public Boolean edit(string nombre, string apellidos, string cedula, string usuario, string email,string pass, string id)
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
            
            url = "http://localhost:3000/profesores/"+id+".json";
            
            if (ejecutar.HttpPost(url, var, valor, "PUT").Equals(""))
                resultado = false;
            return resultado;            
        }

        public Boolean editinactivo(String id)
        {
            Boolean resultado = true;
            string[] var = new string[6];
            string[] valor = new string[6];
            string url = "";
            String estado = "activa";
            var[0] = "estado";
            valor[0] = estado;


            url = "http://localhost:3000/pruebas/" + id + "/updateprueba.json";
            
            if (ejecutar.HttpPost(url, var, valor, "PUT").Equals(""))
                resultado = false;
            return resultado;
        }

        public Boolean delete(string id) {
            Boolean resultado = true;
            string[] var = new string[1];
            string[] valor = new string[1];
            var[0] = "id";
            valor[0] = id;

            string url = "http://localhost:3000/profesores/" + id + ".json";
            
            if (ejecutar.HttpPost(url, var, valor, "DELETE").Equals(""))
                resultado = false;
            return resultado;
        }
        public  DataSet logprof(String usuario, String pass)
        {
            DataSet resultado;
            string[] var = new string[2];
            string[] valor = new string[2];
            var[0] = "username";
            valor[0] = usuario;
            var[1] = "password";
            valor[1] = pass;

            String url = "http://localhost:3000/profesores/prof.xml";
            string respuesta = ejecutar.HttpPost(url, var, valor, "POST");
            if (respuesta.Equals(""))
                resultado = null;
            else
                resultado = ejecutar.convertPostToDataSet(respuesta);
            return resultado;
        }

        public DataSet logest(String usuario, String pass)
        {
            DataSet resultado;
            string[] var = new string[2];
            string[] valor = new string[2];
            var[0] = "username";
            valor[0] = usuario;
            var[1] = "password";
            valor[1] = pass;

            String url = "http://localhost:3000/estudiantes/estud.xml";
            string respuesta = ejecutar.HttpPost(url, var, valor, "POST");
            if (respuesta.Equals(""))
                resultado = null;
            else
                resultado = ejecutar.convertPostToDataSet(respuesta);
            return resultado;
        }
    }
}
