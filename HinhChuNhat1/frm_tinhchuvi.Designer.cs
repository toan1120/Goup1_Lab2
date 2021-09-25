namespace HinhChuNhat1
{
    partial class frm_tinhchuvi
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
            this.txt_chieudai = new System.Windows.Forms.TextBox();
            this.btn_tinhchuvi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.txt_chieurong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_chieudai
            // 
            this.txt_chieudai.Location = new System.Drawing.Point(299, 99);
            this.txt_chieudai.Name = "txt_chieudai";
            this.txt_chieudai.Size = new System.Drawing.Size(100, 20);
            this.txt_chieudai.TabIndex = 9;
            // 
            // btn_tinhchuvi
            // 
            this.btn_tinhchuvi.Location = new System.Drawing.Point(299, 233);
            this.btn_tinhchuvi.Name = "btn_tinhchuvi";
            this.btn_tinhchuvi.Size = new System.Drawing.Size(75, 23);
            this.btn_tinhchuvi.TabIndex = 8;
            this.btn_tinhchuvi.Text = "Tính chu vi";
            this.btn_tinhchuvi.UseVisualStyleBackColor = true;
            this.btn_tinhchuvi.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết Quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chiều rộng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chiều dài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(255, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tính Chu Vi Hình Chữ Nhật";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tính chu vi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(536, 305);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(100, 20);
            this.txt_ketqua.TabIndex = 9;
            // 
            // txt_chieurong
            // 
            this.txt_chieurong.Location = new System.Drawing.Point(299, 160);
            this.txt_chieurong.Name = "txt_chieurong";
            this.txt_chieurong.Size = new System.Drawing.Size(100, 20);
            this.txt_chieurong.TabIndex = 10;
            // 
            // frm_tinhchuvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_chieurong);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.txt_chieudai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_tinhchuvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_tinhchuvi";
            this.Text = "frm_tinhchuvi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_chieudai;
        private System.Windows.Forms.Button btn_tinhchuvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.TextBox txt_chieurong;
    }
}