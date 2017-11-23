using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class frmHistorial : Form
    {
        #region atributos
        public const string ARCHIVO_HISTORIAL = "historico.dat";
        #endregion

        #region constructores
        public frmHistorial()
        {
            InitializeComponent();
        }
        #endregion

        #region metodos
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            Archivos.Texto archivos = new Archivos.Texto(frmHistorial.ARCHIVO_HISTORIAL);
            //me falta aca
            List<string> datos;
            try
            {
                archivos.leer(out datos);
                this.lstHistorial.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion
    }
}
