<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddSanPham.aspx.cs" Inherits="Admin_AddSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <title>Thêm sản phẩm</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="frmThemSanPham" runat="server">
        <div>
            <p style="font-weight: bold">Hình ảnh:</p>
            <asp:FileUpload ID="fuHinhAnh" runat="server" />
        </div>
        <div>
            <p style="font-weight: bold">Tên sản phẩm:</p>
            <asp:TextBox ID="tbTenSanPham" runat="server" style="width: 500px"></asp:TextBox>
        </div>
        <div>
            <p style="font-weight: bold">Danh mục sản phẩm:</p>
            <asp:DropDownList ID="lddDanhMuc" runat="server" style="width: 200px">
            </asp:DropDownList>
        </div>
        <div>
            <p style="font-weight: bold">Giá:</p>
            <asp:TextBox ID="tbGia" runat="server" style="width: 200px"></asp:TextBox>
        </div>
        <div>
            <p style="font-weight: bold">Miêu tả:</p>
            <asp:TextBox ID="tbMieuTa" runat="server" TextMode="MultiLine" Rows="10" Columns="65"></asp:TextBox>
        </div>
        <div style="margin-top: 20px">
            <asp:Literal ID="ltThongBao" runat="server"></asp:Literal>
            <asp:Button ID="btThem" runat="server" Text="Thêm" OnClick="btThem_Click" />
        </div>
    </form>

</asp:Content>

