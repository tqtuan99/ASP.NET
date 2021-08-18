using System;
using System.Collections.Generic;
using System.Data;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.KetNoiCSDL();

        string sql = "Select * From TinTuc";

        DataTable dataTable = dataAccess.LayBangDuLieu(sql);

        //thực hiện Data Binding
        this.rptTinTuc.DataSource = dataTable;
        this.rptTinTuc.DataBind();

        dataAccess.DongKetNoiCSDL();
    }
}