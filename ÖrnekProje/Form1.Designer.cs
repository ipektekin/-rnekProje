namespace ÖrnekProje
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
            this.button1 = new System.Windows.Forms.Button();
            this.birbutonu = new System.Windows.Forms.Button();
            this.HesaplaButon = new System.Windows.Forms.Button();
            this.ToplaButon = new System.Windows.Forms.Button();
            this.Buton2 = new System.Windows.Forms.Button();
            this.sonuctextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birbutonu
            // 
            this.birbutonu.Location = new System.Drawing.Point(191, 71);
            this.birbutonu.Name = "birbutonu";
            this.birbutonu.Size = new System.Drawing.Size(75, 76);
            this.birbutonu.TabIndex = 1;
            this.birbutonu.Text = "1";
            this.birbutonu.UseVisualStyleBackColor = true;
            this.birbutonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // HesaplaButon
            // 
            this.HesaplaButon.Location = new System.Drawing.Point(25, 380);
            this.HesaplaButon.Name = "HesaplaButon";
            this.HesaplaButon.Size = new System.Drawing.Size(197, 46);
            this.HesaplaButon.TabIndex = 2;
            this.HesaplaButon.Text = "Hesapla";
            this.HesaplaButon.UseVisualStyleBackColor = true;
            this.HesaplaButon.Click += new System.EventHandler(this.HesaplaButon_Click);
            // 
            // ToplaButon
            // 
            this.ToplaButon.Location = new System.Drawing.Point(501, 71);
            this.ToplaButon.Name = "ToplaButon";
            this.ToplaButon.Size = new System.Drawing.Size(65, 76);
            this.ToplaButon.TabIndex = 3;
            this.ToplaButon.Text = "+";
            this.ToplaButon.UseVisualStyleBackColor = true;
            this.ToplaButon.Click += new System.EventHandler(this.ToplaButon_Click);
            // 
            // Buton2
            // 
            this.Buton2.Location = new System.Drawing.Point(290, 71);
            this.Buton2.Name = "Buton2";
            this.Buton2.Size = new System.Drawing.Size(75, 76);
            this.Buton2.TabIndex = 4;
            this.Buton2.Text = "2";
            this.Buton2.UseVisualStyleBackColor = true;
            this.Buton2.Click += new System.EventHandler(this.Buton2_Click);
            // 
            // sonuctextbox
            // 
            this.sonuctextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuctextbox.Location = new System.Drawing.Point(276, 386);
            this.sonuctextbox.Name = "sonuctextbox";
            this.sonuctextbox.Size = new System.Drawing.Size(100, 29);
            this.sonuctextbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sonuctextbox);
            this.Controls.Add(this.Buton2);
            this.Controls.Add(this.ToplaButon);
            this.Controls.Add(this.HesaplaButon);
            this.Controls.Add(this.birbutonu);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button birbutonu;
        private System.Windows.Forms.Button HesaplaButon;
        private System.Windows.Forms.Button ToplaButon;
        private System.Windows.Forms.Button Buton2;
        private System.Windows.Forms.TextBox sonuctextbox;
    }
}

