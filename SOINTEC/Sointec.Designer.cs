namespace SOINTEC
{
    partial class Sointec
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
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.txtNumPersonas = new System.Windows.Forms.TextBox();
            this.lvwDatos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersonas.Location = new System.Drawing.Point(12, 40);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(206, 17);
            this.lblNumPersonas.TabIndex = 0;
            this.lblNumPersonas.Text = "Ingrese el número de personas: ";
            // 
            // txtNumPersonas
            // 
            this.txtNumPersonas.Location = new System.Drawing.Point(15, 73);
            this.txtNumPersonas.Multiline = true;
            this.txtNumPersonas.Name = "txtNumPersonas";
            this.txtNumPersonas.Size = new System.Drawing.Size(219, 24);
            this.txtNumPersonas.TabIndex = 1;
            // 
            // lvwDatos
            // 
            this.lvwDatos.AllowColumnReorder = true;
            this.lvwDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwDatos.FullRowSelect = true;
            this.lvwDatos.GridLines = true;
            this.lvwDatos.HideSelection = false;
            this.lvwDatos.LabelEdit = true;
            this.lvwDatos.Location = new System.Drawing.Point(102, 134);
            this.lvwDatos.Name = "lvwDatos";
            this.lvwDatos.Size = new System.Drawing.Size(589, 197);
            this.lvwDatos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwDatos.TabIndex = 2;
            this.lvwDatos.UseCompatibleStateImageBehavior = false;
            this.lvwDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Text = "Número Cotización";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Número de personas";
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Presupuesto";
            this.columnHeader3.Width = 195;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(102, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 51);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(257, 359);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 51);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrar.FlatAppearance.BorderSize = 2;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(408, 359);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(132, 51);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(559, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 51);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Sointec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lvwDatos);
            this.Controls.Add(this.txtNumPersonas);
            this.Controls.Add(this.lblNumPersonas);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Sointec";
            this.Text = "La Langosta Ahumada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.TextBox txtNumPersonas;
        private System.Windows.Forms.ListView lvwDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

