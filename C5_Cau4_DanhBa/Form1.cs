namespace C5_Cau4_DanhBa
{
    public partial class Form1 : Form
    {
        private int _indexDangSua = -1 ;

        public Form1()
        {
            InitializeComponent();
            // Sự kiện đóng Form
            this.FormClosing += Form1_FormClosing;

            // Sự kiện chọn liên hệ trong ListBox
            lstLienHe.SelectedIndexChanged += lstLienHe_SelectedIndexChanged;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(ten) ||
                string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên và số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Nếu đang sửa
            if (_indexDangSua >= 0)
            {
                lstLienHe.Items.RemoveAt(_indexDangSua);

                lstLienHe.Items.Insert(
                    _indexDangSua,
                    ten + " - " + sdt
                );

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _indexDangSua = -1;
            }
            else
            {
                // Thêm liên hệ mới
                lstLienHe.Items.Add(
                    ten + " - " + sdt
                );

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            // Xóa TextBox
            txtTen.Clear();
            txtSDT.Clear();

            // Bỏ chọn
            lstLienHe.ClearSelected();

            // Đưa focus về ô Tên
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Chưa chọn liên hệ
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lưu index đang sửa
            _indexDangSua = lstLienHe.SelectedIndex;

            // Lấy dữ liệu liên hệ
            string lienHe = lstLienHe.SelectedItem.ToString();

            // Tách tên và số điện thoại
            int viTri = lienHe.LastIndexOf(" - ");

            if (viTri >= 0)
            {
                txtTen.Text = lienHe.Substring(0, viTri);
                txtSDT.Text = lienHe.Substring(viTri + 3);
            }

            // Đưa focus về ô Tên
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Chưa chọn liên hệ
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lấy liên hệ đang chọn
            string lienHe = lstLienHe.SelectedItem.ToString();

            // Lấy tên
            int viTri = lienHe.LastIndexOf(" - ");

            string ten;

            if (viTri >= 0)
            {
                ten = lienHe.Substring(0, viTri);
            }
            else
            {
                ten = lienHe;
            }

            // Hỏi xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " +
                ten +
                "? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn Yes
            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(
                    lstLienHe.SelectedIndex
                );

                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(
         object sender,
         FormClosingEventArgs e)
        {
            // Kiểm tra có dữ liệu chưa lưu hay không
            bool coDuLieuChuaLuu =
                !string.IsNullOrWhiteSpace(txtTen.Text) ||
                !string.IsNullOrWhiteSpace(txtSDT.Text);

            // Không có dữ liệu thì cho đóng luôn
            if (!coDuLieuChuaLuu)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có dữ liệu chưa được lưu. " +
                "Bạn muốn thoát không?",
                "Cảnh báo",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            // YES: thoát
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }

            // NO: xóa TextBox rồi thoát
            else if (result == DialogResult.No)
            {
                txtTen.Clear();
                txtSDT.Clear();

                e.Cancel = false;
            }

            // CANCEL: không thoát
            else
            {
                e.Cancel = true;
            }
        }

        // ==============================
        // KHI CHỌN LIÊN HỆ
        // ==============================
        private void lstLienHe_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                return;
            }

            string lienHe =
                lstLienHe.SelectedItem.ToString();

            int viTri = lienHe.LastIndexOf(" - ");

            if (viTri >= 0)
            {
                txtTen.Text =
                    lienHe.Substring(0, viTri);

                txtSDT.Text =
                    lienHe.Substring(viTri + 3);
            }
        }
    }
}
