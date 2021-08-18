using System;
using System.Collections.Generic;
using System.Data;

public partial class TrangSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.MoKetNoiCSDL();

        string idSanPham = Request.QueryString.Get("idSanPham");
        if (idSanPham != null)
        {
            string sql = $"Select * From SanPham where Id ={idSanPham}";

            DataTable dataTable = dataAccess.LayBangDuLieu(sql);

            ltTenSP.Text = dataTable.Rows[0]["Ten"].ToString();
            imgSP.ImageUrl = "hinhanh/" + dataTable.Rows[0]["HinhAnh"].ToString();
            ltgiaSP.Text = dataTable.Rows[0]["Gia"].ToString();
            ltMieuTaSP.Text = dataTable.Rows[0]["MieuTa"].ToString();
          
        }
        dataAccess.DongKetNoi();
    }
}