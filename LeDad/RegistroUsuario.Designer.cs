namespace LeDad
{
    partial class RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConfirmacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClave = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtApellido = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtConfirmacion);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(123, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 443);
            this.panel1.TabIndex = 2;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.BackColor = System.Drawing.Color.White;
            this.txtConfirmacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmacion.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfirmacion.HintText = "Confirmacion de clave";
            this.txtConfirmacion.isPassword = false;
            this.txtConfirmacion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtConfirmacion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmacion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtConfirmacion.LineThickness = 3;
            this.txtConfirmacion.Location = new System.Drawing.Point(465, 312);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(262, 33);
            this.txtConfirmacion.TabIndex = 30;
            this.txtConfirmacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClave.HintForeColor = System.Drawing.Color.Empty;
            this.txtClave.HintText = "Clave";
            this.txtClave.isPassword = false;
            this.txtClave.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtClave.LineIdleColor = System.Drawing.Color.Gray;
            this.txtClave.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtClave.LineThickness = 3;
            this.txtClave.Location = new System.Drawing.Point(64, 312);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(262, 33);
            this.txtClave.TabIndex = 29;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.HintText = "alguien@ejemplo.com";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCorreo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCorreo.LineThickness = 3;
            this.txtCorreo.Location = new System.Drawing.Point(217, 255);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(324, 33);
            this.txtCorreo.TabIndex = 28;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsuario.LineThickness = 3;
            this.txtUsuario.Location = new System.Drawing.Point(465, 198);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(262, 33);
            this.txtUsuario.TabIndex = 27;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.HintForeColor = System.Drawing.Color.Empty;
            this.txtApellido.HintText = "Apellidos";
            this.txtApellido.isPassword = false;
            this.txtApellido.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtApellido.LineIdleColor = System.Drawing.Color.Gray;
            this.txtApellido.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtApellido.LineThickness = 3;
            this.txtApellido.Location = new System.Drawing.Point(465, 123);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 33);
            this.txtApellido.TabIndex = 26;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCedula.HintForeColor = System.Drawing.Color.Empty;
            this.txtCedula.HintText = "000-0000000-0";
            this.txtCedula.isPassword = false;
            this.txtCedula.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCedula.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCedula.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCedula.LineThickness = 3;
            this.txtCedula.Location = new System.Drawing.Point(64, 198);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(262, 33);
            this.txtCedula.TabIndex = 25;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "Nombres";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(64, 123);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 33);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(231, 373);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(310, 52);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(213, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registro de usuarios";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(692, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1009, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCedula;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmacion;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtApellido;
    }
}