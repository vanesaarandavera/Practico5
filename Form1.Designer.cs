namespace Practico5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LSaldo = new System.Windows.Forms.Label();
            this.BFoto = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBFechaNac = new System.Windows.Forms.TextBox();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.TBSaldo = new System.Windows.Forms.TextBox();
            this.TBFoto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.TBFoto);
            this.panel1.Controls.Add(this.TBSaldo);
            this.panel1.Controls.Add(this.RBMujer);
            this.panel1.Controls.Add(this.RBHombre);
            this.panel1.Controls.Add(this.TBFechaNac);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.BGuardar);
            this.panel1.Controls.Add(this.BFoto);
            this.panel1.Controls.Add(this.LSaldo);
            this.panel1.Controls.Add(this.LSexo);
            this.panel1.Controls.Add(this.LFechaNac);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Location = new System.Drawing.Point(45, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 359);
            this.panel1.TabIndex = 0;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(8, 11);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(92, 33);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(10, 59);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(98, 33);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LFechaNac
            // 
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Location = new System.Drawing.Point(10, 113);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(184, 33);
            this.LFechaNac.TabIndex = 2;
            this.LFechaNac.Text = "Fecha Nacimiento:";
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.Location = new System.Drawing.Point(10, 160);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(70, 33);
            this.LSexo.TabIndex = 3;
            this.LSexo.Text = "Sexo:";
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.Location = new System.Drawing.Point(10, 201);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(78, 33);
            this.LSaldo.TabIndex = 4;
            this.LSaldo.Text = "Saldo:";
            // 
            // BFoto
            // 
            this.BFoto.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFoto.ForeColor = System.Drawing.Color.Black;
            this.BFoto.Location = new System.Drawing.Point(24, 257);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(64, 22);
            this.BFoto.TabIndex = 5;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.ForeColor = System.Drawing.Color.Black;
            this.BGuardar.Location = new System.Drawing.Point(144, 300);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(76, 45);
            this.BGuardar.TabIndex = 6;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(104, 14);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(186, 37);
            this.TBNombre.TabIndex = 7;
            // 
            // TBApellido
            // 
            this.TBApellido.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.Location = new System.Drawing.Point(111, 61);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(177, 37);
            this.TBApellido.TabIndex = 8;
            // 
            // TBFechaNac
            // 
            this.TBFechaNac.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFechaNac.Location = new System.Drawing.Point(205, 113);
            this.TBFechaNac.Name = "TBFechaNac";
            this.TBFechaNac.Size = new System.Drawing.Size(166, 37);
            this.TBFechaNac.TabIndex = 9;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.Location = new System.Drawing.Point(100, 158);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(107, 37);
            this.RBHombre.TabIndex = 10;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = true;
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(237, 156);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(88, 37);
            this.RBMujer.TabIndex = 11;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // TBSaldo
            // 
            this.TBSaldo.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSaldo.Location = new System.Drawing.Point(100, 206);
            this.TBSaldo.Name = "TBSaldo";
            this.TBSaldo.Size = new System.Drawing.Size(271, 37);
            this.TBSaldo.TabIndex = 12;
            // 
            // TBFoto
            // 
            this.TBFoto.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFoto.Location = new System.Drawing.Point(101, 257);
            this.TBFoto.Name = "TBFoto";
            this.TBFoto.Size = new System.Drawing.Size(270, 37);
            this.TBFoto.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practico5.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "Formulario con DataGrid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LFechaNac;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BFoto;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.TextBox TBFechaNac;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.TextBox TBFoto;
        private System.Windows.Forms.TextBox TBSaldo;
    }
}

