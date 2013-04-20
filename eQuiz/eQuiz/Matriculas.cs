using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eQuiz
{
    class Matriculas
    {
        HttpConexion ejecutar = new HttpConexion();
        public Boolean delMatricula(string curso_id, string estudiante_id)
        {
            Boolean resultado = true;
            string[] var = new string[2];
            string[] valor = new string[2];
            var[0] = "curso_id";
            valor[0] = curso_id;
            var[1] = "estudiante_id";
            valor[1] = estudiante_id;

            string url = "http://localhost:3000/cursos/" + curso_id + "/" + estudiante_id + "/delmatricula.json";

            if (ejecutar.HttpPost(url, var, valor, "DELETE").Equals(""))
                resultado = true;
            return resultado;
        }

        public Boolean creaMatricula(string curso_id, string estudiante_id)
        {
            Boolean resultado = true;
            string[] var = new string[2];
            string[] valor = new string[2];
            var[0] = "curso_id";
            valor[0] = curso_id;
            var[1] = "estudiante_id";
            valor[1] = estudiante_id;

            string url = "http://localhost:3000/matriculas.json";

            if (ejecutar.HttpPost(url, var, valor, "POST").Equals(""))
                resultado = true;
            return resultado;
        }
    }
}
