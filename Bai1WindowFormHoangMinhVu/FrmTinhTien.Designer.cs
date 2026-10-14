namespace Bai1WindowFormHoangMinhVu
{
    partial class FrmTinhTien
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
            lblTieuDe = new Label();
            lblDonGia = new Label();
            lblSoLuong = new Label();
            lblGiamGia = new Label();
            lblTongTien = new Label();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            txtGiamGia = new TextBox();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(170, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(354, 33);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "MÁY TÍNH CƯỚC DỊCH VỤ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDonGia.Location = new Point(65, 105);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(165, 19);
            lblDonGia.TabIndex = 1;
            lblDonGia.Text = "Đơn giá dịch vụ (VNĐ)";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(65, 165);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(113, 19);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số lượng khách";
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiamGia.Location = new Point(65, 225);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(100, 19);
            lblGiamGia.TabIndex = 3;
            lblGiamGia.Text = "Giảm giá (%)";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(65, 280);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(179, 26);
            lblTongTien.TabIndex = 4;
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(290, 102);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(250, 27);
            txtDonGia.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(290, 162);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(250, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(290, 222);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(250, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTinhTien.Location = new Point(170, 350);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(130, 40);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLamMoi.Location = new Point(320, 350);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 40);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FrmTinhTien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 433);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(txtGiamGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(lblTongTien);
            Controls.Add(lblGiamGia);
            Controls.Add(lblSoLuong);
            Controls.Add(lblDonGia);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmTinhTien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính cước dịch vụ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblDonGia;
        private Label lblSoLuong;
        private Label lblGiamGia;
        private Label lblTongTien;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private TextBox txtGiamGia;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}