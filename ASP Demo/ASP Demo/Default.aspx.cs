using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ltMessage.Text = "Xin Chào Bạn " + tbHoTen.Text;

    }

    protected void btnTong_Click(object sender, EventArgs e)
    {
        double tong,soA, soB;

        soA = double.Parse(tbSoA.Text);
        soB = double.Parse(tbSoB.Text);

        tong = soA + soB;

        ltTong.Text = tong +"";
    }
}