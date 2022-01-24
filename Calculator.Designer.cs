
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
            this.histBtn = new System.Windows.Forms.Button();
            this.histValBtn1 = new System.Windows.Forms.Button();
            this.histValBtn2 = new System.Windows.Forms.Button();
            this.histValBtn3 = new System.Windows.Forms.Button();
            this.histValBtn4 = new System.Windows.Forms.Button();
            this.histValBtn5 = new System.Windows.Forms.Button();
            this.histValBtn6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtBtn.Location = new System.Drawing.Point(11, 68);
            this.sqrtBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(66, 50);
            this.sqrtBtn.TabIndex = 0;
            this.sqrtBtn.Text = "Sqrt";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(12, 35);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(276, 29);
            this.resultBox.TabIndex = 1;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sqrBtn
            // 
            this.sqrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrBtn.Location = new System.Drawing.Point(81, 68);
            this.sqrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sqrBtn.Name = "sqrBtn";
            this.sqrBtn.Size = new System.Drawing.Size(66, 50);
            this.sqrBtn.TabIndex = 2;
            this.sqrBtn.Text = "x^2";
            this.sqrBtn.UseVisualStyleBackColor = true;
            this.sqrBtn.Click += new System.EventHandler(this.sqrBtn_Click);
            // 
            // pwrBtn
            // 
            this.pwrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwrBtn.Location = new System.Drawing.Point(151, 68);
            this.pwrBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pwrBtn.Name = "pwrBtn";
            this.pwrBtn.Size = new System.Drawing.Size(66, 50);
            this.pwrBtn.TabIndex = 3;
            this.pwrBtn.Text = "x^y";
            this.pwrBtn.UseVisualStyleBackColor = true;
            this.pwrBtn.Click += new System.EventHandler(this.pwrBtn_Click);
            // 
            // recBtn
            // 
            this.recBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recBtn.Location = new System.Drawing.Point(221, 68);
            this.recBtn.Margin = new System.Windows.Forms.Padding(2);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(66, 50);
            this.recBtn.TabIndex = 4;
            this.recBtn.Text = "1/x";
            this.recBtn.UseVisualStyleBackColor = true;
            this.recBtn.Click += new System.EventHandler(this.recBtn_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceBtn.Location = new System.Drawing.Point(11, 122);
            this.ceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(66, 50);
            this.ceBtn.TabIndex = 5;
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = true;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // cBtn
            // 
            this.cBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtn.Location = new System.Drawing.Point(81, 122);
            this.cBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(66, 50);
            this.cBtn.TabIndex = 6;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // dBtn
            // 
            this.dBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dBtn.Location = new System.Drawing.Point(151, 122);
            this.dBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dBtn.Name = "dBtn";
            this.dBtn.Size = new System.Drawing.Size(66, 50);
            this.dBtn.TabIndex = 7;
            this.dBtn.Text = "Del.";
            this.dBtn.UseVisualStyleBackColor = true;
            this.dBtn.Click += new System.EventHandler(this.dBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(221, 122);
            this.divBtn.Margin = new System.Windows.Forms.Padding(2);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(66, 50);
            this.divBtn.TabIndex = 8;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(11, 176);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(66, 50);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(81, 176);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(66, 50);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(151, 176);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(66, 50);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.Location = new System.Drawing.Point(221, 176);
            this.mulBtn.Margin = new System.Windows.Forms.Padding(2);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(66, 50);
            this.mulBtn.TabIndex = 12;
            this.mulBtn.Text = "X";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(11, 230);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(66, 50);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(81, 230);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(66, 50);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(151, 230);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(66, 50);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(221, 230);
            this.subBtn.Margin = new System.Windows.Forms.Padding(2);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(66, 50);
            this.subBtn.TabIndex = 16;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(11, 284);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(66, 50);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(81, 284);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(66, 50);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(151, 284);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(66, 50);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(221, 284);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(66, 50);
            this.plusBtn.TabIndex = 20;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // posNegBtn
            // 
            this.posNegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posNegBtn.Location = new System.Drawing.Point(11, 338);
            this.posNegBtn.Margin = new System.Windows.Forms.Padding(2);
            this.posNegBtn.Name = "posNegBtn";
            this.posNegBtn.Size = new System.Drawing.Size(66, 50);
            this.posNegBtn.TabIndex = 21;
            this.posNegBtn.Text = "+/-";
            this.posNegBtn.UseVisualStyleBackColor = true;
            this.posNegBtn.Click += new System.EventHandler(this.posNegBtn_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(81, 338);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(66, 50);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // dcmBtn
            // 
            this.dcmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcmBtn.Location = new System.Drawing.Point(151, 338);
            this.dcmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dcmBtn.Name = "dcmBtn";
            this.dcmBtn.Size = new System.Drawing.Size(66, 50);
            this.dcmBtn.TabIndex = 23;
            this.dcmBtn.Text = ".";
            this.dcmBtn.UseVisualStyleBackColor = true;
            this.dcmBtn.Click += new System.EventHandler(this.dcmBtn_Click);
            // 
            // eqlBtn
            // 
            this.eqlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqlBtn.Location = new System.Drawing.Point(221, 338);
            this.eqlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.eqlBtn.Name = "eqlBtn";
            this.eqlBtn.Size = new System.Drawing.Size(66, 50);
            this.eqlBtn.TabIndex = 24;
            this.eqlBtn.Text = "=";
            this.eqlBtn.UseVisualStyleBackColor = true;
            this.eqlBtn.Click += new System.EventHandler(this.eqlBtn_Click);
            // 
            // lastValueLbl
            // 
            this.lastValueLbl.AutoSize = true;
            this.lastValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastValueLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lastValueLbl.Location = new System.Drawing.Point(12, 9);
            this.lastValueLbl.Name = "lastValueLbl";
            this.lastValueLbl.Size = new System.Drawing.Size(0, 24);
            this.lastValueLbl.TabIndex = 26;
            // 
            // histBtn
            // 
            this.histBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histBtn.Location = new System.Drawing.Point(213, 7);
            this.histBtn.Name = "histBtn";
            this.histBtn.Size = new System.Drawing.Size(75, 23);
            this.histBtn.TabIndex = 27;
            this.histBtn.Text = "History";
            this.histBtn.UseVisualStyleBackColor = true;
            this.histBtn.Click += new System.EventHandler(this.histBtn_Click);
            // 
            // histValBtn1
            // 
            this.histValBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histValBtn1.Location = new System.Drawing.Point(307, 66);
            this.histValBtn1.Name = "histValBtn1";
            this.histValBtn1.Size = new System.Drawing.Size(152, 50);
            this.histValBtn1.TabIndex = 28;
            this.histValBtn1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.histValBtn1.UseVisualStyleBackColor = false;
            this.histValBtn1.Click += new System.EventHandler(this.histValBtn1_Click);
            // 
            // histValBtn2
            // 
            this.histValBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histValBtn2.Location = new System.Drawing.Point(307, 122);
            this.histValBtn2.Name = "histValBtn2";
            this.histValBtn2.Size = new System.Drawing.Size(152, 50);
            this.histValBtn2.TabIndex = 29;
            this.histValBtn2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.histValBtn2.UseVisualStyleBackColor = false;
            this.histValBtn2.Click += new System.EventHandler(this.histValBtn2_Click);
            // 
            // histValBtn3
            // 
            this.histValBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histValBtn3.Location = new System.Drawing.Point(307, 178);
            this.histValBtn3.Name = "histValBtn3";
            this.histValBtn3.Size = new System.Drawing.Size(152, 50);
            this.histValBtn3.TabIndex = 30;
            this.histValBtn3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.histValBtn3.UseVisualStyleBackColor = false;
            this.histValBtn3.Click += new System.EventHandler(this.histValBtn3_Click);
            // 
            // histValBtn4
            // 
            this.histValBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histValBtn4.Location = new System.Drawing.Point(307, 230);
            this.histValBtn4.Name = "histValBtn4";
            this.histValBtn4.Size = new System.Drawing.Size(152, 50);
            this.histValBtn4.TabIndex = 31;
            this.histValBtn4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.histValBtn4.UseVisualStyleBackColor = false;
            this.histValBtn4.Click += new System.EventHandler(this.histValBtn4_Click);
            // 
            // histValBtn5
            // 
            this.histValBtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histValBtn5.Location = new System.Drawing.Point(307, 284);
            this.histValBtn5.Name = "histValBtn5";
            this.histValBtn5.Size = new System.Drawing.Size(152, 50);
            this.histValBtn5.TabIndex = 32;
            this.histValBtn5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.histValBtn5.UseVisualStyleBackColor = false;
            this.histValBtn5.Click += new System.EventHandler(this.histValBtn5_Click);
            // 
            // histValBtn6
            // 
            this.histValBtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histValBtn6.Location = new System.Drawing.Point(307, 338);
            this.histValBtn6.Name = "histValBtn6";
            this.histValBtn6.Size = new System.Drawing.Size(152, 50);
            this.histValBtn6.TabIndex = 33;
            this.histValBtn6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.histValBtn6.UseVisualStyleBackColor = false;
            this.histValBtn6.Click += new System.EventHandler(this.histValBtn6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(325, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 34;
            this.label1.Text = "History";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.histValBtn6);
            this.Controls.Add(this.histValBtn5);
            this.Controls.Add(this.histValBtn4);
            this.Controls.Add(this.histValBtn3);
            this.Controls.Add(this.histValBtn2);
            this.Controls.Add(this.histValBtn1);
            this.Controls.Add(this.histBtn);
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
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button histBtn;
        private System.Windows.Forms.Button histValBtn1;
        private System.Windows.Forms.Button histValBtn2;
        private System.Windows.Forms.Button histValBtn3;
        private System.Windows.Forms.Button histValBtn4;
        private System.Windows.Forms.Button histValBtn5;
        private System.Windows.Forms.Button histValBtn6;
        private System.Windows.Forms.Label label1;
    }
}

