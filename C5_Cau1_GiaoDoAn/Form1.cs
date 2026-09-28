using System.Text.RegularExpressions;

namespace C5_Cau1_GiaoDoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMK_TextChanged(object sender, EventArgs e)
        {

        }
        private bool KiemTraHoTen()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên không được để trống."
                );

                return false;
            }

            if (txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(
                    txtHoTen,
                    "Họ tên phải có ít nhất 3 ký tự."
                );

                return false;
            }

            errorProvider1.SetError(txtHoTen, "");

            return true;
        }
        private bool KiemTraSDT()
        {
            if (!Regex.IsMatch(txtSDT.Text, @"^0\d{9}$"))
            {
                errorProvider1.SetError(
                    txtSDT,
                    "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng 0."
                );

                return false;
            }

            errorProvider1.SetError(txtSDT, "");

            return true;
        }
        private bool KiemTraEmail()
        {
            string email = txtEmail.Text.Trim();

            int viTriA = email.IndexOf('@');

            if (viTriA == -1 ||
                email.IndexOf('.', viTriA + 1) == -1)
            {
                errorProvider1.SetError(
                    txtEmail,
                    "Email phải chứa '@' và có '.' phía sau '@'."
                );

                return false;
            }

            errorProvider1.SetError(txtEmail, "");

            return true;
        }
        private bool KiemTraMatKhau()
        {
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(
                    txtMatKhau,
                    "Mật khẩu phải có ít nhất 6 ký tự."
                );

                return false;
            }

            errorProvider1.SetError(txtMatKhau, "");

            return true;
        }
        private bool KiemTraXacNhanMatKhau()
        {
            if (txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMK,
                    "Mật khẩu xác nhận không khớp."
                );

                return false;
            }

            errorProvider1.SetError(txtXacNhanMK, "");

            return true;
        }
        private bool KiemTraHopLe()
        {
            errorProvider1.Clear();

            bool hopLe = true;

            if (!KiemTraHoTen())
            {
                hopLe = false;
            }

            if (!KiemTraSDT())
            {
                hopLe = false;
            }

            if (!KiemTraEmail())
            {
                hopLe = false;
            }

            if (!KiemTraMatKhau())
            {
                hopLe = false;
            }

            if (!KiemTraXacNhanMatKhau())
            {
                hopLe = false;
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;

            errorProvider1.Clear();

            this.Close();
        }
    }
}
