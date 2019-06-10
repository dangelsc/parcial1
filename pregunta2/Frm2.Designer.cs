namespace pregunta2
{
    partial class Frm2
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
            this.tbhombros = new System.Windows.Forms.TextBox();
            this.tbcintura = new System.Windows.Forms.TextBox();
            this.tbbrazo = new System.Windows.Forms.TextBox();
            this.tbpierna = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbhombros
            // 
            this.tbhombros.Location = new System.Drawing.Point(155, 35);
            this.tbhombros.Name = "tbhombros";
            this.tbhombros.Size = new System.Drawing.Size(183, 20);
            this.tbhombros.TabIndex = 1;
            // 
            // tbcintura
            // 
            this.tbcintura.Location = new System.Drawing.Point(155, 61);
            this.tbcintura.Name = "tbcintura";
            this.tbcintura.Size = new System.Drawing.Size(183, 20);
            this.tbcintura.TabIndex = 2;
            // 
            // tbbrazo
            // 
            this.tbbrazo.Location = new System.Drawing.Point(155, 87);
            this.tbbrazo.Name = "tbbrazo";
            this.tbbrazo.Size = new System.Drawing.Size(183, 20);
            this.tbbrazo.TabIndex = 3;
            // 
            // tbpierna
            // 
            this.tbpierna.Location = new System.Drawing.Point(155, 113);
            this.tbpierna.Name = "tbpierna";
            this.tbpierna.Size = new System.Drawing.Size(183, 20);
            this.tbpierna.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbpierna);
            this.Controls.Add(this.tbbrazo);
            this.Controls.Add(this.tbcintura);
            this.Controls.Add(this.tbhombros);
            this.Name = "Frm2";
            this.Text = "Frm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbhombros;
        private System.Windows.Forms.TextBox tbcintura;
        private System.Windows.Forms.TextBox tbbrazo;
        private System.Windows.Forms.TextBox tbpierna;
        private System.Windows.Forms.Button button1;
    }
}