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
