using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace quản_lý_bán_hàng.Class
{
    internal class Functions
    {
        public static SqlConnection con;
        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"F:\\c Sharp\\quản lý bán hàng\\quản lý bán hàng\\quanlybanhang.mdf\";Integrated Security=True;Connect Timeout=30";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                // MessageBox.Show("ket noi thanh cong");
            }
            else
            {
                // MessageBox.Show("ket noi that bai");
            }
        }
        // tao phuong thuc disconnect
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        // phuong thuc thuc thi cau lenh lay select lay du lieu
        public static DataTable GetDataToTable(string sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;

        }
    }
}
