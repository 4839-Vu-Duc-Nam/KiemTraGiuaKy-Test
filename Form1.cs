using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QLXetNghiem;Integrated Security=True";
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            groupThongTinXN.Enabled = false;

            LoadNhanVien();
            LoadCongTy();
        }

        // ======== LOAD NHÂN VIÊN ==========
        private void LoadNhanVien()
        {
            string query = "SELECT ID, HoTen, SoLanXN, AmTinh FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Columns.Add("KetQua", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                bool amTinh = Convert.ToBoolean(row["AmTinh"]);
                row["KetQua"] = amTinh ? "Âm Tính" : "+";
            }

            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns.Contains("AmTinh"))
                dataGridView1.Columns["AmTinh"].Visible = false;

            dataGridView1.Columns["ID"].HeaderText = "CMND/CCCD";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ và Tên";
            dataGridView1.Columns["SoLanXN"].HeaderText = "Số lần XN";
            dataGridView1.Columns["KetQua"].HeaderText = "Kết Quả";
        }

        // ======== LOAD CÔNG TY ==========
        private void LoadCongTy()
        {
            string query = "SELECT MaCty, TenCty FROM CONGTY";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCongTy.DataSource = dt;
            cboCongTy.DisplayMember = "TenCty";
            cboCongTy.ValueMember = "MaCty";
            cboCongTy.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // ======== BUTTON TÌM ==========
        private void btnTim_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();

            // 1️⃣ Kiểm tra có nhập hay chưa
            if (string.IsNullOrWhiteSpace(cccd))
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Kiểm tra phải là số [0-9]
            if (!System.Text.RegularExpressions.Regex.IsMatch(cccd, @"^\d+$"))
            {
                MessageBox.Show("ID chỉ là các ký tự số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3️⃣ Kiểm tra độ dài phải là 9 hoặc 12 ký tự
            if (cccd.Length != 9 && cccd.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND hợp lệ (9 hoặc 12 ký tự)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3️⃣ Kiểm tra trong CSDL
            string query = "SELECT * FROM NHANVIEN WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cccd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            groupThongTinXN.Enabled = true;

            if (dt.Rows.Count == 0)
            {
                // 4️⃣ Không tồn tại
                txtHoTen.Text = "";
                txtSoLanXN.Text = "1";
                txtSoLanXN.ReadOnly = true;
                rdoAmTinh.Checked = true;
                cboCongTy.SelectedIndex = 0;

                MessageBox.Show("ID chưa tồn tại trong CSDL. Vui lòng nhập thông tin mới!", "Thông báo");
            }
            else
            {
                // 5️⃣ Có tồn tại
                DataRow row = dt.Rows[0];
                txtHoTen.Text = row["HoTen"].ToString();

                int lanXN = Convert.ToInt32(row["SoLanXN"]) + 1;
                txtSoLanXN.Text = lanXN.ToString();
                txtSoLanXN.ReadOnly = true;

                bool amTinh = Convert.ToBoolean(row["AmTinh"]);
                rdoAmTinh.Checked = amTinh;
                rdoDuongTinh.Checked = !amTinh;

                cboCongTy.SelectedValue = row["MaCty"].ToString();

                MessageBox.Show("Đã tìm thấy nhân viên trong CSDL!", "Thông báo");
            }
        }

        // ======== BUTTON CẬP NHẬT ==========
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (string.IsNullOrWhiteSpace(cccd))
            {
                MessageBox.Show("Vui lòng nhập CCCD/CMND trước khi cập nhật!", "Thông báo");
                return;
            }

            bool amTinh = rdoAmTinh.Checked;
            int lanXN = int.Parse(txtSoLanXN.Text);
            string hoTen = txtHoTen.Text.Trim();
            string maCty = cboCongTy.SelectedValue.ToString();

            // Kiểm tra xem ID có trong CSDL chưa
            string checkQuery = "SELECT COUNT(*) FROM NHANVIEN WHERE ID = @id";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@id", cccd);

            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                // 🟢 Thêm mới nhân viên
                string insert = "INSERT INTO NHANVIEN (ID, HoTen, SoLanXN, AmTinh, MaCty) VALUES (@id, @hoten, @lan, @amTinh, @maCty)";
                SqlCommand insertCmd = new SqlCommand(insert, conn);
                insertCmd.Parameters.AddWithValue("@id", cccd);
                insertCmd.Parameters.AddWithValue("@hoten", hoTen);
                insertCmd.Parameters.AddWithValue("@lan", lanXN);
                insertCmd.Parameters.AddWithValue("@amTinh", amTinh);
                insertCmd.Parameters.AddWithValue("@maCty", maCty);
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Thêm mới thành công!", "Thông báo");
            }
            else
            {
                // 🟡 Cập nhật nhân viên
                string update = "UPDATE NHANVIEN SET HoTen=@hoten, SoLanXN=@lan, AmTinh=@amTinh, MaCty=@maCty WHERE ID=@id";
                SqlCommand updateCmd = new SqlCommand(update, conn);
                updateCmd.Parameters.AddWithValue("@hoten", hoTen);
                updateCmd.Parameters.AddWithValue("@lan", lanXN);
                updateCmd.Parameters.AddWithValue("@amTinh", amTinh);
                updateCmd.Parameters.AddWithValue("@maCty", maCty);
                updateCmd.Parameters.AddWithValue("@id", cccd);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }

            conn.Close();

            // 🟢 Làm mới DataGridView
            LoadNhanVien();

            // 🟢 Reset Form về mặc định
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtSoLanXN.Clear();
            rdoAmTinh.Checked = true;
            rdoDuongTinh.Checked = false;
            cboCongTy.SelectedIndex = 0;
            groupThongTinXN.Enabled = false;
        }

        // ======== MENU: NV DƯƠNG TÍNH ==========
        // ======== MENU: NHÂN VIÊN DƯƠNG TÍNH (F1) ==========
        private void mnuNVDuongTinh_Click(object sender, EventArgs e)
        {
            string query = "SELECT ID, HoTen, SoLanXN, AmTinh FROM NHANVIEN WHERE AmTinh = 0";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Columns.Add("KetQua", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["KetQua"] = "+";
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["AmTinh"].Visible = false;
            dataGridView1.Columns["ID"].HeaderText = "CMND/CCCD";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ và Tên";
            dataGridView1.Columns["SoLanXN"].HeaderText = "Số lần XN";
            dataGridView1.Columns["KetQua"].HeaderText = "Kết Quả";

            MessageBox.Show("Hiển thị danh sách nhân viên DƯƠNG TÍNH!", "Thông báo");
        }


        // ======== MENU: CÔNG TY ĐÃ TEST ĐỦ THEO YÊU CẦU (F2) ==========
        private void mnuCtyDaTest_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT c.MaCty, c.TenCty, c.SLNV AS SLNV_YeuCau, COUNT(n.ID) AS SLNV_DaTest
        FROM CONGTY c
        LEFT JOIN NHANVIEN n ON c.MaCty = n.MaCty
        GROUP BY c.MaCty, c.TenCty, c.SLNV
        HAVING COUNT(n.ID) >= c.SLNV";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có công ty nào test đủ theo yêu cầu!", "Thông báo");
                return;
            }

            // Tạo danh sách công ty test đủ
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Danh sách công ty đã test đủ theo yêu cầu:\n");

            int stt = 1;
            foreach (DataRow row in dt.Rows)
            {
                sb.AppendLine($"{stt}. {row["TenCty"]}");
                stt++;
            }

            MessageBox.Show(sb.ToString(), "Danh sách công ty test đủ");
        }


        private void mnuXuatBaoCao_Click(object sender, EventArgs e)
        {
            FormBaoCao frm = new FormBaoCao();
            frm.ShowDialog();
        }


        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}