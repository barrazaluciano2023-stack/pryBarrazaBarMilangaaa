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

            dgvVentas.Columns.Add("colMozos", "mozos");
            dgvVentas.Columns.Add("colComidas", "Comidas");
            dgvVentas.Columns.Add("colBebidasSinAlchol", "Bebidas Sin Alchol");
            dgvVentas.Columns.Add("colBebidasConAlchol", "Bebidas Con Alchol");
            dgvVentas.Columns.Add("colPostres", "Postres");

            dgvVentas.Rows.Add("Julio", "", "", "", "");
            dgvVentas.Rows.Add("Esteban", "", "", "", "");
            dgvVentas.Rows.Add("Javier", "", "", "", "");
            dgvVentas.Rows.Add("Gonzalo", "", "", "", "");
            dgvVentas.Rows.Add("Alberto", "", "", "", "");

            //for (indiFila = 0; indiFila < dgvVentas.Rows.Count - 1; indiFila++)
            //{
            //    for (indiColumna = 1; indiColumna < dgvVentas.Columns.Count; indiColumna++)
            //    {
            //        dgvVentas[indiColumna, indiFila].Value = 0;
            //    }
            //}
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                if (fila.IsNewRow) continue;

                foreach (DataGridViewCell celda in fila.Cells)
                {
                    // Verificar si está vacía
                    if (celda.Value == null || celda.Value.ToString().Trim() == "")
                    {
                        MessageBox.Show("⚠️ Faltan completar algunos datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Si no es la primera columna (mozo), validar que sea numérico
                    if (celda.ColumnIndex > 0)
                    {
                        double numero;
                        if (!double.TryParse(celda.Value.ToString(), out numero))
                        {
                            MessageBox.Show("🚫 Solo se permiten números en las columnas de ventas.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("✅ Todos los datos están cargados correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            string mozoDelDia = "";
            double maxVentas = 0;
            // Recorremos todas las filas
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                // Evitamos la fila nueva vacía
                if (dgvVentas.Rows[i].IsNewRow)
                    continue;

                double total = 0;

                // Sumamos las columnas numéricas (de la 1 a la 4)
                for (int j = 1; j <= 4; j++)
                {
                    double valor = 0;

                    // Convertimos el valor a número si no es nulo
                    if (dgvVentas.Rows[i].Cells[j].Value != null)
                        double.TryParse(dgvVentas.Rows[i].Cells[j].Value.ToString(), out valor);

                    total += valor;
                }

                // Comprobamos si este mozo tiene el máximo total
                if (total > maxVentas)
                {
                    maxVentas = total;
                    mozoDelDia = dgvVentas.Rows[i].Cells[0].Value.ToString();
                }
            }
            //dtvDatos[0,1].Style.BackColor = Color.Red;
            if (mozoDelDia != "")
                lblMozodelDia.Text = "El mozo del día: " + mozoDelDia + "\n" + "con " + maxVentas + " ventas.";
            else
                MessageBox.Show("No hay datos para calcular.");
        }


        private void btnTotales_Click_1(object sender, EventArgs e)
        {
            double totalComidas = 0;
            double totalSinAlcohol = 0;
            double totalConAlcohol = 0;
            double totalPostres = 0;

            // Recorremos todas las filas
            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                if (dgvVentas.Rows[i].IsNewRow)
                    continue;

                double comidas = 0, sinAlcohol = 0, conAlcohol = 0, postres = 0;

                double.TryParse(dgvVentas.Rows[i].Cells["colComidas"].Value?.ToString(), out comidas);
                double.TryParse(dgvVentas.Rows[i].Cells["colBebidasSinAlchol"].Value?.ToString(), out sinAlcohol);
                double.TryParse(dgvVentas.Rows[i].Cells["colBebidasConAlchol"].Value?.ToString(), out conAlcohol);
                double.TryParse(dgvVentas.Rows[i].Cells["colPostres"].Value?.ToString(), out postres);

                totalComidas += comidas;
                totalSinAlcohol += sinAlcohol;
                totalConAlcohol += conAlcohol;
                totalPostres += postres;
            }
            double totalGeneral = totalComidas + totalSinAlcohol + totalConAlcohol + totalPostres;

            if (totalGeneral != 0)
            {
                lblTotales.Text = "Total comidas: " + totalComidas +
                              "\nTotal bebidas sin alcohol: " + totalSinAlcohol +
                              "\nTotal bebidas con alcohol: " + totalConAlcohol +
                              "\nTotal postres: " + totalPostres +
                              "\nTotal general: " + totalGeneral;
            }
            else
            {
                MessageBox.Show("No hay datos para calcular.");
            }
        }
    }
}
