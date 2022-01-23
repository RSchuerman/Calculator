
namespace Calculator
{
    partial class Calculator
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
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.sqrBtn = new System.Windows.Forms.Button();
            this.pwrBtn = new System.Windows.Forms.Button();
            this.recBtn = new System.Windows.Forms.Button();
            this.ceBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.dBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.posNegBtn = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.dcmBtn = new System.Windows.Forms.Button();
            this.eqlBtn = new System.Windows.Forms.Button();
            this.lastValueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.Location = new System.Drawing.Point(6, 48);
            this.sqrtBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(34, 25);
            this.sqrtBtn.TabIndex = 0;
            this.sqrtBtn.Text = "Sqrt";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(6, 24);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(145, 20);
            this.resultBox.TabIndex = 1;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sqrBtn
            // 
            this.sqrBtn.Location = new System.Drawing.Point(43, 49);
            this.sqrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sqrBtn.Name = "sqrBtn";
            this.sqrBtn.Size = new System.Drawing.Size(33, 25);
            this.sqrBtn.TabIndex = 2;
            this.sqrBtn.Text = "x^2";
            this.sqrBtn.UseVisualStyleBackColor = true;
            this.sqrBtn.Click += new System.EventHandler(this.sqrBtn_Click);
            // 
            // pwrBtn
            // 
            this.pwrBtn.Location = new System.Drawing.Point(81, 49);
            this.pwrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pwrBtn.Name = "pwrBtn";
            this.pwrBtn.Size = new System.Drawing.Size(33, 25);
            this.pwrBtn.TabIndex = 3;
            this.pwrBtn.Text = "x^y";
            this.pwrBtn.UseVisualStyleBackColor = true;
            this.pwrBtn.Click += new System.EventHandler(this.pwrBtn_Click);
            // 
            // recBtn
            // 
            this.recBtn.Location = new System.Drawing.Point(118, 49);
            this.recBtn.Margin = new System.Windows.Forms.Padding(2);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(33, 25);
            this.recBtn.TabIndex = 4;
            this.recBtn.Text = "1/x";
            this.recBtn.UseVisualStyleBackColor = true;
            this.recBtn.Click += new System.EventHandler(this.recBtn_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.Location = new System.Drawing.Point(6, 77);
            this.ceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(33, 25);
            this.ceBtn.TabIndex = 5;
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = true;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // cBtn
            // 
            this.cBtn.Location = new System.Drawing.Point(43, 77);
            this.cBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(33, 25);
            this.cBtn.TabIndex = 6;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // dBtn
            // 
            this.dBtn.Location = new System.Drawing.Point(81, 77);
            this.dBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dBtn.Name = "dBtn";
            this.dBtn.Size = new System.Drawing.Size(33, 25);
            this.dBtn.TabIndex = 7;
            this.dBtn.Text = "Del.";
            this.dBtn.UseVisualStyleBackColor = true;
            this.dBtn.Click += new System.EventHandler(this.dBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(118, 77);
            this.divBtn.Margin = new System.Windows.Forms.Padding(2);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(33, 25);
            this.divBtn.TabIndex = 8;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 107);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(33, 25);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(43, 107);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(33, 25);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(81, 107);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(33, 25);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Location = new System.Drawing.Point(118, 107);
            this.mulBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(33, 25);
            this.mulBtn.TabIndex = 12;
            this.mulBtn.Text = "X";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 137);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(33, 25);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(43, 137);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(33, 25);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(81, 137);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(33, 25);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(118, 137);
            this.subBtn.Margin = new System.Windows.Forms.Padding(2);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(33, 25);
            this.subBtn.TabIndex = 16;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 167);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(33, 25);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(43, 167);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(33, 25);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(81, 167);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(33, 25);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(118, 167);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(33, 25);
            this.plusBtn.TabIndex = 20;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // posNegBtn
            // 
            this.posNegBtn.Location = new System.Drawing.Point(6, 197);
            this.posNegBtn.Margin = new System.Windows.Forms.Padding(2);
            this.posNegBtn.Name = "posNegBtn";
            this.posNegBtn.Size = new System.Drawing.Size(33, 25);
            this.posNegBtn.TabIndex = 21;
            this.posNegBtn.Text = "+/-";
            this.posNegBtn.UseVisualStyleBackColor = true;
            this.posNegBtn.Click += new System.EventHandler(this.posNegBtn_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(43, 197);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(33, 25);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // dcmBtn
            // 
            this.dcmBtn.Location = new System.Drawing.Point(81, 197);
            this.dcmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dcmBtn.Name = "dcmBtn";
            this.dcmBtn.Size = new System.Drawing.Size(33, 25);
            this.dcmBtn.TabIndex = 23;
            this.dcmBtn.Text = ".";
            this.dcmBtn.UseVisualStyleBackColor = true;
            this.dcmBtn.Click += new System.EventHandler(this.dcmBtn_Click);
            // 
            // eqlBtn
            // 
            this.eqlBtn.Location = new System.Drawing.Point(118, 197);
            this.eqlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.eqlBtn.Name = "eqlBtn";
            this.eqlBtn.Size = new System.Drawing.Size(33, 25);
            this.eqlBtn.TabIndex = 24;
            this.eqlBtn.Text = "=";
            this.eqlBtn.UseVisualStyleBackColor = true;
            this.eqlBtn.Click += new System.EventHandler(this.eqlBtn_Click);
            // 
            // lastValueLbl
            // 
            this.lastValueLbl.AutoSize = true;
            this.lastValueLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastValueLbl.Location = new System.Drawing.Point(3, 9);
            this.lastValueLbl.Name = "lastValueLbl";
            this.lastValueLbl.Size = new System.Drawing.Size(0, 13);
            this.lastValueLbl.TabIndex = 26;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 231);
            this.Controls.Add(this.lastValueLbl);
            this.Controls.Add(this.eqlBtn);
            this.Controls.Add(this.dcmBtn);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.posNegBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.dBtn);
            this.Controls.Add(this.cBtn);
            this.Controls.Add(this.ceBtn);
            this.Controls.Add(this.recBtn);
            this.Controls.Add(this.pwrBtn);
            this.Controls.Add(this.sqrBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.sqrtBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
//        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button sqrBtn;
        private System.Windows.Forms.Button pwrBtn;
        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.Button ceBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button dBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button posNegBtn;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button dcmBtn;
        private System.Windows.Forms.Button eqlBtn;
        private System.Windows.Forms.Label lastValueLbl;
    }
}

