using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Demo
{
    class Program
    {
        static void HienThiDanhSach()
        {
            DataAccess dataAccess = new DataAccess();
            DataTable dataTable;
            string sql = "Select * From SanPham";

            dataAccess.KetNoiCSDL();
            dataTable = dataAccess.LayBangDate(sql);

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("ID Sản Phẩm: {0}", row["Id"]);
                Console.WriteLine("Tên Sản Phẩm: {0}", row["Ten"]);
                Console.WriteLine("Gia Sản Phẩm: {0}", row["Gia"]);
                Console.WriteLine("Hình Sản Phẩm: {0}", row["HinhAnh"]);
                Console.WriteLine("MieuTa Sản Phẩm: {0}", row["MieuTa"]);
                Console.WriteLine("==================================");
                Console.WriteLine();
            }

            dataAccess.DongKetNoiCSDL();
        }
        static void HienThiTheoID()
        {
            Console.Write("Bạn Hãy Nhập ID Sản Phẩm: ");
            string IdSP = Console.ReadLine();

            DataAccess dataAccess = new DataAccess();
            DataTable dataTable;
            string sql = $"Select * from SanPham Where Id = {IdSP}";

            dataAccess.KetNoiCSDL();
            dataTable = dataAccess.LayBangDate(sql);

            if (dataTable.Rows.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("ID: {0}", dataTable.Rows[0]["Id"]);
                Console.WriteLine("Ten: {0}", dataTable.Rows[0]["Ten"]);
                Console.WriteLine("Gia: {0}", dataTable.Rows[0]["Gia"]);
                Console.WriteLine("Hình Ảnh: {0}", dataTable.Rows[0]["HinhAnh"]);
                Console.WriteLine("Miêu Tả: {0}", dataTable.Rows[0]["MieuTa"]);
            }
            else
            {
                Console.WriteLine("Không Có Sản Phẩm Này!");
            }

            dataAccess.DongKetNoiCSDL();
        }

        static void ThemSanPham()
        {
            Console.WriteLine("Bạn hãy nhập thông tin sản phẩm! ");

            Console.Write("Tên sản phẩm: ");
            string tenSanPham = Console.ReadLine();

            Console.Write("Giá sản phẩm: ");
            int giaSanPham = int.Parse(Console.ReadLine());

            Console.Write("Hình ảnh sản phẩm: ");
            string hinhAnhSanPham = Console.ReadLine();

            Console.Write("Miêu tả sản phẩm: ");
            string mieuTaSanPham = Console.ReadLine();

            DataAccess dataAccess = new DataAccess();

            dataAccess.KetNoiCSDL();

            string sql = $@"
                INSERT INTO SanPham
                Values (
                N'{tenSanPham}',
                {giaSanPham},
                '{hinhAnhSanPham}',
                N'{mieuTaSanPham}'
            )";

            int soDongTacDon = dataAccess.ThucThiCauLenh(sql);
            if (soDongTacDon > 0)
            {
                Console.WriteLine("\nThêm sản phẩm thành công");
            }
            else
            {
                Console.WriteLine("\nThêm sản phẩm thất bại");
            }

            dataAccess.DongKetNoiCSDL();
        }

        static void SuaSanPham()
        {
            Console.WriteLine("Hãy Nhập thông tin sản phẩm: ");

            Console.Write("ID sản phẩm: ");
            int idSanPham = int.Parse(Console.ReadLine());

            Console.Write("Tên sản phẩm: ");
            string tenSanPham = Console.ReadLine();

            Console.Write("Giá sản phẩm: ");
            int giaSanPham = int.Parse(Console.ReadLine());

            Console.Write("Hình ảnh sản phẩm: ");
            string haSanPham = Console.ReadLine();

            Console.Write("Miêu tả sản phẩm: ");
            string mieutaSanPham = Console.ReadLine();

            DataAccess dataAccess = new DataAccess();
            dataAccess.KetNoiCSDL();

            string sql = $@"
                update SanPham
                set
                    Ten = N'{tenSanPham} ', 
                    Gia = {giaSanPham},
                    HinhAnh = '{haSanPham}',
                    MieuTa = N'{mieutaSanPham}'
                where Id = {idSanPham}";

            int soDongTacDong = dataAccess.ThucThiCauLenh(sql);

            if (soDongTacDong > 0)
            {
                Console.WriteLine("\nCập nhật thành công!");
            }
            else
            {
                Console.WriteLine("\nCập nhật thất bại.");
            }

            dataAccess.DongKetNoiCSDL();
        }

        static void XoaSanPham()
        {
            Console.WriteLine("Hãy nhập thông tin sản phẩm cần xóa: ");

            Console.Write("ID Sản phẩm: ");
            int idSanPham = int.Parse(Console.ReadLine());

            DataAccess dataAccess = new DataAccess();

            dataAccess.KetNoiCSDL();

            string sql = $@"
                Delete From SanPham
                Where Id = {idSanPham}       
                ";

            int soDongTacDong = dataAccess.ThucThiCauLenh(sql);

            if (soDongTacDong > 0)
            {
                Console.WriteLine("\nXóa sản phẩm thành công! ");
            }
            else
            {
                Console.WriteLine("\nXóa sản phẩm thấp bại.");
            }

            dataAccess.DongKetNoiCSDL();
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.WriteLine("____________________WELCOME____________________");
                Console.WriteLine("Bạn Hãy Chọn Chức Năng!");
                Console.WriteLine("1. Hiển Thị Danh Sách Sản Phẩm");
                Console.WriteLine("2. Hiện Thị Một Sản Phẩm Theo ID");
                Console.WriteLine("3. Thêm Sản Phẩm");
                Console.WriteLine("4. Cập Nhật Sản phẩm");
                Console.WriteLine("5. Xóa Sản phẩm\n");
                Console.Write("Bạn chọn ==> ");

                string chucNang = Console.ReadLine();

                Console.WriteLine();

                switch (chucNang)
                {
                    case "1":
                        HienThiDanhSach();
                        break;

                    case "2":
                        HienThiTheoID();
                        break;

                    case "3":
                        ThemSanPham();
                        break;

                    case "4":
                        SuaSanPham();
                        break;

                    case "5":
                        XoaSanPham();
                        break;
                }

                Console.Write("\nNhấn ESC để thoát, nhấn phím bất kỳ để tiếp tục!\n");
                if (Console.ReadKey().Key == ConsoleKey.Escape) break;
            }

            Console.ReadKey();
        }
    }
}
