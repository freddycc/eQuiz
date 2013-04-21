using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eQuiz
{
    class Cursos
    {
        private HttpConexion ejecutar = new HttpConexion();
        public DataSet obtenerPruebActivas(string curso_id)
        {
            string url = "http://localhost:3000/cursos/" + curso_id + "/activas.xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }
        public DataSet obtenerPruebas(string curso_id)
        {
            string url = "http://localhost:3000/cursos/" + curso_id + "/pruebas.xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }

        public DataSet obtenerEstudiantes(string id)
        {
            string url = "http://localhost:3000/cursos/"+id+"/estudiantes.xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }

        public DataSet obtenerNoEstudiantes(string id)
        {

            string url = "http://localhost:3000/cursos/"+id+"/noestudiantes.xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }

        public Boolean crear(string codigo, string nombre, string descripcion, string ced_profe)
        {
            Boolean resultado = true;
            string[] var = new string[4];
            string[] valor = new string[4];
            string url = "";
            var[0] = "codigo";
            valor[0] = codigo;
            var[1] = "nombre";
            valor[1] = nombre;
            var[2] = "descripcion";
            valor[2] = descripcion;
            var[3] = "cedula";
            valor[3] = ced_profe;

            url = "http://localhost:3000/cursos.json";
            
            if (ejecutar.HttpPost(url, var, valor, "POST").Equals(""))
                resultado = false;
            return resultado;
        }
        public Boolean edit(string codigo, string nombre, string descripcion, string id_profe, string id)
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
            
            if (ejecutar.HttpPost(url, var, valor, "PUT").Equals(""))
                resultado = true;
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
            
            if (ejecutar.HttpPost(url, var, valor, "DELETE").Equals(""))
                resultado = false;
            return resultado;
        }
    }
}
