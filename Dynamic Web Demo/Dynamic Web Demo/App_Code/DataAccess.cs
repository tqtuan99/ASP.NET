using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Khai Bao Lop DataAccess
/// </summary>
public class DataAccess
{
    SqlConnection connection;

    //Mở kết nối đến CSDL
    public void MoKetNoiCSDL()
    {
        connection = new SqlConnection();

        //Set connection string
        connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Dynamic Web Demo\Dynamic Web Demo\App_Data\Database.mdf;Integrated Security=True";
        connection.Open();
    }                   

    public DataTable LayBangDuLieu(string sql)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(sql, this.connection);
        DataTable dataTable = new DataTable();

        // Thực thi câu lệnh sql, điền dữ liệu vào dataTable
        adapter.Fill(dataTable);

        return dataTable;
    }

    public int ThucThiCauLenhSql(string sql)
    {
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = this.connection;
        cmd.CommandText = sql;

        // Thực thi câu lệnh sql, trả về số dòng tác động
        return cmd.ExecuteNonQuery();
    }

    public void DongKetNoi()
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}