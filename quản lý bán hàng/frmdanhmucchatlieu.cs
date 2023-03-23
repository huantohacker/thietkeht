using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using quản_lý_bán_hàng.Class;


namespace quản_lý_bán_hàng
{
    public partial class frmdanhmucchatlieu : Form
    {
        DataTable tblcl;
        public frmdanhmucchatlieu()
        {
            InitializeComponent();
        }

        private void frmdanhmucchatlieu_Load(object sender, EventArgs e)
        {
            txtmachatlieu.Enabled = false;
            btnluu.Enabled = false;
            loaddataGridView();
            
        }
        private void loaddataGridView()
        {
            string sql;
            sql = "SELECT Machatlieu, Tenchatlieu FROM tblchatlieu";
            tblcl = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvchatlieu.DataSource = tblcl; //Nguồn dữ liệu            
            dgvchatlieu.Columns[0].HeaderText = "Mã chất liệu";
            dgvchatlieu.Columns[1].HeaderText = "Tên chất liệu";
            dgvchatlieu.Columns[0].Width = 270;
            dgvchatlieu.Columns[1].Width = 270;
            dgvchatlieu.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvchatlieu.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
    }
}
