namespace TaschenrechnerGUI
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
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.buttonAddieren = new System.Windows.Forms.Button();
            this.buttonSubtrahieren = new System.Windows.Forms.Button();
            this.buttonMultiplizieren = new System.Windows.Forms.Button();
            this.buttonDividieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(83, 69);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(557, 38);
            this.textBoxZahl1.TabIndex = 0;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(83, 134);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(557, 38);
            this.textBoxZahl2.TabIndex = 1;
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.Location = new System.Drawing.Point(83, 393);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.Size = new System.Drawing.Size(557, 38);
            this.textBoxErgebnis.TabIndex = 2;
            // 
            // buttonAddieren
            // 
            this.buttonAddieren.Font = new System.Drawing.Font("Wide Latin", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddieren.Location = new System.Drawing.Point(83, 208);
            this.buttonAddieren.Name = "buttonAddieren";
            this.buttonAddieren.Size = new System.Drawing.Size(115, 105);
            this.buttonAddieren.TabIndex = 3;
            this.buttonAddieren.Text = "+";
            this.buttonAddieren.UseVisualStyleBackColor = true;
            this.buttonAddieren.Click += new System.EventHandler(this.buttonAddieren_Click);
            // 
            // buttonSubtrahieren
            // 
            this.buttonSubtrahieren.Font = new System.Drawing.Font("Wide Latin", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtrahieren.Location = new System.Drawing.Point(233, 208);
            this.buttonSubtrahieren.Name = "buttonSubtrahieren";
            this.buttonSubtrahieren.Size = new System.Drawing.Size(115, 105);
            this.buttonSubtrahieren.TabIndex = 4;
            this.buttonSubtrahieren.Text = "-";
            this.buttonSubtrahieren.UseVisualStyleBackColor = true;
            this.buttonSubtrahieren.Click += new System.EventHandler(this.buttonSubtrahieren_Click);
            // 
            // buttonMultiplizieren
            // 
            this.buttonMultiplizieren.Font = new System.Drawing.Font("Wide Latin", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplizieren.Location = new System.Drawing.Point(385, 208);
            this.buttonMultiplizieren.Name = "buttonMultiplizieren";
            this.buttonMultiplizieren.Size = new System.Drawing.Size(115, 105);
            this.buttonMultiplizieren.TabIndex = 5;
            this.buttonMultiplizieren.Text = "*";
            this.buttonMultiplizieren.UseVisualStyleBackColor = true;
            this.buttonMultiplizieren.Click += new System.EventHandler(this.buttonMultiplizieren_Click);
            // 
            // buttonDividieren
            // 
            this.buttonDividieren.Font = new System.Drawing.Font("Wide Latin", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDividieren.Location = new System.Drawing.Point(525, 208);
            this.buttonDividieren.Name = "buttonDividieren";
            this.buttonDividieren.Size = new System.Drawing.Size(115, 105);
            this.buttonDividieren.TabIndex = 6;
            this.buttonDividieren.Text = "/";
            this.buttonDividieren.UseVisualStyleBackColor = true;
            this.buttonDividieren.Click += new System.EventHandler(this.buttonDividieren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 495);
            this.Controls.Add(this.buttonDividieren);
            this.Controls.Add(this.buttonMultiplizieren);
            this.Controls.Add(this.buttonSubtrahieren);
            this.Controls.Add(this.buttonAddieren);
            this.Controls.Add(this.textBoxErgebnis);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.TextBox textBoxErgebnis;
        private System.Windows.Forms.Button buttonAddieren;
        private System.Windows.Forms.Button buttonSubtrahieren;
        private System.Windows.Forms.Button buttonMultiplizieren;
        private System.Windows.Forms.Button buttonDividieren;
    }
}

