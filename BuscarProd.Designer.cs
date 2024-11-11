namespace Form1
{
    partial class BuscarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProd));
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.dataGridBuscar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscar = new System.Windows.Forms.Button();
            this.nombreb = new System.Windows.Forms.TextBox();
            this.cod_producto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(586, 140);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.Location = new System.Drawing.Point(586, 99);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // dataGridBuscar
            // 
            this.dataGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscar.Location = new System.Drawing.Point(139, 210);
            this.dataGridBuscar.Name = "dataGridBuscar";
            this.dataGridBuscar.Size = new System.Drawing.Size(522, 148);
            this.dataGridBuscar.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.nombreb);
            this.panel1.Controls.Add(this.cod_producto);
            this.panel1.Location = new System.Drawing.Point(181, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 55);
            this.panel1.TabIndex = 8;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.Location = new System.Drawing.Point(297, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(60, 23);
            this.buscar.TabIndex = 4;
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // nombreb
            // 
            this.nombreb.Location = new System.Drawing.Point(119, 14);
            this.nombreb.Name = "nombreb";
            this.nombreb.Size = new System.Drawing.Size(180, 20);
            this.nombreb.TabIndex = 2;
            // 
            // cod_producto
            // 
            this.cod_producto.AutoSize = true;
            this.cod_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_producto.Location = new System.Drawing.Point(9, 14);
            this.cod_producto.Name = "cod_producto";
            this.cod_producto.Size = new System.Drawing.Size(103, 16);
            this.cod_producto.TabIndex = 0;
            this.cod_producto.Text = "cod_producto";
            // 
            // BuscarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.dataGridBuscar);
            this.Controls.Add(this.panel1);
            this.Name = "BuscarProd";
            this.Text = "BuscarProd";
            this.Load += new System.EventHandler(this.BuscarProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.DataGridView dataGridBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox nombreb;
        private System.Windows.Forms.Label cod_producto;
    }
}