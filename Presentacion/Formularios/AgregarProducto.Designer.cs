namespace Presentacion.Formularios
{
    partial class AgregarProducto
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
            this.groupProd = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupProd
            // 
            this.groupProd.Controls.Add(this.txtprecio);
            this.groupProd.Controls.Add(this.txtdescription);
            this.groupProd.Controls.Add(this.txtcodigo);
            this.groupProd.Controls.Add(this.txtid);
            this.groupProd.Controls.Add(this.label4);
            this.groupProd.Controls.Add(this.dtpfecha);
            this.groupProd.Controls.Add(this.label3);
            this.groupProd.Controls.Add(this.label2);
            this.groupProd.Controls.Add(this.label1);
            this.groupProd.Controls.Add(this.lblid);
            this.groupProd.Location = new System.Drawing.Point(11, 12);
            this.groupProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupProd.Name = "groupProd";
            this.groupProd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupProd.Size = new System.Drawing.Size(324, 244);
            this.groupProd.TabIndex = 0;
            this.groupProd.TabStop = false;
            this.groupProd.Text = "Agregar Producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(115, 157);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(151, 20);
            this.txtprecio.TabIndex = 4;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(115, 98);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(151, 42);
            this.txtdescription.TabIndex = 3;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(115, 64);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(151, 20);
            this.txtcodigo.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(115, 32);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(151, 20);
            this.txtid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(115, 196);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(151, 20);
            this.dtpfecha.TabIndex = 5;
            this.dtpfecha.Value = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(21, 32);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 262);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 19);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 295);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupProd);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.groupProd.ResumeLayout(false);
            this.groupProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupProd;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtprecio;
    }
}