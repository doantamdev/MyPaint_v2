namespace MyPaint_v2
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.cdPenColor2 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.ckbColor = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNoFill = new System.Windows.Forms.RadioButton();
            this.rbColorFill = new System.Windows.Forms.RadioButton();
            this.rbPatternFill = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColor3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(782, 428);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(838, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nét vẽ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Màu";
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(891, 60);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(120, 22);
            this.inpPenWidth.TabIndex = 3;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(891, 98);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(120, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Chọn Màu Viền";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Màu";
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(891, 175);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(120, 23);
            this.btnColor2.TabIndex = 19;
            this.btnColor2.Text = "Chọn màu ruột";
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // ckbColor
            // 
            this.ckbColor.AutoSize = true;
            this.ckbColor.Location = new System.Drawing.Point(900, 142);
            this.ckbColor.Name = "ckbColor";
            this.ckbColor.Size = new System.Drawing.Size(18, 17);
            this.ckbColor.TabIndex = 7;
            this.ckbColor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tô màu";
            // 
            // lblPen
            // 
            this.lblPen.AutoSize = true;
            this.lblPen.Location = new System.Drawing.Point(827, 26);
            this.lblPen.Name = "lblPen";
            this.lblPen.Size = new System.Drawing.Size(31, 16);
            this.lblPen.TabIndex = 9;
            this.lblPen.Text = "Pen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(837, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shape";
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(873, 398);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(90, 20);
            this.rbRectangle.TabIndex = 11;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(873, 424);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(62, 20);
            this.rbCircle.TabIndex = 12;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(830, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Brush";
            // 
            // rbNoFill
            // 
            this.rbNoFill.AutoSize = true;
            this.rbNoFill.Location = new System.Drawing.Point(841, 253);
            this.rbNoFill.Name = "rbNoFill";
            this.rbNoFill.Size = new System.Drawing.Size(66, 20);
            this.rbNoFill.TabIndex = 14;
            this.rbNoFill.TabStop = true;
            this.rbNoFill.Text = "No Fill";
            this.rbNoFill.UseVisualStyleBackColor = true;
            // 
            // rbColorFill
            // 
            this.rbColorFill.AutoSize = true;
            this.rbColorFill.Location = new System.Drawing.Point(840, 280);
            this.rbColorFill.Name = "rbColorFill";
            this.rbColorFill.Size = new System.Drawing.Size(80, 20);
            this.rbColorFill.TabIndex = 15;
            this.rbColorFill.TabStop = true;
            this.rbColorFill.Text = "Color Fill";
            this.rbColorFill.UseVisualStyleBackColor = true;
            // 
            // rbPatternFill
            // 
            this.rbPatternFill.AutoSize = true;
            this.rbPatternFill.Location = new System.Drawing.Point(841, 306);
            this.rbPatternFill.Name = "rbPatternFill";
            this.rbPatternFill.Size = new System.Drawing.Size(90, 20);
            this.rbPatternFill.TabIndex = 16;
            this.rbPatternFill.TabStop = true;
            this.rbPatternFill.Text = "Pattern Fill";
            this.rbPatternFill.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(837, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Màu";
            // 
            // btnColor3
            // 
            this.btnColor3.Location = new System.Drawing.Point(891, 350);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(120, 23);
            this.btnColor3.TabIndex = 18;
            this.btnColor3.Text = "Chọn màu";
            this.btnColor3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 479);
            this.Controls.Add(this.btnColor3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbPatternFill);
            this.Controls.Add(this.rbColorFill);
            this.Controls.Add(this.rbNoFill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbCircle);
            this.Controls.Add(this.rbRectangle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbColor);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.inpPenWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cdPenColor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.CheckBox ckbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNoFill;
        private System.Windows.Forms.RadioButton rbColorFill;
        private System.Windows.Forms.RadioButton rbPatternFill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnColor3;
    }
}

