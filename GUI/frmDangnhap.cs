using System;
using System.Linq;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ckb_hienpass_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu CheckBox được chọn
            if (ckb_hienpass.Checked)
            {
                txt_password.UseSystemPasswordChar = false; // Hiển thị mật khẩu
            }
            else
            {
                txt_password.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            BLL_SV bll_SV = new BLL_SV();
            // Kiểm tra thông tin đăng nhập
            if (bll_SV.BLL_SV_login(txt_username.Text, txt_password.Text))
            {
                // Chuyển sang form chính nếu đăng nhập thành công
                this.Hide(); // Ẩn form hiện tại
                frmHome homeForm = new frmHome();
                homeForm.Show(); // Hiện form chính
            }
            else
            {
                // Thông báo lỗi nếu đăng nhập không thành công
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmDangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
