<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="UpdateSanPham.aspx.cs" Inherits="Admin_UpdateSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title> Sữa Sản Phẩm </title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="frmSuaSanPham" runat ="server">
        <div>
            <p style="font-weight: bold"> Hình Ảnh: </p>
            <asp:FileUpload ID="fuHinhAnh" runat="server" />
        </div>
        
        <div>
            <p style="font-weight:bold"> Tên Sản Phẩm: </p>
            <asp:TextBox ID="tbTenSanPham" runat="server" style ="width: 500px"></asp:TextBox>
        </div>

        <div>
            <p style="font-weight: bold">Danh mục sản phẩm:</p>
            <asp:DropDownList ID="lddDanhMuc" runat="server" style="width: 200px">
            </asp:DropDownList>
        </div>

        <div>
            <p style="font-weight: bold">Giá: </p>
            <asp:TextBox ID="tbGia" runat="server" style="width: 200px"></asp:TextBox>
        </div>

        <div>
            <p style="font-weight: bold">Miêu tả:</p>
            <asp:TextBox ID="tbMieuTa" runat="server" TextMode="MultiLine" Rows="10" Columns="65"></asp:TextBox>
        </div>

        <div style="margin-top: 20px">
             <asp:Literal ID="ltThongBao" runat="server"></asp:Literal>
            <asp:Button ID="btThem" runat="server" Text="Update" OnClick="btSua_Click" />
        </div>

    </form>
</asp:Content>

