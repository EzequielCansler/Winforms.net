﻿namespace IngematicaAppTest
{
    partial class FrmTest
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
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblLocalidadDestino = new System.Windows.Forms.Label();
            this.cbLocalidadDestino = new System.Windows.Forms.ComboBox();
            this.lblTipoTransporte = new System.Windows.Forms.Label();
            this.cbTipoTransporte = new System.Windows.Forms.ComboBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtFechaLlegada = new System.Windows.Forms.TextBox();
            this.lblFechaLlegada = new System.Windows.Forms.Label();
            this.txtDiasDemora = new System.Windows.Forms.TextBox();
            this.lblDiasDemora = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTipoDeTrayecto = new System.Windows.Forms.Label(); // label tipo de trayecto
            this.cbTipoTrayecto = new System.Windows.Forms.ComboBox(); // combobox tipo de trayecto
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(179, 43);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(165, 24);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(13, 48);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(89, 18);
            this.lblFechaInicial.TabIndex = 1;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblLocalidadDestino
            // 
            this.lblLocalidadDestino.AutoSize = true;
            this.lblLocalidadDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadDestino.Location = new System.Drawing.Point(12, 100);
            this.lblLocalidadDestino.Name = "lblLocalidadDestino";
            this.lblLocalidadDestino.Size = new System.Drawing.Size(126, 18);
            this.lblLocalidadDestino.TabIndex = 2;
            this.lblLocalidadDestino.Text = "Localidad Destino";
            // 
            // cbLocalidadDestino
            // 
            this.cbLocalidadDestino.DisplayMember = "Nombre";
            this.cbLocalidadDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalidadDestino.FormattingEnabled = true;
            this.cbLocalidadDestino.Location = new System.Drawing.Point(179, 97);
            this.cbLocalidadDestino.Name = "cbLocalidadDestino";
            this.cbLocalidadDestino.Size = new System.Drawing.Size(165, 26);
            this.cbLocalidadDestino.TabIndex = 3;
            this.cbLocalidadDestino.ValueMember = "IdLocalidad";
            // 
            // lblTipoTransporte
            // 
            this.lblTipoTransporte.AutoSize = true;
            this.lblTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTransporte.Location = new System.Drawing.Point(13, 147);
            this.lblTipoTransporte.Name = "lblTipoTransporte";
            this.lblTipoTransporte.Size = new System.Drawing.Size(113, 18);
            this.lblTipoTransporte.TabIndex = 4;
            this.lblTipoTransporte.Text = "Tipo Transporte";
            // 
            // cbTipoTransporte
            // 
            this.cbTipoTransporte.DisplayMember = "Nombre";
            this.cbTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTransporte.FormattingEnabled = true;
            this.cbTipoTransporte.Location = new System.Drawing.Point(179, 144);
            this.cbTipoTransporte.Name = "cbTipoTransporte";
            this.cbTipoTransporte.Size = new System.Drawing.Size(165, 26);
            this.cbTipoTransporte.TabIndex = 5;
            this.cbTipoTransporte.ValueMember = "IdTipoTransporte";
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txtFechaLlegada);
            this.gbResultado.Controls.Add(this.lblFechaLlegada);
            this.gbResultado.Controls.Add(this.txtDiasDemora);
            this.gbResultado.Controls.Add(this.lblDiasDemora);
            this.gbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(401, 43);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(394, 190);
            this.gbResultado.TabIndex = 6;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Location = new System.Drawing.Point(160, 97);
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.Size = new System.Drawing.Size(165, 24);
            this.txtFechaLlegada.TabIndex = 3;
            // 
            // lblFechaLlegada
            // 
            this.lblFechaLlegada.AutoSize = true;
            this.lblFechaLlegada.Location = new System.Drawing.Point(20, 101);
            this.lblFechaLlegada.Name = "lblFechaLlegada";
            this.lblFechaLlegada.Size = new System.Drawing.Size(104, 18);
            this.lblFechaLlegada.TabIndex = 2;
            this.lblFechaLlegada.Text = "Fecha Llegada";
            // 
            // txtDiasDemora
            // 
            this.txtDiasDemora.Location = new System.Drawing.Point(160, 56);
            this.txtDiasDemora.Name = "txtDiasDemora";
            this.txtDiasDemora.Size = new System.Drawing.Size(165, 24);
            this.txtDiasDemora.TabIndex = 1;
            // 
            // lblDiasDemora
            // 
            this.lblDiasDemora.AutoSize = true;
            this.lblDiasDemora.Location = new System.Drawing.Point(20, 60);
            this.lblDiasDemora.Name = "lblDiasDemora";
            this.lblDiasDemora.Size = new System.Drawing.Size(96, 18);
            this.lblDiasDemora.TabIndex = 0;
            this.lblDiasDemora.Text = "Dias Demora";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(675, 263);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 38);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(513, 263);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 38);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblTipoDeTrayecto
            // 
            this.lblTipoDeTrayecto.AutoSize = true;
            this.lblTipoDeTrayecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeTrayecto.Location = new System.Drawing.Point(13, 195);
            this.lblTipoDeTrayecto.Name = "lblTipoDeTrayecto";
            this.lblTipoDeTrayecto.Size = new System.Drawing.Size(113, 18);
            this.lblTipoDeTrayecto.TabIndex = 9;
            this.lblTipoDeTrayecto.Text = "Tipo Trayecto";     

            // 
            // cbTipoTrayecto
            // 
            this.cbTipoTrayecto.DisplayMember = "Nombre";
            this.cbTipoTrayecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTrayecto.FormattingEnabled = true;
            this.cbTipoTrayecto.Location = new System.Drawing.Point(179, 195);
            this.cbTipoTrayecto.Name = "cbTipoTrayecto";
            this.cbTipoTrayecto.Size = new System.Drawing.Size(165, 26);
            this.cbTipoTrayecto.TabIndex = 10;
            this.cbTipoTrayecto.ValueMember = "IdTipoTrayecto";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 373);
            this.Controls.Add(this.cbTipoTrayecto);
            this.Controls.Add(this.lblTipoDeTrayecto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.cbTipoTransporte);
            this.Controls.Add(this.lblTipoTransporte);
            this.Controls.Add(this.cbLocalidadDestino);
            this.Controls.Add(this.lblLocalidadDestino);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dtpFechaInicial);
            this.Name = "FrmTest";
            this.Text = "Test";
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblLocalidadDestino;
        private System.Windows.Forms.ComboBox cbLocalidadDestino;
        private System.Windows.Forms.Label lblTipoTransporte;
        private System.Windows.Forms.ComboBox cbTipoTransporte;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblDiasDemora;
        private System.Windows.Forms.TextBox txtFechaLlegada;
        private System.Windows.Forms.Label lblFechaLlegada;
        private System.Windows.Forms.TextBox txtDiasDemora;
        private System.Windows.Forms.Label lblTipoDeTrayecto; // Label tipo del trayecto
        private System.Windows.Forms.ComboBox cbTipoTrayecto; // DropDown de los trayectos
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

