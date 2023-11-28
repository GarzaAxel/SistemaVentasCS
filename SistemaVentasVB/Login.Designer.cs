using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVentasVB
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
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
            Label1 = new Label();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            btnAcceder.Click += new EventHandler(btnAcceder_Click);
            Label2 = new Label();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(72, 51);
            Label1.Name = "Label1";
            Label1.Size = new Size(76, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(154, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 26);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(223, 151);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(86, 34);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(41, 92);
            Label2.Name = "Label2";
            Label2.Size = new Size(107, 20);
            Label2.TabIndex = 3;
            Label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(154, 51);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 26);
            txtUsuario.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 214);
            Controls.Add(txtUsuario);
            Controls.Add(Label2);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(Label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal TextBox txtPassword;
        internal Button btnAcceder;
        internal Label Label2;
        internal TextBox txtUsuario;
    }
}