using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Usuarios : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnBuscar = new Button();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            GroupBox1 = new GroupBox();
            Label3 = new Label();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            Label1 = new Label();
            txtIdUsuario = new TextBox();
            Label2 = new Label();
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnEditar = new Button();
            btnEditar.Click += new EventHandler(btnEditar_Click);
            txtNombre = new TextBox();
            btnAñadir = new Button();
            btnAñadir.Click += new EventHandler(btnAñadir_Click);
            Label4 = new Label();
            txtTelefono = new TextBox();
            Label5 = new Label();
            txtEstatus = new TextBox();
            txtContraseña = new TextBox();
            Label6 = new Label();
            Label7 = new Label();
            dgvUsuarios = new DataGridView();
            dgvUsuarios.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvUsuarios_CellFormatting);
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(568, 86);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 34);
            btnLimpiar.TabIndex = 82;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(568, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 34);
            btnBuscar.TabIndex = 81;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(txtEmail);
            GroupBox1.Controls.Add(txtDireccion);
            GroupBox1.Controls.Add(btnLimpiar);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(btnBuscar);
            GroupBox1.Controls.Add(txtIdUsuario);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(btnEliminar);
            GroupBox1.Controls.Add(btnEditar);
            GroupBox1.Controls.Add(txtNombre);
            GroupBox1.Controls.Add(btnAñadir);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(txtTelefono);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(txtEstatus);
            GroupBox1.Controls.Add(txtContraseña);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(670, 273);
            GroupBox1.TabIndex = 80;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Usuarios";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(113, 171);
            Label3.Name = "Label3";
            Label3.Size = new Size(55, 16);
            Label3.TabIndex = 83;
            Label3.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(176, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(358, 22);
            txtEmail.TabIndex = 84;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(176, 102);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(358, 22);
            txtDireccion.TabIndex = 62;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(72, 31);
            Label1.Name = "Label1";
            Label1.Size = new Size(98, 16);
            Label1.TabIndex = 51;
            Label1.Text = "ID USUARIO:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdUsuario.Location = new Point(176, 30);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(358, 22);
            txtIdUsuario.TabIndex = 52;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(94, 65);
            Label2.Name = "Label2";
            Label2.Size = new Size(76, 16);
            Label2.TabIndex = 53;
            Label2.Text = "NOMBRE:";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(568, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(66, 34);
            btnEliminar.TabIndex = 79;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(568, 172);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(66, 34);
            btnEditar.TabIndex = 78;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(176, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(358, 22);
            txtNombre.TabIndex = 54;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(568, 129);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(66, 34);
            btnAñadir.TabIndex = 76;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(77, 139);
            Label4.Name = "Label4";
            Label4.Size = new Size(91, 16);
            Label4.TabIndex = 57;
            Label4.Text = "TELEFONO:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(176, 139);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(358, 22);
            txtTelefono.TabIndex = 58;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(86, 203);
            Label5.Name = "Label5";
            Label5.Size = new Size(82, 16);
            Label5.TabIndex = 59;
            Label5.Text = "ESTATUS:";
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(176, 203);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 60;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(176, 238);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(358, 22);
            txtContraseña.TabIndex = 64;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(77, 102);
            Label6.Name = "Label6";
            Label6.Size = new Size(93, 16);
            Label6.TabIndex = 61;
            Label6.Text = "DIRECCION:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(53, 238);
            Label7.Name = "Label7";
            Label7.Size = new Size(115, 16);
            Label7.TabIndex = 63;
            Label7.Text = "CONTRASEÑA:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 301);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(670, 190);
            dgvUsuarios.TabIndex = 83;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(694, 502);
            Controls.Add(dgvUsuarios);
            Controls.Add(GroupBox1);
            Name = "Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            Load += new EventHandler(Usuarios_Load);
            ResumeLayout(false);

        }
        internal Button btnLimpiar;
        internal Button btnBuscar;
        internal GroupBox GroupBox1;
        internal TextBox txtDireccion;
        internal Label Label1;
        internal TextBox txtIdUsuario;
        internal Label Label2;
        internal TextBox txtNombre;
        internal Label Label4;
        internal TextBox txtTelefono;
        internal Label Label5;
        internal TextBox txtEstatus;
        internal TextBox txtContraseña;
        internal Label Label6;
        internal Label Label7;
        internal Button btnEliminar;
        internal Button btnEditar;
        internal Button btnAñadir;
        internal DataGridView dgvUsuarios;
        internal Label Label3;
        internal TextBox txtEmail;
    }
}