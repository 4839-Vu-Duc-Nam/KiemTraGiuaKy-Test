using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test
{
    public partial class FormBaoCao : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=QLXetNghiem;Integrated Security=True";
        SqlConnection conn;

        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            LoadCongTy();
        }

        private void LoadCongTy()
        {
            string query = "SELECT MaCty, TenCty FROM CONGTY";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCongTy.DataSource = dt;
            cboCongTy.DisplayMember = "TenCty";
            cboCongTy.ValueMember = "MaCty";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboCongTy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn công ty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maCty = cboCongTy.SelectedValue.ToString();

            string query = @"
                SELECT n.ID, n.HoTen, n.SoLanXN,
                       CASE WHEN n.AmTinh = 1 THEN N'Âm Tính' ELSE N'Dương Tính' END AS KetQua
                FROM NHANVIEN n
                WHERE n.MaCty = @maCty";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maCty", maCty);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Công ty này chưa có nhân viên xét nghiệm!", "Thông báo");
                dataGridView1.DataSource = null;
                return;
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ID"].HeaderText = "CMND/CCCD";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
            dataGridView1.Columns["SoLanXN"].HeaderText = "Số lần xét nghiệm";
            dataGridView1.Columns["KetQua"].HeaderText = "Kết quả";
        }
    }
}
