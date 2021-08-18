using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DanhSachSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.MoKetNoiCSDL();

        string sql = $@"
            SELECT SanPham.*, DanhMuc.Ten AS TenDanhMuc
            FROM SanPham
            INNER JOIN DanhMuc
            ON SanPham.IdDanhMuc = DanhMuc.Id";

        DataTable dataTable = dataAccess.LayBangDuLieu(sql);

        // Thực hiện data binding
        this.rptDanhSachSanPham.DataSource = dataTable;
        this.rptDanhSachSanPham.DataBind();

        dataAccess.DongKetNoi();
    }
}