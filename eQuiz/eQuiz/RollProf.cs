using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace eQuiz
{
    class RollProf
    {
        private HttpConexion cnx = new HttpConexion();
        public void getPruebasActivas()
        {
            DataSet activas = cnx.ConvertXMLToDataSet("http://localhost:3000/pruebas/getactivas");
            
        }
    }
}
