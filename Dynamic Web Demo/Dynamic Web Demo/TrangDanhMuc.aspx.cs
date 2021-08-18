using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TrangDanhMuc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.MoKetNoiCSDL();

        //Lay idDanhMuc tu Query của URL
        string IdDanhMuc = Request.QueryString.Get("idDanhMuc");
        string sql;
        if (IdDanhMuc == null)
        {
            sql = "Select *from SanPham";
        }
        else
        {
            sql = $"Select * from SanPham where IdDanhMuc={IdDanhMuc}";
        }
        DataTable dataTable = dataAccess.LayBangDuLieu(sql);

        this.rptDanhSachSP.DataSource = dataTable;
        this.rptDanhSachSP.DataBind();

        dataAccess.DongKetNoi();
    }
}