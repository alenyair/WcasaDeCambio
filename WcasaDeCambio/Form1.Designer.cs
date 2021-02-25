namespace WcasaDeCambio
{
    partial class frmCasaDeCambio
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
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpTipodeMoneda = new System.Windows.Forms.GroupBox();
            this.rdoBTC = new System.Windows.Forms.RadioButton();
            this.rdoTransferencia = new System.Windows.Forms.RadioButton();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.rdoEfectivo = new System.Windows.Forms.RadioButton();
            this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.lblMonedaOrigen = new System.Windows.Forms.Label();
            this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.grpConversion = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtValordelcanje = new System.Windows.Forms.TextBox();
            this.txtCantidadValorCambiar = new System.Windows.Forms.TextBox();
            this.lblValorDelCanje = new System.Windows.Forms.Label();
            this.lblCantidadValorCambiar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDatosPersonales.SuspendLayout();
            this.grpTipodeMoneda.SuspendLayout();
            this.grpConversion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.cmbCiudad);
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtApellido);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblApellido);
            this.grpDatosPersonales.Controls.Add(this.lblCiudad);
            this.grpDatosPersonales.Controls.Add(this.lblDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(12, 46);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(747, 111);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(167, 80);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(455, 58);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(455, 30);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(167, 54);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(346, 65);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(351, 30);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(28, 84);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(28, 61);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpTipodeMoneda
            // 
            this.grpTipodeMoneda.Controls.Add(this.rdoBTC);
            this.grpTipodeMoneda.Controls.Add(this.rdoTransferencia);
            this.grpTipodeMoneda.Controls.Add(this.rdoCheque);
            this.grpTipodeMoneda.Controls.Add(this.rdoEfectivo);
            this.grpTipodeMoneda.Controls.Add(this.cmbMonedaDestino);
            this.grpTipodeMoneda.Controls.Add(this.lblMonedaDestino);
            this.grpTipodeMoneda.Controls.Add(this.lblMonedaOrigen);
            this.grpTipodeMoneda.Controls.Add(this.cmbMonedaOrigen);
            this.grpTipodeMoneda.Location = new System.Drawing.Point(65, 174);
            this.grpTipodeMoneda.Name = "grpTipodeMoneda";
            this.grpTipodeMoneda.Size = new System.Drawing.Size(257, 157);
            this.grpTipodeMoneda.TabIndex = 1;
            this.grpTipodeMoneda.TabStop = false;
            this.grpTipodeMoneda.Text = "Tipo de Moneda";
            // 
            // rdoBTC
            // 
            this.rdoBTC.AutoSize = true;
            this.rdoBTC.Location = new System.Drawing.Point(127, 132);
            this.rdoBTC.Name = "rdoBTC";
            this.rdoBTC.Size = new System.Drawing.Size(46, 17);
            this.rdoBTC.TabIndex = 16;
            this.rdoBTC.TabStop = true;
            this.rdoBTC.Text = "BTC";
            this.rdoBTC.UseVisualStyleBackColor = true;
            // 
            // rdoTransferencia
            // 
            this.rdoTransferencia.AutoSize = true;
            this.rdoTransferencia.Location = new System.Drawing.Point(129, 109);
            this.rdoTransferencia.Name = "rdoTransferencia";
            this.rdoTransferencia.Size = new System.Drawing.Size(90, 17);
            this.rdoTransferencia.TabIndex = 15;
            this.rdoTransferencia.TabStop = true;
            this.rdoTransferencia.Text = "Transferencia";
            this.rdoTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Location = new System.Drawing.Point(36, 132);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(62, 17);
            this.rdoCheque.TabIndex = 14;
            this.rdoCheque.TabStop = true;
            this.rdoCheque.Text = "Cheque";
            this.rdoCheque.UseVisualStyleBackColor = true;
            // 
            // rdoEfectivo
            // 
            this.rdoEfectivo.AutoSize = true;
            this.rdoEfectivo.Location = new System.Drawing.Point(36, 109);
            this.rdoEfectivo.Name = "rdoEfectivo";
            this.rdoEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdoEfectivo.TabIndex = 13;
            this.rdoEfectivo.TabStop = true;
            this.rdoEfectivo.Text = "Efectivo";
            this.rdoEfectivo.UseVisualStyleBackColor = true;
            // 
            // cmbMonedaDestino
            // 
            this.cmbMonedaDestino.FormattingEnabled = true;
            this.cmbMonedaDestino.Location = new System.Drawing.Point(114, 70);
            this.cmbMonedaDestino.Name = "cmbMonedaDestino";
            this.cmbMonedaDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaDestino.TabIndex = 12;
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.Location = new System.Drawing.Point(6, 73);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(83, 13);
            this.lblMonedaDestino.TabIndex = 11;
            this.lblMonedaDestino.Text = "Moneda destino";
            // 
            // lblMonedaOrigen
            // 
            this.lblMonedaOrigen.AutoSize = true;
            this.lblMonedaOrigen.Location = new System.Drawing.Point(6, 39);
            this.lblMonedaOrigen.Name = "lblMonedaOrigen";
            this.lblMonedaOrigen.Size = new System.Drawing.Size(78, 13);
            this.lblMonedaOrigen.TabIndex = 10;
            this.lblMonedaOrigen.Text = "Moneda origen";
            // 
            // cmbMonedaOrigen
            // 
            this.cmbMonedaOrigen.FormattingEnabled = true;
            this.cmbMonedaOrigen.Location = new System.Drawing.Point(114, 31);
            this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            this.cmbMonedaOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaOrigen.TabIndex = 10;
            // 
            // grpConversion
            // 
            this.grpConversion.Controls.Add(this.btnCambiar);
            this.grpConversion.Controls.Add(this.txtValordelcanje);
            this.grpConversion.Controls.Add(this.txtCantidadValorCambiar);
            this.grpConversion.Controls.Add(this.lblValorDelCanje);
            this.grpConversion.Controls.Add(this.lblCantidadValorCambiar);
            this.grpConversion.Location = new System.Drawing.Point(398, 174);
            this.grpConversion.Name = "grpConversion";
            this.grpConversion.Size = new System.Drawing.Size(257, 157);
            this.grpConversion.TabIndex = 2;
            this.grpConversion.TabStop = false;
            this.grpConversion.Text = "Conversion";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(94, 109);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 30);
            this.btnCambiar.TabIndex = 16;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtValordelcanje
            // 
            this.txtValordelcanje.Location = new System.Drawing.Point(150, 73);
            this.txtValordelcanje.Name = "txtValordelcanje";
            this.txtValordelcanje.Size = new System.Drawing.Size(100, 20);
            this.txtValordelcanje.TabIndex = 15;
            // 
            // txtCantidadValorCambiar
            // 
            this.txtCantidadValorCambiar.Location = new System.Drawing.Point(150, 39);
            this.txtCantidadValorCambiar.Name = "txtCantidadValorCambiar";
            this.txtCantidadValorCambiar.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadValorCambiar.TabIndex = 10;
            // 
            // lblValorDelCanje
            // 
            this.lblValorDelCanje.AutoSize = true;
            this.lblValorDelCanje.Location = new System.Drawing.Point(19, 73);
            this.lblValorDelCanje.Name = "lblValorDelCanje";
            this.lblValorDelCanje.Size = new System.Drawing.Size(77, 13);
            this.lblValorDelCanje.TabIndex = 14;
            this.lblValorDelCanje.Text = "Valor del canje";
            // 
            // lblCantidadValorCambiar
            // 
            this.lblCantidadValorCambiar.AutoSize = true;
            this.lblCantidadValorCambiar.Location = new System.Drawing.Point(19, 39);
            this.lblCantidadValorCambiar.Name = "lblCantidadValorCambiar";
            this.lblCantidadValorCambiar.Size = new System.Drawing.Size(125, 13);
            this.lblCantidadValorCambiar.TabIndex = 13;
            this.lblCantidadValorCambiar.Text = "Cantidad Valor a cambiar";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(320, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmCasaDeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpConversion);
            this.Controls.Add(this.grpTipodeMoneda);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCasaDeCambio";
            this.Text = "CASA DE CAMBIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCasaCambio_FormClosing);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpTipodeMoneda.ResumeLayout(false);
            this.grpTipodeMoneda.PerformLayout();
            this.grpConversion.ResumeLayout(false);
            this.grpConversion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpTipodeMoneda;
        private System.Windows.Forms.ComboBox cmbMonedaOrigen;
        private System.Windows.Forms.GroupBox grpConversion;
        private System.Windows.Forms.ComboBox cmbMonedaDestino;
        private System.Windows.Forms.Label lblMonedaDestino;
        private System.Windows.Forms.RadioButton rdoEfectivo;
        private System.Windows.Forms.Label lblMonedaOrigen;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtValordelcanje;
        private System.Windows.Forms.TextBox txtCantidadValorCambiar;
        private System.Windows.Forms.Label lblValorDelCanje;
        private System.Windows.Forms.Label lblCantidadValorCambiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdoBTC;
        private System.Windows.Forms.RadioButton rdoTransferencia;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

