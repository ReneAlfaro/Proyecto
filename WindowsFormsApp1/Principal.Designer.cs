namespace WindowsFormsApp1
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnventas = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btncompras = new System.Windows.Forms.Button();
            this.btnalmacen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.med = new System.Windows.Forms.Button();
            this.ve = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.Location = new System.Drawing.Point(42, 55);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(148, 41);
            this.btnventas.TabIndex = 1;
            this.btnventas.Text = "Usuarios";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(390, 71);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(93, 25);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(359, 114);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(33, 25);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(359, 168);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(33, 25);
            this.lblhora.TabIndex = 7;
            this.lblhora.Text = "...";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(374, 215);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(33, 25);
            this.lblfecha.TabIndex = 8;
            this.lblfecha.Text = "...";
            // 
            // btncompras
            // 
            this.btncompras.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.Location = new System.Drawing.Point(42, 102);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(148, 42);
            this.btncompras.TabIndex = 9;
            this.btncompras.Text = "Sucursales";
            this.btncompras.UseVisualStyleBackColor = false;
            // 
            // btnalmacen
            // 
            this.btnalmacen.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnalmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalmacen.Location = new System.Drawing.Point(42, 150);
            this.btnalmacen.Name = "btnalmacen";
            this.btnalmacen.Size = new System.Drawing.Size(148, 43);
            this.btnalmacen.TabIndex = 10;
            this.btnalmacen.Text = "Reportes";
            this.btnalmacen.UseVisualStyleBackColor = false;
            this.btnalmacen.Click += new System.EventHandler(this.btnalmacen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Área:";
            // 
            // med
            // 
            this.med.BackColor = System.Drawing.Color.CornflowerBlue;
            this.med.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.med.Location = new System.Drawing.Point(42, 199);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(212, 47);
            this.med.TabIndex = 11;
            this.med.Text = "Medicamentos";
            this.med.UseVisualStyleBackColor = false;
            // 
            // ve
            // 
            this.ve.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.ve.Location = new System.Drawing.Point(42, 252);
            this.ve.Name = "ve";
            this.ve.Size = new System.Drawing.Size(118, 44);
            this.ve.TabIndex = 12;
            this.ve.Text = "Ventas";
            this.ve.UseVisualStyleBackColor = false;
            // 
            // inv
            // 
            this.inv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.inv.Location = new System.Drawing.Point(42, 303);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(158, 47);
            this.inv.TabIndex = 13;
            this.inv.Text = "Inventario";
            this.inv.UseVisualStyleBackColor = false;
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.Color.CornflowerBlue;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.res.Location = new System.Drawing.Point(42, 356);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(148, 42);
            this.res.TabIndex = 14;
            this.res.Text = "Reservas";
            this.res.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.ve);
            this.Controls.Add(this.med);
            this.Controls.Add(this.btnalmacen);
            this.Controls.Add(this.btncompras);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnalmacen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button med;
        private System.Windows.Forms.Button ve;
        private System.Windows.Forms.Button inv;
        private System.Windows.Forms.Button res;
    }
}