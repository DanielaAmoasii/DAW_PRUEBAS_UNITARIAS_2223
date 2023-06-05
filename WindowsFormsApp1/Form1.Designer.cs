namespace GestionBancariaAppNS
{
    partial class GestionBancariaApp
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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.rbReintegro = new System.Windows.Forms.RadioButton();
            this.btOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(260, 59);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(364, 53);
            this.txtSaldo.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(260, 170);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(364, 53);
            this.txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Checked = true;
            this.rbIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngreso.Location = new System.Drawing.Point(105, 282);
            this.rbIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(173, 50);
            this.rbIngreso.TabIndex = 4;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "Ingreso";
            this.rbIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbIngreso.UseVisualStyleBackColor = true;
            // 
            // rbReintegro
            // 
            this.rbReintegro.AutoSize = true;
            this.rbReintegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReintegro.Location = new System.Drawing.Point(348, 282);
            this.rbReintegro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbReintegro.Name = "rbReintegro";
            this.rbReintegro.Size = new System.Drawing.Size(214, 50);
            this.rbReintegro.TabIndex = 5;
            this.rbReintegro.TabStop = true;
            this.rbReintegro.Text = "Reintegro";
            this.rbReintegro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rbReintegro.UseVisualStyleBackColor = true;
            // 
            // btOperar
            // 
            this.btOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOperar.Location = new System.Drawing.Point(704, 107);
            this.btOperar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOperar.Name = "btOperar";
            this.btOperar.Size = new System.Drawing.Size(244, 90);
            this.btOperar.TabIndex = 6;
            this.btOperar.Text = "Realizar Operación";
            this.btOperar.UseVisualStyleBackColor = true;
            this.btOperar.Click += new System.EventHandler(this.btOperar_Click);
            // 
            // GestionBancariaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 399);
            this.Controls.Add(this.btOperar);
            this.Controls.Add(this.rbReintegro);
            this.Controls.Add(this.rbIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtSaldo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionBancariaApp";
            this.Text = "La Banca Siempre Gana";
            this.Load += new System.EventHandler(this.GestionBancariaApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.RadioButton rbReintegro;
        private System.Windows.Forms.Button btOperar;
    }
}

