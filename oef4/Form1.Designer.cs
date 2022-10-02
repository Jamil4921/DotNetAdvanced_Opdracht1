namespace oef4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Extprice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Price2 = new System.Windows.Forms.TextBox();
            this.Extprice2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.Quantity2 = new System.Windows.Forms.NumericUpDown();
            this.Quantity3 = new System.Windows.Forms.NumericUpDown();
            this.Price3 = new System.Windows.Forms.TextBox();
            this.Extprice3 = new System.Windows.Forms.Label();
            this.Extprice4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Quantity4 = new System.Windows.Forms.NumericUpDown();
            this.Price4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saleTax = new System.Windows.Forms.Label();
            this.taxRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grandTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ship = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Each";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(542, 41);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 20);
            this.label.TabIndex = 3;
            this.label.Text = "Ext. Price";
            this.label.Click += new System.EventHandler(this.Extprice_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Gloves";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(369, 80);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(125, 27);
            this.Price.TabIndex = 5;
            this.Price.Text = "10";
            // 
            // Extprice
            // 
            this.Extprice.AutoSize = true;
            this.Extprice.Location = new System.Drawing.Point(542, 90);
            this.Extprice.Name = "Extprice";
            this.Extprice.Size = new System.Drawing.Size(49, 20);
            this.Extprice.TabIndex = 7;
            this.Extprice.Text = "Result";
            this.Extprice.Click += new System.EventHandler(this.Extprice_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Boots";
            // 
            // Price2
            // 
            this.Price2.Location = new System.Drawing.Point(369, 124);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(125, 27);
            this.Price2.TabIndex = 12;
            this.Price2.Text = "30";
            // 
            // Extprice2
            // 
            this.Extprice2.AutoSize = true;
            this.Extprice2.Location = new System.Drawing.Point(542, 131);
            this.Extprice2.Name = "Extprice2";
            this.Extprice2.Size = new System.Drawing.Size(53, 20);
            this.Extprice2.TabIndex = 13;
            this.Extprice2.Text = "result2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 27);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Hat";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(181, 83);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(150, 27);
            this.Quantity.TabIndex = 15;
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // Quantity2
            // 
            this.Quantity2.Location = new System.Drawing.Point(181, 124);
            this.Quantity2.Name = "Quantity2";
            this.Quantity2.Size = new System.Drawing.Size(150, 27);
            this.Quantity2.TabIndex = 16;
            // 
            // Quantity3
            // 
            this.Quantity3.Location = new System.Drawing.Point(181, 174);
            this.Quantity3.Name = "Quantity3";
            this.Quantity3.Size = new System.Drawing.Size(150, 27);
            this.Quantity3.TabIndex = 17;
            // 
            // Price3
            // 
            this.Price3.Location = new System.Drawing.Point(369, 173);
            this.Price3.Name = "Price3";
            this.Price3.Size = new System.Drawing.Size(125, 27);
            this.Price3.TabIndex = 18;
            this.Price3.Text = "6";
            // 
            // Extprice3
            // 
            this.Extprice3.AutoSize = true;
            this.Extprice3.Location = new System.Drawing.Point(542, 181);
            this.Extprice3.Name = "Extprice3";
            this.Extprice3.Size = new System.Drawing.Size(53, 20);
            this.Extprice3.TabIndex = 19;
            this.Extprice3.Text = "result3";
            // 
            // Extprice4
            // 
            this.Extprice4.AutoSize = true;
            this.Extprice4.Location = new System.Drawing.Point(542, 227);
            this.Extprice4.Name = "Extprice4";
            this.Extprice4.Size = new System.Drawing.Size(53, 20);
            this.Extprice4.TabIndex = 20;
            this.Extprice4.Text = "result4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(41, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(93, 27);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "Skis";
            // 
            // Quantity4
            // 
            this.Quantity4.Location = new System.Drawing.Point(181, 221);
            this.Quantity4.Name = "Quantity4";
            this.Quantity4.Size = new System.Drawing.Size(150, 27);
            this.Quantity4.TabIndex = 22;
            // 
            // Price4
            // 
            this.Price4.Location = new System.Drawing.Point(369, 220);
            this.Price4.Name = "Price4";
            this.Price4.Size = new System.Drawing.Size(125, 27);
            this.Price4.TabIndex = 23;
            this.Price4.Text = "700";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Subtotal";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(542, 277);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(63, 20);
            this.sum.TabIndex = 25;
            this.sum.Text = "subtotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tax Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Sales tax";
            // 
            // saleTax
            // 
            this.saleTax.AutoSize = true;
            this.saleTax.Location = new System.Drawing.Point(541, 347);
            this.saleTax.Name = "saleTax";
            this.saleTax.Size = new System.Drawing.Size(94, 20);
            this.saleTax.TabIndex = 29;
            this.saleTax.Text = "resultSaleTax";
            // 
            // taxRate
            // 
            this.taxRate.Location = new System.Drawing.Point(542, 307);
            this.taxRate.Name = "taxRate";
            this.taxRate.Size = new System.Drawing.Size(125, 27);
            this.taxRate.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Grandtotal";
            // 
            // grandTotal
            // 
            this.grandTotal.AutoSize = true;
            this.grandTotal.Location = new System.Drawing.Point(542, 408);
            this.grandTotal.Name = "grandTotal";
            this.grandTotal.Size = new System.Drawing.Size(80, 20);
            this.grandTotal.TabIndex = 32;
            this.grandTotal.Text = "Grandtotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Shipping";
            // 
            // Ship
            // 
            this.Ship.Location = new System.Drawing.Point(542, 378);
            this.Ship.Name = "Ship";
            this.Ship.Size = new System.Drawing.Size(125, 27);
            this.Ship.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ship);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.taxRate);
            this.Controls.Add(this.saleTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price4);
            this.Controls.Add(this.Quantity4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Extprice4);
            this.Controls.Add(this.Extprice3);
            this.Controls.Add(this.Price3);
            this.Controls.Add(this.Quantity3);
            this.Controls.Add(this.Quantity2);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Extprice2);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Extprice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label;
        private TextBox textBox1;
        private TextBox Price;
        private Label Extprice;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
        private TextBox Price2;
        private Label Extprice2;
        private TextBox textBox3;
        private NumericUpDown Quantity;
        private NumericUpDown Quantity2;
        private NumericUpDown Quantity3;
        private TextBox Price3;
        private Label Extprice3;
        private Label Extprice4;
        private TextBox textBox4;
        private NumericUpDown Quantity4;
        private TextBox Price4;
        private Label label4;
        private Label sum;
        private Label label5;
        private Label taxrateResult;
        private Label label6;
        private Label saleTax;
        private TextBox taxRate;
        private Label label7;
        private Label grandTotal;
        private Label label8;
        private TextBox Ship;
    }
}