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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Green = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Tb_Wide = new System.Windows.Forms.TextBox();
            this.Btn_Line = new System.Windows.Forms.Button();
            this.Btn_Ellipse = new System.Windows.Forms.Button();
            this.Btn_Rectangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Btn_Green
            // 
            this.Btn_Green.BackColor = System.Drawing.Color.Black;
            this.Btn_Green.Location = new System.Drawing.Point(4, 22);
            this.Btn_Green.Name = "Btn_Green";
            this.Btn_Green.Size = new System.Drawing.Size(75, 23);
            this.Btn_Green.TabIndex = 1;
            this.Btn_Green.UseVisualStyleBackColor = false;
            this.Btn_Green.Click += new System.EventHandler(this.Btn_Green_Click);
            // 
            // Tb_Wide
            // 
            this.Tb_Wide.Location = new System.Drawing.Point(85, 22);
            this.Tb_Wide.Name = "Tb_Wide";
            this.Tb_Wide.Size = new System.Drawing.Size(120, 22);
            this.Tb_Wide.TabIndex = 2;
            this.Tb_Wide.TextChanged += new System.EventHandler(this.Tb_Wide_TextChanged);
            // 
            // Btn_Line
            // 
            this.Btn_Line.Location = new System.Drawing.Point(349, 22);
            this.Btn_Line.Name = "Btn_Line";
            this.Btn_Line.Size = new System.Drawing.Size(75, 23);
            this.Btn_Line.TabIndex = 3;
            this.Btn_Line.Text = "線條";
            this.Btn_Line.UseVisualStyleBackColor = true;
            this.Btn_Line.Click += new System.EventHandler(this.Btn_Line_Click);
            // 
            // Btn_Ellipse
            // 
            this.Btn_Ellipse.Location = new System.Drawing.Point(430, 22);
            this.Btn_Ellipse.Name = "Btn_Ellipse";
            this.Btn_Ellipse.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ellipse.TabIndex = 4;
            this.Btn_Ellipse.Text = "圓形";
            this.Btn_Ellipse.UseVisualStyleBackColor = true;
            this.Btn_Ellipse.Click += new System.EventHandler(this.Btn_Ellipse_Click);
            // 
            // Btn_Rectangle
            // 
            this.Btn_Rectangle.Location = new System.Drawing.Point(511, 22);
            this.Btn_Rectangle.Name = "Btn_Rectangle";
            this.Btn_Rectangle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Rectangle.TabIndex = 5;
            this.Btn_Rectangle.Text = "方形";
            this.Btn_Rectangle.UseVisualStyleBackColor = true;
            this.Btn_Rectangle.Click += new System.EventHandler(this.Btn_Rectangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 464);
            this.Controls.Add(this.Btn_Rectangle);
            this.Controls.Add(this.Btn_Ellipse);
            this.Controls.Add(this.Btn_Line);
            this.Controls.Add(this.Tb_Wide);
            this.Controls.Add(this.Btn_Green);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Green;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox Tb_Wide;
        private System.Windows.Forms.Button Btn_Line;
        private System.Windows.Forms.Button Btn_Ellipse;
        private System.Windows.Forms.Button Btn_Rectangle;
    }
}

