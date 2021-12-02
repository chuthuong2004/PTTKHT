
namespace UI_PTTKHT
{
    partial class FrmDangNhap
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
            this.btnDangNhapGV = new System.Windows.Forms.Button();
            this.btnDangNhapHs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangNhapGV
            // 
            this.btnDangNhapGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhapGV.Location = new System.Drawing.Point(38, 28);
            this.btnDangNhapGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhapGV.Name = "btnDangNhapGV";
            this.btnDangNhapGV.Size = new System.Drawing.Size(381, 31);
            this.btnDangNhapGV.TabIndex = 0;
            this.btnDangNhapGV.Text = "Đăng nhập với giáo viên";
            this.btnDangNhapGV.UseVisualStyleBackColor = true;
            this.btnDangNhapGV.Click += new System.EventHandler(this.btnDangNhapGV_Click);
            // 
            // btnDangNhapHs
            // 
            this.btnDangNhapHs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhapHs.Location = new System.Drawing.Point(38, 88);
            this.btnDangNhapHs.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhapHs.Name = "btnDangNhapHs";
            this.btnDangNhapHs.Size = new System.Drawing.Size(381, 31);
            this.btnDangNhapHs.TabIndex = 0;
            this.btnDangNhapHs.Text = "Đăng nhập với học sinh";
            this.btnDangNhapHs.UseVisualStyleBackColor = true;
            this.btnDangNhapHs.Click += new System.EventHandler(this.btnDangNhapHs_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 150);
            this.Controls.Add(this.btnDangNhapHs);
            this.Controls.Add(this.btnDangNhapGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangNhap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhapGV;
        private System.Windows.Forms.Button btnDangNhapHs;
    }
}