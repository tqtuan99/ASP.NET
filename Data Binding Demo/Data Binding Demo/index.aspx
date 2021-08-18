<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<html>
<head runat="server">
    <title>Trang Tin Tức Công Nghêk</title>

    <style>
        body {
            margin: 0px;
        }

        .header {
            background-color: forestgreen;
            color: white;
            font-size: 30px;
            font-weight: bold;
            padding-top:10px;
            padding-bottom:15px;
            text-align:center;
        }

        .main {
            min-height: 100%;
            padding: 20px;
        }

        .content {
            /*chiều rộng của nội dung */
            max-width: 800px;
            /* làm thể div canh giữa*/
            margin-right: auto;
            margin-left: auto;
        }

        .tintuc {
            display: flex;
            border-bottom-style: solid;
            border-bottom-width: 1px;
            border-bottom-color: dimgray;
            padding-bottom: 20px;
            padding-top:10px;
        }

        .tintuc .hinhanh {
                width: 25%;
                margin-right: 10px;
            }

        .tintuc .hinhanh img {
                    width: 100%;
                }

        .tintuc .noidung {
                width: 75%;
            }

        .tintuc .noidung .tieude {
                    margin-top: 0px;
                    font-size: 20px;
                    font-weight: bold;
            }

        .tieude .noidung .tomtat {
        }

        .footer {
            background-color: dimgray;
            font-size: 14px;
            font-weight: bold;
            text-align: center;
            padding: 5px;
            margin-top:20px;
        }
    </style>
</head>
<body>
    <!-- Header -->
    <div class="header">

        <img style="width: 10%;" src="hinhanh/newfast.jpg" />
        <hr />
        Tin Tức Công Nghê Mới Nhất
        
    </div>

    <!-- Main -->
    <div class="main">

        <!-- Content -->
        <div class="content">

            <asp:Repeater ID="rptTinTuc" runat="server">
                <ItemTemplate>
                    <!-- Tin Tức -->
                    <div class="tintuc">

                        <!-- Hình Ảnh -->
                        <div class="hinhanh">
                            <img src="hinhanh/<%# Eval("HinhAnh") %>" />
                        </div>

                        <!-- Nội Dung -->
                        <div class="noidung">

                            <!-- Tiêu Đề -->
                            <p class="tieude">
                                <%# Eval("TieuDe") %>
                            </p>

                            <!-- Tóm Tắt -->
                            <p class="tomtat">
                                <%# Eval("TomTat") %>
                            </p>

                        </div>

                    </div>
                </ItemTemplate>
            </asp:Repeater>



            <%--<!-- Tin Tức -->
            <div class="tintuc">

                <!-- Hình Ảnh -->
                <div class="hinhanh">
                    <img src="hinhanh/new1.jpg" />
                </div>

                <!-- Nội Dung -->
                <div class="noidung">

                    <!-- Tiêu Đề -->
                    <p class="tieude">
                        iPhone 12 là smartphone bán chạy nhất thế giới
                    </p>

                    <!-- Tóm Tắt -->
                    <p class="tomtat">
                        Cứ 100 smartphone được bán ra trong quý I/2021, có 5 chiếc là iPhone 12, 4 chiếc iPhone 12 Pro Max. Số liệu thống kê vừa được công bố của Counterpoint Research cho thấy, iPhone 12 chiếm 5% tổng lượng smartphone bán ra trên toàn cầu trong quý I/2021, trở thành mẫu máy bán chạy nhất quý.
                    </p>

                </div>

            </div>--%>
        </div>

    </div>

    <!-- Footer -->
    <div class="footer">
        &copy Copyright by Tech News
    </div>

</body>
</html>
