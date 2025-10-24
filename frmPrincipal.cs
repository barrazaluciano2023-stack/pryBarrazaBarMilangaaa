using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarrazaBarMilangaaa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            int indiFila = 0;
            int indiColumna = 0;

            dtvDatos.Columns.Add("colMozos", "mozos");
            dtvDatos.Columns.Add("colComidas", "Comidas");
            dtvDatos.Columns.Add("colBebidasSinAlchol", "Bebidas Sin Alchol");
            dtvDatos.Columns.Add("colBebidasConAlchol", "Bebidas Con Alchol");
            dtvDatos.Columns.Add("colPostres", "Postres");

            dtvDatos.Rows.Add("Julio", "", "", "", "");
            dtvDatos.Rows.Add("Esteban", "", "", "", "");
            dtvDatos.Rows.Add("Javier", "", "", "", "");
            dtvDatos.Rows.Add("Gonzalo", "", "", "", "");
            dtvDatos.Rows.Add("Alberto", "", "", "", "");

            for (indiFila = 0; indiFila < dtvDatos.Rows.Count - 1; indiFila++)
            {
                for (indiColumna = 1; indiColumna < dtvDatos.Columns.Count; indiColumna++)
                {
                    dtvDatos[indiColumna, indiFila].Value = 0;
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //dtvDatos[0,1].Style.BackColor = Color.Red;
        }

        
    }
}
