namespace AlifCalcv2
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
            this.PanelTBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ClearElementBtn = new System.Windows.Forms.Button();
            this.BackspaceBtn = new System.Windows.Forms.Button();
            this.SqrtBtn = new System.Windows.Forms.Button();
            this.ProcBtn = new System.Windows.Forms.Button();
            this.OnOneBtn = new System.Windows.Forms.Button();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.DevideBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.Num9Btn = new System.Windows.Forms.Button();
            this.Num8Btn = new System.Windows.Forms.Button();
            this.Num7Btn = new System.Windows.Forms.Button();
            this.Num6Btn = new System.Windows.Forms.Button();
            this.Num5Btn = new System.Windows.Forms.Button();
            this.Num4Btn = new System.Windows.Forms.Button();
            this.Num3Btn = new System.Windows.Forms.Button();
            this.Num2Btn = new System.Windows.Forms.Button();
            this.Num1Btn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.Num0Btn = new System.Windows.Forms.Button();
            this.PmBtn = new System.Windows.Forms.Button();
            this.McBtn = new System.Windows.Forms.Button();
            this.MsBtn = new System.Windows.Forms.Button();
            this.MmBtn = new System.Windows.Forms.Button();
            this.MpBtn = new System.Windows.Forms.Button();
            this.FunctionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PanelTBox
            // 
            this.PanelTBox.Location = new System.Drawing.Point(12, 12);
            this.PanelTBox.Name = "PanelTBox";
            this.PanelTBox.ReadOnly = true;
            this.PanelTBox.Size = new System.Drawing.Size(303, 20);
            this.PanelTBox.TabIndex = 0;
            this.PanelTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClearBtn
            // 
            this.ClearBtn.ForeColor = System.Drawing.Color.Red;
            this.ClearBtn.Location = new System.Drawing.Point(245, 38);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(70, 32);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "C";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ClearElementBtn
            // 
            this.ClearElementBtn.ForeColor = System.Drawing.Color.Red;
            this.ClearElementBtn.Location = new System.Drawing.Point(154, 38);
            this.ClearElementBtn.Name = "ClearElementBtn";
            this.ClearElementBtn.Size = new System.Drawing.Size(85, 32);
            this.ClearElementBtn.TabIndex = 2;
            this.ClearElementBtn.Text = "CE";
            this.ClearElementBtn.UseVisualStyleBackColor = true;
            this.ClearElementBtn.Click += new System.EventHandler(this.ClearElementBtn_Click);
            // 
            // BackspaceBtn
            // 
            this.BackspaceBtn.ForeColor = System.Drawing.Color.Red;
            this.BackspaceBtn.Location = new System.Drawing.Point(67, 38);
            this.BackspaceBtn.Name = "BackspaceBtn";
            this.BackspaceBtn.Size = new System.Drawing.Size(81, 32);
            this.BackspaceBtn.TabIndex = 3;
            this.BackspaceBtn.Text = "Backspace";
            this.BackspaceBtn.UseVisualStyleBackColor = true;
            this.BackspaceBtn.Click += new System.EventHandler(this.BackspaceBtn_Click);
            // 
            // SqrtBtn
            // 
            this.SqrtBtn.ForeColor = System.Drawing.Color.Navy;
            this.SqrtBtn.Location = new System.Drawing.Point(270, 76);
            this.SqrtBtn.Name = "SqrtBtn";
            this.SqrtBtn.Size = new System.Drawing.Size(45, 30);
            this.SqrtBtn.TabIndex = 4;
            this.SqrtBtn.Text = "sqrt";
            this.SqrtBtn.UseVisualStyleBackColor = true;
            // 
            // ProcBtn
            // 
            this.ProcBtn.ForeColor = System.Drawing.Color.Navy;
            this.ProcBtn.Location = new System.Drawing.Point(270, 112);
            this.ProcBtn.Name = "ProcBtn";
            this.ProcBtn.Size = new System.Drawing.Size(45, 30);
            this.ProcBtn.TabIndex = 5;
            this.ProcBtn.Text = "%";
            this.ProcBtn.UseVisualStyleBackColor = true;
            // 
            // OnOneBtn
            // 
            this.OnOneBtn.ForeColor = System.Drawing.Color.Navy;
            this.OnOneBtn.Location = new System.Drawing.Point(270, 148);
            this.OnOneBtn.Name = "OnOneBtn";
            this.OnOneBtn.Size = new System.Drawing.Size(45, 30);
            this.OnOneBtn.TabIndex = 6;
            this.OnOneBtn.Text = "1/x";
            this.OnOneBtn.UseVisualStyleBackColor = true;
            // 
            // ResultBtn
            // 
            this.ResultBtn.ForeColor = System.Drawing.Color.Red;
            this.ResultBtn.Location = new System.Drawing.Point(270, 184);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(45, 30);
            this.ResultBtn.TabIndex = 7;
            this.ResultBtn.Text = "=";
            this.ResultBtn.UseVisualStyleBackColor = true;
            // 
            // DevideBtn
            // 
            this.DevideBtn.ForeColor = System.Drawing.Color.Red;
            this.DevideBtn.Location = new System.Drawing.Point(220, 76);
            this.DevideBtn.Name = "DevideBtn";
            this.DevideBtn.Size = new System.Drawing.Size(45, 30);
            this.DevideBtn.TabIndex = 8;
            this.DevideBtn.Text = "/";
            this.DevideBtn.UseVisualStyleBackColor = true;
            this.DevideBtn.Click += new System.EventHandler(this.Function_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.ForeColor = System.Drawing.Color.Red;
            this.MultiplyBtn.Location = new System.Drawing.Point(220, 112);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(45, 30);
            this.MultiplyBtn.TabIndex = 9;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.Function_Click);

            // 
            // MinusBtn
            // 
            this.MinusBtn.ForeColor = System.Drawing.Color.Red;
            this.MinusBtn.Location = new System.Drawing.Point(220, 148);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(45, 30);
            this.MinusBtn.TabIndex = 10;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.Function_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.ForeColor = System.Drawing.Color.Red;
            this.PlusBtn.Location = new System.Drawing.Point(220, 184);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(45, 30);
            this.PlusBtn.TabIndex = 11;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.Function_Click);
            // 
            // Num9Btn
            // 
            this.Num9Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num9Btn.Location = new System.Drawing.Point(169, 76);
            this.Num9Btn.Name = "Num9Btn";
            this.Num9Btn.Size = new System.Drawing.Size(45, 30);
            this.Num9Btn.TabIndex = 12;
            this.Num9Btn.Text = "9";
            this.Num9Btn.UseVisualStyleBackColor = true;
            this.Num9Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num8Btn
            // 
            this.Num8Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num8Btn.Location = new System.Drawing.Point(118, 76);
            this.Num8Btn.Name = "Num8Btn";
            this.Num8Btn.Size = new System.Drawing.Size(45, 30);
            this.Num8Btn.TabIndex = 13;
            this.Num8Btn.Text = "8";
            this.Num8Btn.UseVisualStyleBackColor = true;
            this.Num8Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num7Btn
            // 
            this.Num7Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num7Btn.Location = new System.Drawing.Point(67, 76);
            this.Num7Btn.Name = "Num7Btn";
            this.Num7Btn.Size = new System.Drawing.Size(45, 30);
            this.Num7Btn.TabIndex = 14;
            this.Num7Btn.Text = "7";
            this.Num7Btn.UseVisualStyleBackColor = true;
            this.Num7Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num6Btn
            // 
            this.Num6Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num6Btn.Location = new System.Drawing.Point(169, 112);
            this.Num6Btn.Name = "Num6Btn";
            this.Num6Btn.Size = new System.Drawing.Size(45, 30);
            this.Num6Btn.TabIndex = 15;
            this.Num6Btn.Text = "6";
            this.Num6Btn.UseVisualStyleBackColor = true;
            this.Num6Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num5Btn
            // 
            this.Num5Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num5Btn.Location = new System.Drawing.Point(118, 112);
            this.Num5Btn.Name = "Num5Btn";
            this.Num5Btn.Size = new System.Drawing.Size(45, 30);
            this.Num5Btn.TabIndex = 16;
            this.Num5Btn.Text = "5";
            this.Num5Btn.UseVisualStyleBackColor = true;
            this.Num5Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num4Btn
            // 
            this.Num4Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num4Btn.Location = new System.Drawing.Point(67, 112);
            this.Num4Btn.Name = "Num4Btn";
            this.Num4Btn.Size = new System.Drawing.Size(45, 30);
            this.Num4Btn.TabIndex = 17;
            this.Num4Btn.Text = "4";
            this.Num4Btn.UseVisualStyleBackColor = true;
            this.Num4Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num3Btn
            // 
            this.Num3Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num3Btn.Location = new System.Drawing.Point(169, 148);
            this.Num3Btn.Name = "Num3Btn";
            this.Num3Btn.Size = new System.Drawing.Size(45, 30);
            this.Num3Btn.TabIndex = 18;
            this.Num3Btn.Text = "3";
            this.Num3Btn.UseVisualStyleBackColor = true;
            this.Num3Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num2Btn
            // 
            this.Num2Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num2Btn.Location = new System.Drawing.Point(118, 148);
            this.Num2Btn.Name = "Num2Btn";
            this.Num2Btn.Size = new System.Drawing.Size(45, 30);
            this.Num2Btn.TabIndex = 19;
            this.Num2Btn.Text = "2";
            this.Num2Btn.UseVisualStyleBackColor = true;
            this.Num2Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // Num1Btn
            // 
            this.Num1Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num1Btn.Location = new System.Drawing.Point(67, 148);
            this.Num1Btn.Name = "Num1Btn";
            this.Num1Btn.Size = new System.Drawing.Size(45, 30);
            this.Num1Btn.TabIndex = 20;
            this.Num1Btn.Text = "1";
            this.Num1Btn.UseVisualStyleBackColor = true;
            this.Num1Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // DotBtn
            // 
            this.DotBtn.ForeColor = System.Drawing.Color.Navy;
            this.DotBtn.Location = new System.Drawing.Point(169, 184);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(45, 30);
            this.DotBtn.TabIndex = 21;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = true;
            // 
            // Num0Btn
            // 
            this.Num0Btn.ForeColor = System.Drawing.Color.Navy;
            this.Num0Btn.Location = new System.Drawing.Point(118, 184);
            this.Num0Btn.Name = "Num0Btn";
            this.Num0Btn.Size = new System.Drawing.Size(45, 30);
            this.Num0Btn.TabIndex = 22;
            this.Num0Btn.Text = "0";
            this.Num0Btn.UseVisualStyleBackColor = true;
            this.Num0Btn.Click += new System.EventHandler(this.Num_Click);
            // 
            // PmBtn
            // 
            this.PmBtn.ForeColor = System.Drawing.Color.Navy;
            this.PmBtn.Location = new System.Drawing.Point(67, 184);
            this.PmBtn.Name = "PmBtn";
            this.PmBtn.Size = new System.Drawing.Size(45, 30);
            this.PmBtn.TabIndex = 23;
            this.PmBtn.Text = "+/-";
            this.PmBtn.UseVisualStyleBackColor = true;
            // 
            // McBtn
            // 
            this.McBtn.ForeColor = System.Drawing.Color.Red;
            this.McBtn.Location = new System.Drawing.Point(12, 76);
            this.McBtn.Name = "McBtn";
            this.McBtn.Size = new System.Drawing.Size(45, 30);
            this.McBtn.TabIndex = 24;
            this.McBtn.Text = "MC";
            this.McBtn.UseVisualStyleBackColor = true;
            // 
            // MsBtn
            // 
            this.MsBtn.ForeColor = System.Drawing.Color.Red;
            this.MsBtn.Location = new System.Drawing.Point(12, 112);
            this.MsBtn.Name = "MsBtn";
            this.MsBtn.Size = new System.Drawing.Size(45, 30);
            this.MsBtn.TabIndex = 25;
            this.MsBtn.Text = "MS";
            this.MsBtn.UseVisualStyleBackColor = true;
            // 
            // MmBtn
            // 
            this.MmBtn.ForeColor = System.Drawing.Color.Red;
            this.MmBtn.Location = new System.Drawing.Point(12, 184);
            this.MmBtn.Name = "MmBtn";
            this.MmBtn.Size = new System.Drawing.Size(45, 30);
            this.MmBtn.TabIndex = 25;
            this.MmBtn.Text = "M-";
            this.MmBtn.UseVisualStyleBackColor = true;
            // 
            // MpBtn
            // 
            this.MpBtn.ForeColor = System.Drawing.Color.Red;
            this.MpBtn.Location = new System.Drawing.Point(12, 148);
            this.MpBtn.Name = "MpBtn";
            this.MpBtn.Size = new System.Drawing.Size(45, 30);
            this.MpBtn.TabIndex = 25;
            this.MpBtn.Text = "M+";
            this.MpBtn.UseVisualStyleBackColor = true;
            // 
            // FunctionLbl
            // 
            this.FunctionLbl.AutoSize = true;
            this.FunctionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionLbl.Location = new System.Drawing.Point(22, 39);
            this.FunctionLbl.Name = "FunctionLbl";
            this.FunctionLbl.Size = new System.Drawing.Size(0, 31);
            this.FunctionLbl.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 219);
            this.Controls.Add(this.FunctionLbl);
            this.Controls.Add(this.MpBtn);
            this.Controls.Add(this.MmBtn);
            this.Controls.Add(this.MsBtn);
            this.Controls.Add(this.McBtn);
            this.Controls.Add(this.PmBtn);
            this.Controls.Add(this.Num0Btn);
            this.Controls.Add(this.DotBtn);
            this.Controls.Add(this.Num1Btn);
            this.Controls.Add(this.Num2Btn);
            this.Controls.Add(this.Num3Btn);
            this.Controls.Add(this.Num4Btn);
            this.Controls.Add(this.Num5Btn);
            this.Controls.Add(this.Num6Btn);
            this.Controls.Add(this.Num7Btn);
            this.Controls.Add(this.Num8Btn);
            this.Controls.Add(this.Num9Btn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.DevideBtn);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.OnOneBtn);
            this.Controls.Add(this.ProcBtn);
            this.Controls.Add(this.SqrtBtn);
            this.Controls.Add(this.BackspaceBtn);
            this.Controls.Add(this.ClearElementBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PanelTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "SuperCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PanelTBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ClearElementBtn;
        private System.Windows.Forms.Button BackspaceBtn;
        private System.Windows.Forms.Button SqrtBtn;
        private System.Windows.Forms.Button ProcBtn;
        private System.Windows.Forms.Button OnOneBtn;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.Button DevideBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button Num9Btn;
        private System.Windows.Forms.Button Num8Btn;
        private System.Windows.Forms.Button Num7Btn;
        private System.Windows.Forms.Button Num6Btn;
        private System.Windows.Forms.Button Num5Btn;
        private System.Windows.Forms.Button Num4Btn;
        private System.Windows.Forms.Button Num3Btn;
        private System.Windows.Forms.Button Num2Btn;
        private System.Windows.Forms.Button Num1Btn;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.Button Num0Btn;
        private System.Windows.Forms.Button PmBtn;
        private System.Windows.Forms.Button McBtn;
        private System.Windows.Forms.Button MsBtn;
        private System.Windows.Forms.Button MmBtn;
        private System.Windows.Forms.Button MpBtn;
        private System.Windows.Forms.Label FunctionLbl;
    }
}

