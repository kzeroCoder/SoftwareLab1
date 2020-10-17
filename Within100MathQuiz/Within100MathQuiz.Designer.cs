namespace Within100MathQuiz
{
    partial class Quiz
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
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.LabelTimerDescribe = new System.Windows.Forms.Label();
            this.LabelLeftPlusNum = new System.Windows.Forms.Label();
            this.LabelRightPlusNum = new System.Windows.Forms.Label();
            this.LabelPlus = new System.Windows.Forms.Label();
            this.LabelEqualSign_Add = new System.Windows.Forms.Label();
            this.LabelEqualSign_Minus = new System.Windows.Forms.Label();
            this.labelMinus = new System.Windows.Forms.Label();
            this.LabelRightMinusNum = new System.Windows.Forms.Label();
            this.LabelLeftMinusNum = new System.Windows.Forms.Label();
            this.LabelEqualSign_Multiply = new System.Windows.Forms.Label();
            this.LabelMultiply = new System.Windows.Forms.Label();
            this.LabelRightMultiplyNum = new System.Windows.Forms.Label();
            this.LabelLeftMultiplyNum = new System.Windows.Forms.Label();
            this.LabelLeftDivideNum = new System.Windows.Forms.Label();
            this.LabelRightDivideNum = new System.Windows.Forms.Label();
            this.LabelDivide = new System.Windows.Forms.Label();
            this.LabelEqualSign_Divide = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Sum = new System.Windows.Forms.RichTextBox();
            this.Difference = new System.Windows.Forms.RichTextBox();
            this.Product = new System.Windows.Forms.RichTextBox();
            this.Quotient = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(232, 27);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "小火汁，你能算出来吗？";
            // 
            // LabelTimer
            // 
            this.LabelTimer.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTimer.Location = new System.Drawing.Point(376, 9);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(101, 30);
            this.LabelTimer.TabIndex = 1;
            this.LabelTimer.Text = "TimeLeft";
            // 
            // LabelTimerDescribe
            // 
            this.LabelTimerDescribe.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTimerDescribe.Location = new System.Drawing.Point(264, 9);
            this.LabelTimerDescribe.Name = "LabelTimerDescribe";
            this.LabelTimerDescribe.Size = new System.Drawing.Size(106, 30);
            this.LabelTimerDescribe.TabIndex = 2;
            this.LabelTimerDescribe.Text = "你还剩下:";
            // 
            // LabelLeftPlusNum
            // 
            this.LabelLeftPlusNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftPlusNum.Location = new System.Drawing.Point(32, 78);
            this.LabelLeftPlusNum.Name = "LabelLeftPlusNum";
            this.LabelLeftPlusNum.Size = new System.Drawing.Size(52, 29);
            this.LabelLeftPlusNum.TabIndex = 3;
            this.LabelLeftPlusNum.Text = "?";
            this.LabelLeftPlusNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRightPlusNum
            // 
            this.LabelRightPlusNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightPlusNum.Location = new System.Drawing.Point(171, 78);
            this.LabelRightPlusNum.Name = "LabelRightPlusNum";
            this.LabelRightPlusNum.Size = new System.Drawing.Size(52, 29);
            this.LabelRightPlusNum.TabIndex = 3;
            this.LabelRightPlusNum.Text = "?";
            this.LabelRightPlusNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPlus
            // 
            this.LabelPlus.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelPlus.Location = new System.Drawing.Point(99, 78);
            this.LabelPlus.Name = "LabelPlus";
            this.LabelPlus.Size = new System.Drawing.Size(52, 29);
            this.LabelPlus.TabIndex = 3;
            this.LabelPlus.Text = "+";
            this.LabelPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_Add
            // 
            this.LabelEqualSign_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_Add.Location = new System.Drawing.Point(238, 78);
            this.LabelEqualSign_Add.Name = "LabelEqualSign_Add";
            this.LabelEqualSign_Add.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_Add.TabIndex = 3;
            this.LabelEqualSign_Add.Text = "=";
            this.LabelEqualSign_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_Minus
            // 
            this.LabelEqualSign_Minus.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_Minus.Location = new System.Drawing.Point(238, 147);
            this.LabelEqualSign_Minus.Name = "LabelEqualSign_Minus";
            this.LabelEqualSign_Minus.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_Minus.TabIndex = 3;
            this.LabelEqualSign_Minus.Text = "=";
            this.LabelEqualSign_Minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinus
            // 
            this.labelMinus.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinus.Location = new System.Drawing.Point(99, 147);
            this.labelMinus.Name = "labelMinus";
            this.labelMinus.Size = new System.Drawing.Size(52, 29);
            this.labelMinus.TabIndex = 3;
            this.labelMinus.Text = "-";
            this.labelMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRightMinusNum
            // 
            this.LabelRightMinusNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightMinusNum.Location = new System.Drawing.Point(171, 147);
            this.LabelRightMinusNum.Name = "LabelRightMinusNum";
            this.LabelRightMinusNum.Size = new System.Drawing.Size(52, 29);
            this.LabelRightMinusNum.TabIndex = 3;
            this.LabelRightMinusNum.Text = "?";
            this.LabelRightMinusNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLeftMinusNum
            // 
            this.LabelLeftMinusNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftMinusNum.Location = new System.Drawing.Point(32, 147);
            this.LabelLeftMinusNum.Name = "LabelLeftMinusNum";
            this.LabelLeftMinusNum.Size = new System.Drawing.Size(52, 29);
            this.LabelLeftMinusNum.TabIndex = 3;
            this.LabelLeftMinusNum.Text = "?";
            this.LabelLeftMinusNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_Multiply
            // 
            this.LabelEqualSign_Multiply.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_Multiply.Location = new System.Drawing.Point(238, 215);
            this.LabelEqualSign_Multiply.Name = "LabelEqualSign_Multiply";
            this.LabelEqualSign_Multiply.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_Multiply.TabIndex = 3;
            this.LabelEqualSign_Multiply.Text = "=";
            this.LabelEqualSign_Multiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMultiply
            // 
            this.LabelMultiply.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMultiply.Location = new System.Drawing.Point(99, 215);
            this.LabelMultiply.Name = "LabelMultiply";
            this.LabelMultiply.Size = new System.Drawing.Size(52, 29);
            this.LabelMultiply.TabIndex = 3;
            this.LabelMultiply.Text = "*";
            this.LabelMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRightMultiplyNum
            // 
            this.LabelRightMultiplyNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightMultiplyNum.Location = new System.Drawing.Point(171, 215);
            this.LabelRightMultiplyNum.Name = "LabelRightMultiplyNum";
            this.LabelRightMultiplyNum.Size = new System.Drawing.Size(52, 29);
            this.LabelRightMultiplyNum.TabIndex = 3;
            this.LabelRightMultiplyNum.Text = "?";
            this.LabelRightMultiplyNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLeftMultiplyNum
            // 
            this.LabelLeftMultiplyNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftMultiplyNum.Location = new System.Drawing.Point(32, 215);
            this.LabelLeftMultiplyNum.Name = "LabelLeftMultiplyNum";
            this.LabelLeftMultiplyNum.Size = new System.Drawing.Size(52, 29);
            this.LabelLeftMultiplyNum.TabIndex = 3;
            this.LabelLeftMultiplyNum.Text = "?";
            this.LabelLeftMultiplyNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLeftDivideNum
            // 
            this.LabelLeftDivideNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelLeftDivideNum.Location = new System.Drawing.Point(32, 280);
            this.LabelLeftDivideNum.Name = "LabelLeftDivideNum";
            this.LabelLeftDivideNum.Size = new System.Drawing.Size(52, 29);
            this.LabelLeftDivideNum.TabIndex = 3;
            this.LabelLeftDivideNum.Text = "?";
            this.LabelLeftDivideNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRightDivideNum
            // 
            this.LabelRightDivideNum.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRightDivideNum.Location = new System.Drawing.Point(171, 280);
            this.LabelRightDivideNum.Name = "LabelRightDivideNum";
            this.LabelRightDivideNum.Size = new System.Drawing.Size(52, 29);
            this.LabelRightDivideNum.TabIndex = 3;
            this.LabelRightDivideNum.Text = "?";
            this.LabelRightDivideNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDivide
            // 
            this.LabelDivide.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDivide.Location = new System.Drawing.Point(99, 280);
            this.LabelDivide.Name = "LabelDivide";
            this.LabelDivide.Size = new System.Drawing.Size(52, 29);
            this.LabelDivide.TabIndex = 3;
            this.LabelDivide.Text = "/";
            this.LabelDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelEqualSign_Divide
            // 
            this.LabelEqualSign_Divide.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEqualSign_Divide.Location = new System.Drawing.Point(238, 280);
            this.LabelEqualSign_Divide.Name = "LabelEqualSign_Divide";
            this.LabelEqualSign_Divide.Size = new System.Drawing.Size(52, 29);
            this.LabelEqualSign_Divide.TabIndex = 3;
            this.LabelEqualSign_Divide.Text = "=";
            this.LabelEqualSign_Divide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonStart.Location = new System.Drawing.Point(433, 252);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(121, 65);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "开始测验？";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sum.Location = new System.Drawing.Point(296, 78);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(80, 46);
            this.Sum.TabIndex = 6;
            this.Sum.Text = "";
            // 
            // Difference
            // 
            this.Difference.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Difference.Location = new System.Drawing.Point(296, 144);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(80, 46);
            this.Difference.TabIndex = 6;
            this.Difference.Text = "";
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Product.Location = new System.Drawing.Point(296, 212);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(80, 46);
            this.Product.TabIndex = 6;
            this.Product.Text = "";
            // 
            // Quotient
            // 
            this.Quotient.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quotient.Location = new System.Drawing.Point(296, 277);
            this.Quotient.Name = "Quotient";
            this.Quotient.Size = new System.Drawing.Size(80, 46);
            this.Quotient.TabIndex = 6;
            this.Quotient.Text = "";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(579, 368);
            this.Controls.Add(this.Quotient);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelEqualSign_Divide);
            this.Controls.Add(this.LabelDivide);
            this.Controls.Add(this.LabelRightDivideNum);
            this.Controls.Add(this.LabelLeftDivideNum);
            this.Controls.Add(this.LabelLeftMultiplyNum);
            this.Controls.Add(this.LabelRightMultiplyNum);
            this.Controls.Add(this.LabelMultiply);
            this.Controls.Add(this.LabelEqualSign_Multiply);
            this.Controls.Add(this.LabelLeftMinusNum);
            this.Controls.Add(this.LabelRightMinusNum);
            this.Controls.Add(this.labelMinus);
            this.Controls.Add(this.LabelEqualSign_Minus);
            this.Controls.Add(this.LabelEqualSign_Add);
            this.Controls.Add(this.LabelPlus);
            this.Controls.Add(this.LabelRightPlusNum);
            this.Controls.Add(this.LabelLeftPlusNum);
            this.Controls.Add(this.LabelTimerDescribe);
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Quiz";
            this.Text = "加减法测验";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Label LabelTimerDescribe;
        private System.Windows.Forms.Label LabelLeftPlusNum;
        private System.Windows.Forms.Label LabelRightPlusNum;
        private System.Windows.Forms.Label LabelPlus;
        private System.Windows.Forms.Label LabelEqualSign_Add;
        private System.Windows.Forms.Label LabelEqualSign_Minus;
        private System.Windows.Forms.Label labelMinus;
        private System.Windows.Forms.Label LabelRightMinusNum;
        private System.Windows.Forms.Label LabelLeftMinusNum;
        private System.Windows.Forms.Label LabelEqualSign_Multiply;
        private System.Windows.Forms.Label LabelMultiply;
        private System.Windows.Forms.Label LabelRightMultiplyNum;
        private System.Windows.Forms.Label LabelLeftMultiplyNum;
        private System.Windows.Forms.Label LabelLeftDivideNum;
        private System.Windows.Forms.Label LabelRightDivideNum;
        private System.Windows.Forms.Label LabelDivide;
        private System.Windows.Forms.Label LabelEqualSign_Divide;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox Sum;
        private System.Windows.Forms.RichTextBox Difference;
        private System.Windows.Forms.RichTextBox Product;
        private System.Windows.Forms.RichTextBox Quotient;
    }
}

