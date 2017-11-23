using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; // Avisar del espacio de nombre
using System.ComponentModel;

namespace Hilo
{
    public class Descargador
    {
        #region atributos
        private string html;
        private Uri direccion;
        #endregion

        #region constructores
        public Descargador(Uri direccion)
        {
            this.html = "";
            this.direccion = direccion;
        }
        #endregion

        #region metodos
        /// <summary>
        /// Inicia la descarga de la pagina web
        /// </summary>
        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                cliente.DownloadProgressChanged += WebClientDownloadProgressChanged;
                cliente.DownloadStringCompleted += WebClientDownloadCompleted;

                cliente.DownloadStringAsync(this.direccion);
                
            }
           

            catch (Exception e)
            {
                throw e;
            }
        }


        public delegate void Progress(int progreso);
        public event Progress progreso;
        private void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progreso(e.ProgressPercentage);
        }
        public delegate void EndProgress(string html);
        public event EndProgress end;
        private void WebClientDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                this.html = e.Result;             
                end(this.html);
                 
            }
            catch (Exception m)
            {
                end.Invoke("No se encuentra este sitio");
            }
            
            
        }

        #endregion
    }
}
