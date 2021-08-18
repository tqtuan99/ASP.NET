using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace ADO_Demo
{
    class DataAccess
    {
        private SqlConnection connection;

        public void KetNoiCSDL()
        {
            connection = new SqlConnection();          
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\source\repos\ADO Demo Phần 2\ADO Demo\Database.mdf"";Integrated Security=True";

            connection.Open();

        }

        public DataTable LayBangDate(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, this.connection);
            DataTable dateTable = new DataTable();


            //Thực thi câu lệnh SQL, điền dữ liệu vào DataTable
            adapter.Fill(dateTable);

            return dateTable;
        }

        public int ThucThiCauLenh(string sql)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = this.connection;
            cmd.CommandText = sql;

            //Thực thi câu lệnh sql, trả về số dòng tác động
            return cmd.ExecuteNonQuery();
        }


        public void DongKetNoiCSDL()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
