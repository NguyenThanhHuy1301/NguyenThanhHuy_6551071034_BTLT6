using System.Globalization;

namespace C5_cau3_NhapDiemHocSinh
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            DangKyEnterChuyenField();

            txtToan.Enter += txtDiem_Enter;
            txtVan.Enter += txtDiem_Enter;
            txtAnh.Enter += txtDiem_Enter;
        }
        private void DangKyEnterChuyenField()
        {
            foreach (Control control in GetAllControls(this))
            {
                if (control is TextBox txt)
                {
                    txt.KeyPress += TextBox_KeyPress;
                }
            }
        }

        // Lấy tất cả Control trên Form
        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;

                if (control.HasChildren)
                {
                    foreach (Control child in GetAllControls(control))
                    {
                        yield return child;
                    }
                }
            }
        }

        // Xử lý phím Enter
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                TextBox txt = (TextBox)sender;

                // Nếu đang ở ô Điểm Anh thì lưu
                if (txt == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl(
                        (Control)sender,
                        true,
                        true,
                        true,
                        true
                    );
                }
            }
        }

        // Khi focus vào ô điểm thì bôi xanh toàn bộ
        private void txtDiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

       

        
        

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            decimal diemToan;
            decimal diemVan;
            decimal diemAnh;

            bool hopLe = true;

            // Kiểm tra điểm Toán
            if (!decimal.TryParse(
                    txtToan.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out diemToan)
                || diemToan < 0
                || diemToan > 10)
            {
                errorProvider1.SetError(
                    txtToan,
                    "Điểm Toán phải từ 0.0 đến 10.0!"
                );

                hopLe = false;
            }

            // Kiểm tra điểm Văn
            if (!decimal.TryParse(
                    txtVan.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out diemVan)
                || diemVan < 0
                || diemVan > 10)
            {
                errorProvider1.SetError(
                    txtVan,
                    "Điểm Văn phải từ 0.0 đến 10.0!"
                );

                hopLe = false;
            }

            // Kiểm tra điểm Anh
            if (!decimal.TryParse(
                    txtAnh.Text.Trim(),
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out diemAnh)
                || diemAnh < 0
                || diemAnh > 10)
            {
                errorProvider1.SetError(
                    txtAnh,
                    "Điểm Anh phải từ 0.0 đến 10.0!"
                );

                hopLe = false;
            }

            // Nếu điểm không hợp lệ thì dừng
            if (!hopLe)
            {
                return;
            }

            // Thêm học sinh vào ListBox
            string dong =
                txtMaHS.Text.Trim() +
                " | " +
                txtHoTen.Text.Trim() +
                " | T:" +
                diemToan +
                " V:" +
                diemVan +
                " A:" +
                diemAnh;

            lstDanhSach.Items.Add(dong);

            // Xóa trắng Form
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            // Xóa thông báo lỗi
            errorProvider1.Clear();

            // Đưa focus về Mã học sinh
            txtMaHS.Focus();
        }

        private void btnXoaTrang_Click_1(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();

            txtMaHS.Focus();
        }
    }
}
