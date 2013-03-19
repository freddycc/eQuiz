using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
using System.Web.Script.Serialization;

namespace eQuiz
{
    class HttpConexion
    {
        public HttpWebRequest request;
        string usuario = "admin";
        string clave = "123";

        public DataSet ConvertXMLToDataSet(string url)
        {
            string xmlData = this.HttpGetAll(url);
            StringReader stream = null;
            XmlTextReader reader = null;
            try
            {
                DataSet xmlDS = new DataSet();
                stream = new StringReader(xmlData);
                // Load the XmlTextReader from the stream
                reader = new XmlTextReader(stream);
                xmlDS.ReadXml(reader);
                return xmlDS;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        public string HttpGetAll(string url)
        {
            HttpWebRequest req = WebRequest.Create(url)
                                 as HttpWebRequest;
            string result = null;
            using (HttpWebResponse resp = req.GetResponse()
                                          as HttpWebResponse)
            {
                StreamReader reader =
                    new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }

        public string HttpPost(string url, string[] paramName, string[] paramVal)
        {
            HttpWebRequest req = WebRequest.Create(new Uri(url))
                                 as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // Build a string with all the params, properly encoded.
            // We assume that the arrays paramName and paramVal are
            // of equal length:
            StringBuilder paramz = new StringBuilder();
            for (int i = 0; i < paramName.Length; i++)
            {
                paramz.Append(paramName[i]);
                paramz.Append("=");
                paramz.Append(HttpUtility.UrlEncode(paramVal[i]));
                paramz.Append("&");
            }

            //this.EjecutarAccion(url, "post", paramz);
            // Encode the parameters as form data:
            byte[] formData = UTF8Encoding.UTF8.GetBytes(paramz.ToString());
            req.ContentLength = formData.Length;

            // Send the request:
            using (Stream post = req.GetRequestStream())
            {
                post.Write(formData, 0, formData.Length);
            }

            // Pick up the response:
            string result = null;
            using (HttpWebResponse resp = req.GetResponse()
                                          as HttpWebResponse)
            {
                StreamReader reader =
                    new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }

            return result;
        }       

        public string EjecutarAccion(string url, string metodo, object modelo = null)
        {
            request = WebRequest.Create(url) as HttpWebRequest;
            request.Timeout = 10 * 1000;
            request.Method = metodo;
            request.ContentType = "application/json; charset=utf-8";

            string credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(usuario + ":" + clave));
            request.Headers.Add("Authorization", "Basic " + credentials);

            if (modelo != null)
            {
                var postString = new JavaScriptSerializer().Serialize(modelo);
                byte[] data = UTF8Encoding.UTF8.GetBytes(postString);
                request.ContentLength = data.Length;
                Stream postStream = request.GetRequestStream();
                postStream.Write(data, 0, data.Length);
            }
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            if (response.StatusCode != HttpStatusCode.NoContent)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                return reader.ReadToEnd();
            }

            return "";
        }
    }
}
