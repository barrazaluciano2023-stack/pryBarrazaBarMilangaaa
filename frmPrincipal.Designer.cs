namespace pryBarrazaBarMilangaaa
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtvDatos = new DataGridView();
            btnValidar = new Button();
            btnMozoDia = new Button();
            btnTotales = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvDatos).BeginInit();
            SuspendLayout();
            // 
            // dtvDatos
            // 
            dtvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvDatos.Location = new Point(95, 24);
            dtvDatos.Name = "dtvDatos";
            dtvDatos.Size = new Size(578, 309);
            dtvDatos.TabIndex = 0;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(679, 171);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(111, 46);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar Datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDia
            // 
            btnMozoDia.Location = new Point(95, 359);
            btnMozoDia.Name = "btnMozoDia";
            btnMozoDia.Size = new Size(129, 40);
            btnMozoDia.TabIndex = 2;
            btnMozoDia.Text = "Mozo del Dia";
            btnMozoDia.UseVisualStyleBackColor = true;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(95, 405);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(129, 40);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDia);
            Controls.Add(btnValidar);
            Controls.Add(dtvDatos);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtvDatos;
        private Button btnValidar;
        private Button btnMozoDia;
        private Button btnTotales;
    }
}