namespace obiz_Painter
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtWide = new System.Windows.Forms.TextBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(4, 66);
            this.picImg.Margin = new System.Windows.Forms.Padding(2);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(581, 387);
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            this.picImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseDown);
            this.picImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseMove);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(4, 22);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtWide
            // 
            this.txtWide.Location = new System.Drawing.Point(85, 22);
            this.txtWide.Name = "txtWide";
            this.txtWide.Size = new System.Drawing.Size(120, 22);
            this.txtWide.TabIndex = 2;
            this.txtWide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWide_KeyDown);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(349, 22);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 3;
            this.btnLine.Text = "線條";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(430, 22);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(75, 23);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Text = "圓形";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(511, 22);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.Text = "方形";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 464);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.txtWide);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.picImg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtWide;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
    }
}

