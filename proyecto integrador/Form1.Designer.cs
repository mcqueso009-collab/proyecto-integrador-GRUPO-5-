namespace proyecto_integrador
{
    partial class InicioDeSesion
    {
        private System.ComponentModel.IContainer components = null;

       
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            IniciarSesion = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            usuario = new Label();
            contraseña = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IniciarSesion
            // 
            IniciarSesion.Location = new Point(322, 379);
            IniciarSesion.Name = "IniciarSesion";
            IniciarSesion.Size = new Size(167, 29);
            IniciarSesion.TabIndex = 0;
            IniciarSesion.Text = "iniciar sesion ";
            IniciarSesion.UseVisualStyleBackColor = true;
            IniciarSesion.Click += IniciarSesion_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 324);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Location = new Point(375, 248);
            usuario.Name = "usuario";
            usuario.Size = new Size(57, 20);
            usuario.TabIndex = 3;
            usuario.Text = "usuario";
            usuario.Click += label1_Click_1;
            // 
            // contraseña
            // 
            contraseña.AutoSize = true;
            contraseña.Location = new Point(364, 301);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(81, 20);
            contraseña.TabIndex = 4;
            contraseña.Text = "contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 9);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(contraseña);
            Controls.Add(usuario);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(IniciarSesion);
            Name = "InicioDeSesion";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IniciarSesion;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label usuario;
        private Label contraseña;
        private PictureBox pictureBox1;
    }
}
