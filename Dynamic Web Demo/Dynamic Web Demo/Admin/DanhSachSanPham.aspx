<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="DanhSachSanPham.aspx.cs" Inherits="Admin_DanhSachSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <title>Danh sách sản phẩm</title>
    <style>
        .tieu-de-trang {
            color: green;
            font-size: 30px;
            font-weight: bold;
            text-align:center;
        }

        .danh-sach-san-pham {
            border-collapse: collapse;
            width: 100%;
            font-size: 13px;
        }

        .danh-sach-san-pham th {
            border: 1px solid black;
            background-color: cornflowerblue;
            text-align: left;
            padding: 8px;
        }

        .danh-sach-san-pham td {
            border: 1px solid black;
            text-align: left;
            padding: 8px;
        }

        .danh-sach-san-pham tr:nth-child(even) {
            background-color: lightblue;
        }

        .danh-sach-san-pham tr:nth-child(odd) {
            background-color: azure;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Tên sản phẩm -->
    <p class="tieu-de-trang">
        Danh Sách Sản Phẩm
    </p>

    <table class="danh-sach-san-pham">
        <tr>
            <th>Hình ảnh</th>
            <th>Tên sản phẩm</th>
            <th>Danh mục</th>
            <th>Giá</th>
            <th>Chức năng</th>
        </tr>
        <asp:Repeater ID="rptDanhSachSanPham" runat="server">
            <ItemTemplate>
                <tr>
                    <td style="width: 60px; text-align: center">
                        <img src="../hinhanh/<%# Eval("HinhAnh") %>" style="width: 50px" />
                    </td>
                    <td><%# Eval("Ten") %></td>
                    <td><%# Eval("TenDanhMuc") %></td>
                    <td><%# Eval("Gia") %></td>
                    <td style="width: 70px; text-align: center">

                    <a href="UpdateSanPham.aspx?idSanPham=<%# Eval("Id") %>">Sửa</a>
                        |
                    <a href="#">Xóa</a>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

    <p style="font-size:20px;">
        <a href="AddSanPham.aspx"> Thêm sản phẩm</a>
    </p>
</asp:Content>

