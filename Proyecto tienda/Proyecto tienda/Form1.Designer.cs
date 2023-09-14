namespace Proyecto_tienda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltienda = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.dtgtienda = new System.Windows.Forms.DataGridView();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtienda)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltienda
            // 
            this.lbltienda.AutoSize = true;
            this.lbltienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltienda.Location = new System.Drawing.Point(289, 9);
            this.lbltienda.Name = "lbltienda";
            this.lbltienda.Size = new System.Drawing.Size(147, 46);
            this.lbltienda.TabIndex = 0;
            this.lbltienda.Text = "Tienda";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproducto.Location = new System.Drawing.Point(12, 89);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(245, 29);
            this.lblproducto.TabIndex = 1;
            this.lblproducto.Text = "Ingresa un producto";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.Location = new System.Drawing.Point(12, 174);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(292, 29);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Ingresa una descripcion";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(12, 256);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(217, 29);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "Ingresa el precio ";
            // 
            // dtgtienda
            // 
            this.dtgtienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtienda.Location = new System.Drawing.Point(17, 398);
            this.dtgtienda.Name = "dtgtienda";
            this.dtgtienda.RowHeadersWidth = 62;
            this.dtgtienda.RowTemplate.Height = 28;
            this.dtgtienda.Size = new System.Drawing.Size(692, 150);
            this.dtgtienda.TabIndex = 7;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(13, 133);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(244, 26);
            this.txtproducto.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(13, 206);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(244, 26);
            this.txtdescripcion.TabIndex = 9;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(13, 288);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(244, 26);
            this.txtprecio.TabIndex = 10;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Proyecto_tienda.Properties.Resources._1492790846_9cancel_84247;
            this.btneliminar.Location = new System.Drawing.Point(598, 315);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(59, 61);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = global::Proyecto_tienda.Properties.Resources.edit_modify_icon_149489;
            this.btnmodificar.Location = new System.Drawing.Point(508, 315);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(61, 61);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Transparent;
            this.btnagregar.Image = global::Proyecto_tienda.Properties.Resources.add_circle_create_expand_new_plus_icon_123218;
            this.btnagregar.Location = new System.Drawing.Point(413, 315);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(64, 61);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 649);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.dtgtienda);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.lbltienda);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltienda;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dtgtienda;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
    }
}

