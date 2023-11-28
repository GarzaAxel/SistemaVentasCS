using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Categorias : Form
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
            dgvCategoria = new DataGridView();
            GroupBox1 = new GroupBox();
            txtIdModificar = new TextBox();
            Label3 = new Label();
            txtDescripcion = new TextBox();
            btnLimpiar = new Button();
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            Label1 = new Label();
            btnBuscar = new Button();
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
            txtIdCategoria = new TextBox();
            Label2 = new Label();
            btnEliminar = new Button();
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
            btnEditar = new Button();
            btnEditar.Click += new EventHandler(btnEditar_Click);
            txtNombre = new TextBox();
            btnAñadir = new Button();
            btnAñadir.Click += new EventHandler(btnAñadir_Click);
            Label5 = new Label();
            txtEstatus = new TextBox();
            txtIdCrear = new TextBox();
            Label6 = new Label();
            Label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(12, 267);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(670, 190);
            dgvCategoria.TabIndex = 87;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            GroupBox1.Controls.Add(txtIdModificar);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(txtDescripcion);
            GroupBox1.Controls.Add(btnLimpiar);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(btnBuscar);
            GroupBox1.Controls.Add(txtIdCategoria);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(btnEliminar);
            GroupBox1.Controls.Add(btnEditar);
            GroupBox1.Controls.Add(txtNombre);
            GroupBox1.Controls.Add(btnAñadir);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(txtEstatus);
            GroupBox1.Controls.Add(txtIdCrear);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(Label7);
            GroupBox1.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(670, 249);
            GroupBox1.TabIndex = 86;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Categorias";
            // 
            // txtIdModificar
            // 
            txtIdModificar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdModificar.Location = new Point(176, 207);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(358, 22);
            txtIdModificar.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(44, 210);
            Label3.Name = "Label3";
            Label3.Size = new Size(123, 16);
            Label3.TabIndex = 83;
            Label3.Text = "ID UMODIFICAR:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(176, 102);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(358, 22);
            txtDescripcion.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(567, 69);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(66, 34);
            btnLimpiar.TabIndex = 82;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(50, 33);
            Label1.Name = "Label1";
            Label1.Size = new Size(117, 16);
            Label1.TabIndex = 51;
            Label1.Text = "ID CATEGORIA:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(567, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 34);
            btnBuscar.TabIndex = 81;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCategoria.Location = new Point(176, 30);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(358, 22);
            txtIdCategoria.TabIndex = 1;
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
            btnEliminar.Location = new Point(567, 195);
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
            btnEditar.Location = new Point(567, 155);
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
            txtNombre.TabIndex = 2;
            // 
            // btnAñadir
            // 
            btnAñadir.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAñadir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAñadir.Location = new Point(567, 112);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(66, 34);
            btnAñadir.TabIndex = 76;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(85, 140);
            Label5.Name = "Label5";
            Label5.Size = new Size(82, 16);
            Label5.TabIndex = 59;
            Label5.Text = "ESTATUS:";
            // 
            // txtEstatus
            // 
            txtEstatus.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEstatus.Location = new Point(176, 138);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(358, 22);
            txtEstatus.TabIndex = 4;
            // 
            // txtIdCrear
            // 
            txtIdCrear.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCrear.Location = new Point(176, 172);
            txtIdCrear.Name = "txtIdCrear";
            txtIdCrear.Size = new Size(358, 22);
            txtIdCrear.TabIndex = 5;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(55, 105);
            Label6.Name = "Label6";
            Label6.Size = new Size(113, 16);
            Label6.TabIndex = 61;
            Label6.Text = "DESCRIPCION:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.Transparent;
            Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(74, 175);
            Label7.Name = "Label7";
            Label7.Size = new Size(93, 16);
            Label7.TabIndex = 63;
            Label7.Text = "ID UCREAR:";
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 468);
            Controls.Add(dgvCategoria);
            Controls.Add(GroupBox1);
            Name = "Categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(Categorias_Load);
            ResumeLayout(false);

        }

        internal DataGridView dgvCategoria;
        internal GroupBox GroupBox1;
        internal TextBox txtIdModificar;
        internal Label Label3;
        internal TextBox txtDescripcion;
        internal Button btnLimpiar;
        internal Label Label1;
        internal Button btnBuscar;
        internal TextBox txtIdCategoria;
        internal Label Label2;
        internal Button btnEliminar;
        internal Button btnEditar;
        internal TextBox txtNombre;
        internal Button btnAñadir;
        internal Label Label5;
        internal TextBox txtEstatus;
        internal TextBox txtIdCrear;
        internal Label Label6;
        internal Label Label7;
    }
}