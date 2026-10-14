
using System;
using System.Windows.Forms;

namespace Bai1WindowFormHoangMinhVu
{
    public partial class FrmTinhTien : Form
    {
        public FrmTinhTien()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Kiem tra cac o nhap lieu
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                MessageBox.Show(
                    "Vui long nhap day du thong tin!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Chuyen du lieu sang kieu so
            decimal donGia;
            int soLuong;
            decimal giamGia;

            if (!decimal.TryParse(txtDonGia.Text, out donGia) ||
                !int.TryParse(txtSoLuong.Text, out soLuong) ||
                !decimal.TryParse(txtGiamGia.Text, out giamGia))
            {
                MessageBox.Show(
                    "Vui long chi nhap du lieu so hop le!",
                    "Loi nhap lieu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Kiem tra gia tri
            if (donGia <= 0 || soLuong <= 0 ||
                giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show(
                    "Don gia va so luong phai lon hon 0. " +
                    "Giam gia phai tu 0 den 100%.",
                    "Du lieu khong hop le",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Tinh tong tien
            decimal tongTien = donGia * soLuong
                               * (100 - giamGia) / 100;

            // Hien thi ket qua
            lblTongTien.Text = "Tong tien: "
                               + tongTien.ToString("N0")
                               + " VNĐ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();

            lblTongTien.Text = "Tong tien: 0 VNĐ";

            txtDonGia.Focus();
        }
    }
}
