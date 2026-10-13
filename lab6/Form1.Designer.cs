namespace lab6
{
    partial class frmNhapLieu
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
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.lblSoDong = new System.Windows.Forms.Label();
            this.lblSoCot = new System.Windows.Forms.Label();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoDong
            // 
            this.txtSoDong.Location = new System.Drawing.Point(117, 40);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(132, 22);
            this.txtSoDong.TabIndex = 0;
            // 
            // lblSoDong
            // 
            this.lblSoDong.AutoSize = true;
            this.lblSoDong.Location = new System.Drawing.Point(41, 46);
            this.lblSoDong.Name = "lblSoDong";
            this.lblSoDong.Size = new System.Drawing.Size(58, 16);
            this.lblSoDong.TabIndex = 1;
            this.lblSoDong.Text = "Số dòng";
            // 
            // lblSoCot
            // 
            this.lblSoCot.AutoSize = true;
            this.lblSoCot.Location = new System.Drawing.Point(51, 94);
            this.lblSoCot.Name = "lblSoCot";
            this.lblSoCot.Size = new System.Drawing.Size(48, 16);
            this.lblSoCot.TabIndex = 2;
            this.lblSoCot.Text = "Số cột ";
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(117, 91);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(132, 22);
            this.txtSoCot.TabIndex = 3;
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Location = new System.Drawing.Point(292, 46);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(134, 68);
            this.btnKhoiTao.TabIndex = 4;
            this.btnKhoiTao.Text = "Khởi tạo form";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmNhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.lblSoCot);
            this.Controls.Add(this.lblSoDong);
            this.Controls.Add(this.txtSoDong);
            this.Name = "frmNhapLieu";
            this.Text = "Nhập liệu";
            this.Load += new System.EventHandler(this.frmNhapLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.Label lblSoDong;
        private System.Windows.Forms.Label lblSoCot;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.Button btnKhoiTao;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

