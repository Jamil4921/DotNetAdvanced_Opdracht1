namespace oef2
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
            this.getal1 = new System.Windows.Forms.Label();
            this.resultaat1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultaat2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultaat3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getal1
            // 
            this.getal1.AutoSize = true;
            this.getal1.Location = new System.Drawing.Point(190, 106);
            this.getal1.Name = "getal1";
            this.getal1.Size = new System.Drawing.Size(121, 20);
            this.getal1.TabIndex = 0;
            this.getal1.Text = "12345 * 54321 = ";
            this.getal1.Click += new System.EventHandler(this.getal1_Click);
            // 
            // resultaat1
            // 
            this.resultaat1.AutoSize = true;
            this.resultaat1.Location = new System.Drawing.Point(317, 106);
            this.resultaat1.Name = "resultaat1";
            this.resultaat1.Size = new System.Drawing.Size(74, 20);
            this.resultaat1.TabIndex = 2;
            this.resultaat1.Text = "resultaat1";
            this.resultaat1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "22222*33333=";
            // 
            // resultaat2
            // 
            this.resultaat2.AutoSize = true;
            this.resultaat2.Location = new System.Drawing.Point(317, 149);
            this.resultaat2.Name = "resultaat2";
            this.resultaat2.Size = new System.Drawing.Size(74, 20);
            this.resultaat2.TabIndex = 4;
            this.resultaat2.Text = "resultaat2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "12345 * 54321 > 22222*33333 =";
            // 
            // resultaat3
            // 
            this.resultaat3.AutoSize = true;
            this.resultaat3.Location = new System.Drawing.Point(417, 204);
            this.resultaat3.Name = "resultaat3";
            this.resultaat3.Size = new System.Drawing.Size(74, 20);
            this.resultaat3.TabIndex = 6;
            this.resultaat3.Text = "resultaat3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultaat3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultaat2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultaat1);
            this.Controls.Add(this.getal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label getal1;
        public Label resultaat1;
        private Label label1;
        private Label resultaat2;
        public Label label2;
        private Label resultaat3;
    }
}