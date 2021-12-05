namespace StatusConsole
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.readStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.etiquetaTempBD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelArduino = new System.Windows.Forms.Label();
            this.registrarUpdateTemp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.actualizarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes registrados: ";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(217, 22);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(180, 25);
            this.comboBoxClientes.TabIndex = 1;
            // 
            // readStatus
            // 
            this.readStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readStatus.Location = new System.Drawing.Point(419, 63);
            this.readStatus.Name = "readStatus";
            this.readStatus.Size = new System.Drawing.Size(183, 23);
            this.readStatus.TabIndex = 2;
            this.readStatus.Text = "Consultar estado:";
            this.readStatus.UseVisualStyleBackColor = true;
            this.readStatus.Click += new System.EventHandler(this.readStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temp. registrada en BD: ";
            // 
            // etiquetaTempBD
            // 
            this.etiquetaTempBD.AutoSize = true;
            this.etiquetaTempBD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTempBD.ForeColor = System.Drawing.Color.ForestGreen;
            this.etiquetaTempBD.Location = new System.Drawing.Point(242, 66);
            this.etiquetaTempBD.Name = "etiquetaTempBD";
            this.etiquetaTempBD.Size = new System.Drawing.Size(43, 20);
            this.etiquetaTempBD.TabIndex = 4;
            this.etiquetaTempBD.Text = "--- ---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temperatura actual: ";
            // 
            // labelArduino
            // 
            this.labelArduino.AutoSize = true;
            this.labelArduino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArduino.ForeColor = System.Drawing.Color.Red;
            this.labelArduino.Location = new System.Drawing.Point(242, 111);
            this.labelArduino.Name = "labelArduino";
            this.labelArduino.Size = new System.Drawing.Size(43, 20);
            this.labelArduino.TabIndex = 6;
            this.labelArduino.Text = "--- ---";
            // 
            // registrarUpdateTemp
            // 
            this.registrarUpdateTemp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarUpdateTemp.Location = new System.Drawing.Point(419, 104);
            this.registrarUpdateTemp.Name = "registrarUpdateTemp";
            this.registrarUpdateTemp.Size = new System.Drawing.Size(183, 23);
            this.registrarUpdateTemp.TabIndex = 7;
            this.registrarUpdateTemp.Text = "Registrar Nueva Temp.";
            this.registrarUpdateTemp.UseVisualStyleBackColor = true;
            this.registrarUpdateTemp.Click += new System.EventHandler(this.registrarUpdateTemp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(291, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cº";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(291, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cº";
            // 
            // actualizarB
            // 
            this.actualizarB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarB.Location = new System.Drawing.Point(419, 24);
            this.actualizarB.Name = "actualizarB";
            this.actualizarB.Size = new System.Drawing.Size(183, 23);
            this.actualizarB.TabIndex = 10;
            this.actualizarB.Text = "Actualizar";
            this.actualizarB.UseVisualStyleBackColor = true;
            this.actualizarB.Click += new System.EventHandler(this.actualizarB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 154);
            this.Controls.Add(this.actualizarB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registrarUpdateTemp);
            this.Controls.Add(this.labelArduino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.etiquetaTempBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.readStatus);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Status Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Button readStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label etiquetaTempBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelArduino;
        private System.Windows.Forms.Button registrarUpdateTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button actualizarB;
    }
}

