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
            dgvVentas = new DataGridView();
            btnValidar = new Button();
            btnMozoDia = new Button();
            btnTotales = new Button();
            lblMozodelDia = new Label();
            lblTotales = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(95, 24);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(578, 309);
            dgvVentas.TabIndex = 0;
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
            btnMozoDia.Location = new Point(95, 346);
            btnMozoDia.Name = "btnMozoDia";
            btnMozoDia.Size = new Size(129, 40);
            btnMozoDia.TabIndex = 2;
            btnMozoDia.Text = "Mozo del Dia";
            btnMozoDia.UseVisualStyleBackColor = true;
            btnMozoDia.Click += btnMozoDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Location = new Point(378, 346);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(129, 40);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click_1;
            // 
            // lblMozodelDia
            // 
            lblMozodelDia.AutoSize = true;
            lblMozodelDia.Location = new Point(230, 346);
            lblMozodelDia.Name = "lblMozodelDia";
            lblMozodelDia.Size = new Size(0, 15);
            lblMozodelDia.TabIndex = 4;
            // 
            // lblTotales
            // 
            lblTotales.AutoSize = true;
            lblTotales.Location = new Point(513, 346);
            lblTotales.Name = "lblTotales";
            lblTotales.Size = new Size(0, 15);
            lblTotales.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotales);
            Controls.Add(lblMozodelDia);
            Controls.Add(btnTotales);
            Controls.Add(btnMozoDia);
            Controls.Add(btnValidar);
            Controls.Add(dgvVentas);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnValidar;
        private Button btnMozoDia;
        private Button btnTotales;
        private Label lblMozodelDia;
        private Label lblTotales;
    }
}