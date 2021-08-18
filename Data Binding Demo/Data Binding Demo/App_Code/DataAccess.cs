using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class DataAccess
{
    SqlConnection connection;

    //kết nối đến CSDL
    public void KetNoiCSDL()
    {
        connection = new SqlConnection();

        connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ASUS\source\repos\Data Binding Demo\Data Binding Demo\App_Data\Database.mdf"";Integrated Security=True";

        connection.Open();
    }

    public DataTable LayBangDuLieu(string sql)
    {
        SqlDataAdapter adapter = new SqlDataAdapter(sql, this.connection);

        DataTable dataTable = new DataTable();

        adapter.Fill(dataTable);
        return dataTable;

    }

    public void DongKetNoiCSDL()
    {
        if(connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }


}