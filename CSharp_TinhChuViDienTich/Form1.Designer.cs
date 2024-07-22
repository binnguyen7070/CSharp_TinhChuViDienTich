namespace CSharp_TinhChuViDienTich
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
            label1 = new Label();
            label2 = new Label();
            txtdai = new TextBox();
            txtrong = new TextBox();
            btnTinh = new Button();
            label3 = new Label();
            lbKQ = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 81);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 131);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Chiều rộng";
            // 
            // txtdai
            // 
            txtdai.Location = new Point(210, 73);
            txtdai.Name = "txtdai";
            txtdai.Size = new Size(100, 23);
            txtdai.TabIndex = 2;
            // 
            // txtrong
            // 
            txtrong.Location = new Point(210, 123);
            txtrong.Name = "txtrong";
            txtrong.Size = new Size(100, 23);
            txtrong.TabIndex = 3;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(220, 199);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 257);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Kết quả";
            // 
            // lbKQ
            // 
            lbKQ.AutoSize = true;
            lbKQ.Location = new Point(210, 253);
            lbKQ.Name = "lbKQ";
            lbKQ.Size = new Size(38, 15);
            lbKQ.TabIndex = 6;
            lbKQ.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbKQ);
            Controls.Add(label3);
            Controls.Add(btnTinh);
            Controls.Add(txtrong);
            Controls.Add(txtdai);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtdai;
        private TextBox txtrong;
        private Button btnTinh;
        private Label label3;
        private Label lbKQ;
    }
}
