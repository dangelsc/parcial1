namespace pregunta2
{
    partial class Form1
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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellidos = new System.Windows.Forms.TextBox();
            this.tbci = new System.Windows.Forms.TextBox();
            this.tbdireccion = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(190, 24);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(176, 20);
            this.tbnombre.TabIndex = 0;
            // 
            // tbapellidos
            // 
            this.tbapellidos.Location = new System.Drawing.Point(190, 50);
            this.tbapellidos.Name = "tbapellidos";
            this.tbapellidos.Size = new System.Drawing.Size(176, 20);
            this.tbapellidos.TabIndex = 1;
            // 
            // tbci
            // 
            this.tbci.Location = new System.Drawing.Point(190, 76);
            this.tbci.Name = "tbci";
            this.tbci.Size = new System.Drawing.Size(176, 20);
            this.tbci.TabIndex = 2;
            // 
            // tbdireccion
            // 
            this.tbdireccion.Location = new System.Drawing.Point(190, 102);
            this.tbdireccion.Name = "tbdireccion";
            this.tbdireccion.Size = new System.Drawing.Size(176, 20);
            this.tbdireccion.TabIndex = 3;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(190, 128);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(176, 20);
            this.tbtelefono.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbdireccion);
            this.Controls.Add(this.tbci);
            this.Controls.Add(this.tbapellidos);
            this.Controls.Add(this.tbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellidos;
        private System.Windows.Forms.TextBox tbci;
        private System.Windows.Forms.TextBox tbdireccion;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.Button button1;
    }
}

