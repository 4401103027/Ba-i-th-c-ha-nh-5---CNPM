namespace BTH5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcu = new System.Windows.Forms.TextBox();
            this.txtMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdntt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btntiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính tiền điện sinh hoạt bậc thang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chỉ số cũ";
            // 
            // txtcu
            // 
            this.txtcu.Location = new System.Drawing.Point(475, 195);
            this.txtcu.Name = "txtcu";
            this.txtcu.Size = new System.Drawing.Size(456, 31);
            this.txtcu.TabIndex = 2;
            // 
            // txtMoi
            // 
            this.txtMoi.Location = new System.Drawing.Point(475, 274);
            this.txtMoi.Name = "txtMoi";
            this.txtMoi.Size = new System.Drawing.Size(456, 31);
            this.txtMoi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chỉ số mới";
            // 
            // txtdntt
            // 
            this.txtdntt.Location = new System.Drawing.Point(475, 352);
            this.txtdntt.Name = "txtdntt";
            this.txtdntt.Size = new System.Drawing.Size(456, 31);
            this.txtdntt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điện năng tiêu thụ";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(475, 430);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(456, 31);
            this.txtTong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thành tiền";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(475, 509);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(456, 31);
            this.txtVat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng tiền đã có VAT";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(92, 605);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(184, 56);
            this.btnTinh.TabIndex = 11;
            this.btnTinh.Text = "Tính tiền điện";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(816, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 56);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntiep
            // 
            this.btntiep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiep.Location = new System.Drawing.Point(459, 605);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(184, 56);
            this.btntiep.TabIndex = 13;
            this.btntiep.Text = "Tiếp tục";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 749);
            this.Controls.Add(this.btntiep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdntt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcu;
        private System.Windows.Forms.TextBox txtMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdntt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btntiep;
    }
}

