<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TrangDanhMuc.aspx.cs" Inherits="TrangDanhMuc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <title>
        Trang danh mục sản phẩm
    </title>

    <style>
        .page-title{
            color:green;
            font-size:30px;
            font-weight:bold;
            text-align:center;
            padding:15px;
                
        }
        .danh-sach-san-pham{
            display:flex;
            flex-wrap:wrap;
        }
        .sanpham{
            width:24%;
            margin-bottom: 30px;
            background-color:white;
            margin-right:11px;
        }
        .thong-tin-san-pham{
            
            padding:10px;
        }
        .hinh-anh-san-pham{
            margin-bottom:10px;
            text-align:center
        }
        .hinh-anh-san-pham img{
            width:80%;
        }
        .ten-san-pham{
            text-align:center;
            font-size:15px;
            
        }
        .gia-san-pham{
            text-align:center;
            font-size:15px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!--Tiêu đề sản phẩm-->
    <p class="page-title">
        Danh Sách Sản Phẩm
    </p>
    <!--Danh sách sản phẩm-->
    <div class="danh-sach-san-pham">

        <asp:Repeater ID="rptDanhSachSP" runat="server">
            <ItemTemplate>
                <div class="sanpham">
            
                <div class="thong-tin-san-pham">

                    <!--Hình ảnh sản phẩm-->
                    <div class="hinh-anh-san-pham">
                        <img src="hinhanh/<%# Eval("HinhAnh") %>" />
                    </div>

                    <!--Tên sản phẩm-->
                    <p class="ten-san-pham">
                        <a href="TrangSanPham.aspx?idSanPham=<%# Eval("Id") %>">
                            <%# Eval("Ten") %>
                        </a>
                    </p>

                    <!--Giá sản phẩm-->
                    <p class="gia-san-pham">
                        <b>Giá:</b> <%# Eval("Gia") %>
                    </p>
            </div>

        </div>
            </ItemTemplate>
        </asp:Repeater>       

    </div>

</asp:Content>

