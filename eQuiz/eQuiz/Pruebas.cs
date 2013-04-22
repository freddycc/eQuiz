using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eQuiz
{
    class Pruebas
    {
        HttpConexion ejecutar = new HttpConexion();
        public Boolean calificarPrueba(string id,string nota)
        {
            Boolean resultado = true;
            string[] var = new string[1];
            string[] valor = new string[1];
            string url = "";
            var[0] = "calificacion";
            valor[0] = nota;            

            url = "http://localhost:3000/respuesta/"+id+".json";

            if (ejecutar.HttpPost(url, var, valor, "PUT").Equals("")==false)
                resultado = false;
            return resultado;
        }
        public DataSet estuduateResp(string respuesta_id)
        {
            string url = "http://localhost:3000/respuesta/" + respuesta_id + "/estudiantes.xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }
        public DataSet getRespuesta(string respuesta_id)
        {
            string url = "http://localhost:3000/respuesta/" + respuesta_id+ ".xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }

        public DataSet obtenerRespuestas(string prueba_id)
        {
            string url = "http://localhost:3000/respuesta/" + prueba_id + "/getrespuestas.xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }
        public DataSet obtenerPreguntas(string prueba_id)
        {
            string url = "http://localhost:3000/pruebas/" + prueba_id + ".xml";
            return ejecutar.ConvertXMLToDataSet(url);
        }

        public Boolean crearRespuesta(string prueba_id, string estudiante_id, string respuesta)
        {
            Boolean resultado = true;
            string[] var = new string[4];
            string[] valor = new string[4];
            string url = "";
            var[0] = "prueba_id";
            valor[0] = prueba_id;
            var[1] = "estudiante_id";
            valor[1] = estudiante_id;
            var[2] = "respuesta";
            valor[2] = respuesta;            

            url = "http://localhost:3000/respuesta.json";

            if (ejecutar.HttpPost(url, var, valor, "POST").Equals(""))
                resultado = false;
            return resultado;
        }
    }
}
