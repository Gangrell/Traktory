namespace Traktory
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
            this.ModelTB = new System.Windows.Forms.TextBox();
            this.MocTB = new System.Windows.Forms.TextBox();
            this.MasaTB = new System.Windows.Forms.TextBox();
            this.MarkaCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowserLogin = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModelTB
            // 
            this.ModelTB.Location = new System.Drawing.Point(60, 61);
            this.ModelTB.Name = "ModelTB";
            this.ModelTB.Size = new System.Drawing.Size(100, 20);
            this.ModelTB.TabIndex = 2;
            // 
            // MocTB
            // 
            this.MocTB.Location = new System.Drawing.Point(60, 87);
            this.MocTB.Name = "MocTB";
            this.MocTB.Size = new System.Drawing.Size(100, 20);
            this.MocTB.TabIndex = 3;
            // 
            // MasaTB
            // 
            this.MasaTB.Location = new System.Drawing.Point(60, 113);
            this.MasaTB.Name = "MasaTB";
            this.MasaTB.Size = new System.Drawing.Size(100, 20);
            this.MasaTB.TabIndex = 4;
            // 
            // MarkaCB
            // 
            this.MarkaCB.FormattingEnabled = true;
            this.MarkaCB.Location = new System.Drawing.Point(60, 34);
            this.MarkaCB.Name = "MarkaCB";
            this.MarkaCB.Size = new System.Drawing.Size(100, 21);
            this.MarkaCB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Moc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Masa:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "StworzPDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowserLogin
            // 
            this.webBrowserLogin.Location = new System.Drawing.Point(632, 34);
            this.webBrowserLogin.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserLogin.Name = "webBrowserLogin";
            this.webBrowserLogin.Size = new System.Drawing.Size(631, 576);
            this.webBrowserLogin.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "Autor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 655);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.webBrowserLogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarkaCB);
            this.Controls.Add(this.MasaTB);
            this.Controls.Add(this.MocTB);
            this.Controls.Add(this.ModelTB);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ModelTB;
        private System.Windows.Forms.TextBox MocTB;
        private System.Windows.Forms.TextBox MasaTB;
        private System.Windows.Forms.ComboBox MarkaCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowserLogin;
        private System.Windows.Forms.Button button3;
    }
}

