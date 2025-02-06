namespace GestionContactos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAñadirContacto = new Button();
            btnModificarContacto = new Button();
            btnEliminarContacto = new Button();
            btnMostarContacto = new Button();
            SuspendLayout();
            // 
            // btnAñadirContacto
            // 
            btnAñadirContacto.Location = new Point(50, 45);
            btnAñadirContacto.Name = "btnAñadirContacto";
            btnAñadirContacto.Size = new Size(96, 55);
            btnAñadirContacto.TabIndex = 0;
            btnAñadirContacto.Text = "Añadir contacto";
            btnAñadirContacto.UseVisualStyleBackColor = true;
            btnAñadirContacto.Click += btnAñadirContacto_Click;
            // 
            // btnModificarContacto
            // 
            btnModificarContacto.Location = new Point(50, 129);
            btnModificarContacto.Name = "btnModificarContacto";
            btnModificarContacto.Size = new Size(96, 55);
            btnModificarContacto.TabIndex = 1;
            btnModificarContacto.Text = "Modificar contacto";
            btnModificarContacto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarContacto
            // 
            btnEliminarContacto.Location = new Point(167, 129);
            btnEliminarContacto.Name = "btnEliminarContacto";
            btnEliminarContacto.Size = new Size(96, 55);
            btnEliminarContacto.TabIndex = 2;
            btnEliminarContacto.Text = "Eliminar contacto";
            btnEliminarContacto.UseVisualStyleBackColor = true;
            btnEliminarContacto.Click += btnEliminarContacto_Click;
            // 
            // btnMostarContacto
            // 
            btnMostarContacto.Location = new Point(167, 45);
            btnMostarContacto.Name = "btnMostarContacto";
            btnMostarContacto.Size = new Size(96, 55);
            btnMostarContacto.TabIndex = 3;
            btnMostarContacto.Text = "Mostar contacto";
            btnMostarContacto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 234);
            Controls.Add(btnMostarContacto);
            Controls.Add(btnEliminarContacto);
            Controls.Add(btnModificarContacto);
            Controls.Add(btnAñadirContacto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAñadirContacto;
        private Button btnModificarContacto;
        private Button btnEliminarContacto;
        private Button btnMostarContacto;
    }
}
