<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello ASP.NET

            <br />
            <br />

            <!-- Xử lý sự kiện -->

            <p style="font-weight:bold"> </p>

            Họ Tên:
            <asp:TextBox ID="tbHoTen" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

            <br />
            <br />
            <asp:Literal ID="ltMessage" runat="server"></asp:Literal>


            <br />
            <hr />

            <p style="font-weight:bot">Tính Tổng Hai Số</p>

            Số A:
            <asp:TextBox ID="tbSoA" runat="server"></asp:TextBox>

            <br />
            <br />

            Số B:
            <asp:TextBox ID="tbSoB" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnTong" runat="server" Text="Tính Tổng" OnClick="btnTong_Click" />

            <br />
            <br />


            Tổng:
            <asp:Literal ID="ltTong" runat="server"></asp:Literal>

        </div>
    </form>
</body>
</html>
