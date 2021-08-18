using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_UpdateSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayDanhMucSanPham();
            LayThongTinSanPham();
        }          
    }

    protected void LayDanhMucSanPham()
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.MoKetNoiCSDL();

        string sql = $"SELECT * FROM DanhMuc";

        DataTable dataTable = dataAccess.LayBangDuLieu(sql);

        // Thực hiện data binding
        this.lddDanhMuc.DataTextField = "Ten";
        this.lddDanhMuc.DataValueField = "Id";
        this.lddDanhMuc.DataSource = dataTable;
        this.lddDanhMuc.DataBind();

        dataAccess.DongKetNoi();
    }

    protected void LayThongTinSanPham()
    {
        DataAccess dataAccess = new DataAccess();
        dataAccess.MoKetNoiCSDL();

        // Lấy idSanPham từ Query String của URL
        string idSanPham = Request.QueryString.Get("idSanPham");

        if (idSanPham != null)
        {
            string sql = $"SELECT * FROM SanPham WHERE Id = {idSanPham}";

            DataTable dataTable = dataAccess.LayBangDuLieu(sql);

            DataRow dataRow = dataTable.Rows[0];

            // Gán dữ liệu vào các control
            tbTenSanPham.Text = dataRow["Ten"].ToString();
            lddDanhMuc.SelectedValue = dataRow["idDanhMuc"].ToString();
            tbGia.Text = dataRow["Gia"].ToString();
            tbMieuTa.Text = dataRow["MieuTa"].ToString();
        }

        dataAccess.DongKetNoi();
    }


    //xử lí xử kiện button Sữa
    protected void btSua_Click(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();

        dataAccess.MoKetNoiCSDL();

        // Lấy idSanPham từ Query String của URL
        string idSanPham = Request.QueryString.Get("idSanPham");

        string tenSanPham = tbTenSanPham.Text;
        int idDanhMuc = int.Parse(lddDanhMuc.SelectedValue);
        int giaSanPham = int.Parse(tbGia.Text);
        string hinhAnhSanPham = UpLoadHinhAnh();
        string mieuTaSanPham = tbMieuTa.Text;

        string sql = $@"
            UPDATE SanPham
            SET
	            Ten = N'{tenSanPham}',
	            IdDanhMuc = {idDanhMuc},
	            Gia = {giaSanPham},
	            HinhAnh = '{hinhAnhSanPham}',
	            MieuTa = N'{mieuTaSanPham}'
            WHERE Id = {idSanPham}";

        int soDongTacDong = dataAccess.ThucThiCauLenhSql(sql);

        if (soDongTacDong > 0)
        {
            XoaDuLieuCuaCacControl();
            ltThongBao.Text = "<p>Sửa sản phẩm thành công</p>";
        }
        else
        {
            ltThongBao.Text = "<p>Sửa sản phẩm không thành công</p>";
        }

        dataAccess.DongKetNoi();
    }

    protected string UpLoadHinhAnh()
    {
        if (fuHinhAnh.HasFile)
        {
            // Lấy đường dẫn thư mục hinhanh
            string thuMucHinhAnh = Server.MapPath("~/hinhanh/");

            // Tên file hình ảnh được upload
            string tenFileHinhAnhDuocUpload = fuHinhAnh.FileName;

            // Tên đường dẫn hình ảnh được lưu
            string duongDanHinhAnhDuocLuu = thuMucHinhAnh + tenFileHinhAnhDuocUpload;

            // Gọi phương thức SaveAs để lưu hình ảnh được upload lên vào thư mục hinhanh
            fuHinhAnh.SaveAs(duongDanHinhAnhDuocLuu);

            return tenFileHinhAnhDuocUpload;
        }
        else
        {
            return "";
        }
    }

    protected void XoaDuLieuCuaCacControl()
    {
        tbTenSanPham.Text = "";
        lddDanhMuc.ClearSelection();
        tbGia.Text = "";
        tbMieuTa.Text = "";
    }
}