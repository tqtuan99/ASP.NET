<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TrangSanPham.aspx.cs" Inherits="TrangSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <title>
        Trang chi tiết sản phẩm
    </title>
    <style>
        .ten-san-pham{
            color:green;
            font-size:25px;
            font-weight:bold;
            text-align:center;
        }
        .hinh-anh-san-pham {
            text-align:center
        }
        .hinh-anh-san-pham img{
            width:350px;
        }
        .gia-san-pham{
            font-size:20px;
        }     
        .gia-tri-san-pham{
            color:red;
        }
        .mieu-ta-san-pham{
            font-size:20px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <!--Tên sản phẩm-->
    <p class="ten-san-pham">
        <asp:Literal ID="ltTenSP" runat="server"></asp:Literal>
    </p>

    <!--Hình ảnh sản phẩm-->
    <div class="hinh-anh-san-pham">
        <asp:Image ID="imgSP" runat="server" ></asp:Image>
    </div>

    <!--Giá sản phẩm-->
    <p class="gia-san-pham">
        <b>Giá: </b>
        <span style="color:red">
            <asp:Literal ID="ltgiaSP" runat="server"></asp:Literal>
        </span> 
    </p>


    <!--Miêu tả sản phẩm-->
     <p class="mieu-ta-san-pham">
         <asp:Literal ID="ltMieuTaSP" runat="server"></asp:Literal>đ
     </p>   

</asp:Content>

