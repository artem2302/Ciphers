namespace lab1
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
            this.btnVigenere = new System.Windows.Forms.Button();
            this.btnReshuffle = new System.Windows.Forms.Button();
            this.btnReshuffleXOR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVigenere
            // 
            this.btnVigenere.Location = new System.Drawing.Point(12, 12);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(125, 23);
            this.btnVigenere.TabIndex = 0;
            this.btnVigenere.Text = "Vigenere Cipher";
            this.btnVigenere.UseVisualStyleBackColor = true;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnReshuffle
            // 
            this.btnReshuffle.Location = new System.Drawing.Point(12, 41);
            this.btnReshuffle.Name = "btnReshuffle";
            this.btnReshuffle.Size = new System.Drawing.Size(125, 23);
            this.btnReshuffle.TabIndex = 1;
            this.btnReshuffle.Text = "Complicated reshuffle";
            this.btnReshuffle.UseVisualStyleBackColor = true;
            // 
            // btnReshuffleXOR
            // 
            this.btnReshuffleXOR.Location = new System.Drawing.Point(12, 70);
            this.btnReshuffleXOR.Name = "btnReshuffleXOR";
            this.btnReshuffleXOR.Size = new System.Drawing.Size(125, 23);
            this.btnReshuffleXOR.TabIndex = 2;
            this.btnReshuffleXOR.Text = "Reshuffle+XOR";
            this.btnReshuffleXOR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 114);
            this.Controls.Add(this.btnReshuffleXOR);
            this.Controls.Add(this.btnReshuffle);
            this.Controls.Add(this.btnVigenere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.Button btnReshuffle;
        private System.Windows.Forms.Button btnReshuffleXOR;
    }
}

