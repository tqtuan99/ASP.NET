using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddSanPham : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayDanhMucSanPham();
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

    protected void btThem_Click(object sender, EventArgs e)
    {
        DataAccess dataAccess = new DataAccess();

        dataAccess.MoKetNoiCSDL();

        string tenSanPham = tbTenSanPham.Text;
        int idDanhMuc = int.Parse(lddDanhMuc.SelectedValue);
        int giaSanPham = int.Parse(tbGia.Text);
        string hinhAnhSanPham = UpLoadHinhAnh();
        string mieuTaSanPham = tbMieuTa.Text;

        string sql = $@"
            INSERT INTO SanPham
            VALUES(N'{tenSanPham}', {idDanhMuc}, {giaSanPham}, '{hinhAnhSanPham}', N'{mieuTaSanPham}')";

        int soDongTacDong = dataAccess.ThucThiCauLenhSql(sql);

        if (soDongTacDong > 0)
        {
            XoaDuLieuCuaCacControl();
            ltThongBao.Text = "<p>Thêm sản phẩm thành công</p>";
        }
        else
        {
            ltThongBao.Text = "<p>Thêm sản phẩm không thành công</p>";
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