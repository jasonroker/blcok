namespace block
{
    partial class createblock
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
            this.high = new System.Windows.Forms.TextBox();
            this.width = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // high
            // 
            this.high.Location = new System.Drawing.Point(60, 86);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(100, 21);
            this.high.TabIndex = 13;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(60, 55);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 21);
            this.width.TabIndex = 12;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(60, 23);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 21);
            this.length.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "高";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "宽";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "长";
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(102, 137);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 7;
            this.apply.Text = "生成";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // createblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 169);
            this.Controls.Add(this.high);
            this.Controls.Add(this.width);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apply);
            this.Name = "createblock";
            this.Text = "createblock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox high;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply;
    }
}