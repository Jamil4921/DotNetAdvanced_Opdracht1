namespace oef5
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
            this.label1 = new System.Windows.Forms.Label();
            this.Celsius = new System.Windows.Forms.TextBox();
            this.Celsius_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.TextBox();
            this.Fahrenheit_btn = new System.Windows.Forms.Button();
            this.resultCel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // Celsius
            // 
            this.Celsius.Location = new System.Drawing.Point(136, 133);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(125, 27);
            this.Celsius.TabIndex = 1;
            this.Celsius.TextChanged += new System.EventHandler(this.Celsius_TextChanged);
            // 
            // Celsius_btn
            // 
            this.Celsius_btn.Location = new System.Drawing.Point(151, 221);
            this.Celsius_btn.Name = "Celsius_btn";
            this.Celsius_btn.Size = new System.Drawing.Size(94, 29);
            this.Celsius_btn.TabIndex = 2;
            this.Celsius_btn.Text = "C to F";
            this.Celsius_btn.UseVisualStyleBackColor = true;
            this.Celsius_btn.Click += new System.EventHandler(this.Celsius_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrebheit";
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Location = new System.Drawing.Point(469, 133);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(125, 27);
            this.Fahrenheit.TabIndex = 4;
            // 
            // Fahrenheit_btn
            // 
            this.Fahrenheit_btn.Location = new System.Drawing.Point(478, 221);
            this.Fahrenheit_btn.Name = "Fahrenheit_btn";
            this.Fahrenheit_btn.Size = new System.Drawing.Size(94, 29);
            this.Fahrenheit_btn.TabIndex = 5;
            this.Fahrenheit_btn.Text = "F to C";
            this.Fahrenheit_btn.UseVisualStyleBackColor = true;
            this.Fahrenheit_btn.Click += new System.EventHandler(this.Fahrenheit_btn_Click);
            // 
            // resultCel
            // 
            this.resultCel.AutoSize = true;
            this.resultCel.Location = new System.Drawing.Point(176, 183);
            this.resultCel.Name = "resultCel";
            this.resultCel.Size = new System.Drawing.Size(0, 20);
            this.resultCel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultCel);
            this.Controls.Add(this.Fahrenheit_btn);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Celsius_btn);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Celsius;
        private Button Celsius_btn;
        private Label label2;
        private TextBox Fahrenheit;
        private Button Fahrenheit_btn;
        private Label resultCel;
    }
}