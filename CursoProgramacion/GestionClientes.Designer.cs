
namespace CursoProgramacion
{
    partial class GestionClientes
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
            this.listClientes = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTarjetaDeCredito = new System.Windows.Forms.Label();
            this.txtTarjetaDeCredito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.ItemHeight = 15;
            this.listClientes.Location = new System.Drawing.Point(39, 39);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(247, 319);
            this.listClientes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(535, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(387, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(312, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(211, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(312, 86);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(387, 83);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(223, 23);
            this.txtApellido.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(312, 125);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(387, 122);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(223, 23);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblTarjetaDeCredito
            // 
            this.lblTarjetaDeCredito.AutoSize = true;
            this.lblTarjetaDeCredito.Location = new System.Drawing.Point(312, 166);
            this.lblTarjetaDeCredito.Name = "lblTarjetaDeCredito";
            this.lblTarjetaDeCredito.Size = new System.Drawing.Size(100, 15);
            this.lblTarjetaDeCredito.TabIndex = 10;
            this.lblTarjetaDeCredito.Text = "Tarjeta de crédito:";
                       // 
            // txtTarjetaDeCredito
            // 
            this.txtTarjetaDeCredito.Location = new System.Drawing.Point(387, 184);
            this.txtTarjetaDeCredito.Name = "txtTarjetaDeCredito";
            this.txtTarjetaDeCredito.Size = new System.Drawing.Size(223, 23);
            this.txtTarjetaDeCredito.TabIndex = 9;
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 424);
            this.Controls.Add(this.lblTarjetaDeCredito);
            this.Controls.Add(this.txtTarjetaDeCredito);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.listClientes);
            this.Name = "GestionClientes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTarjetaDeCredito;
        private System.Windows.Forms.TextBox txtTarjetaDeCredito;
    }
}