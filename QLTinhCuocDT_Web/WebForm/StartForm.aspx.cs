using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StartFrom : System.Web.UI.Page
{
    QLTinhCuocDTEntities qLTinhCuocDT = new QLTinhCuocDTEntities();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCheckPhoneNumber_Click(object sender, EventArgs e)
    {
        string phoneNumber = txtPhoneNumber.Text;
        ThongTinSIM tts = qLTinhCuocDT.ThongTinSIMs.Where(x => x.IDSIM == phoneNumber).SingleOrDefault();
        if(tts == null)
        {
            lblNotify.Text = "Phone number not exist. Please try again!";
        }
        else
        {
            KhachHang kh = qLTinhCuocDT.KhachHangs.Where(k => k.MaKH == tts.MaKH).SingleOrDefault();
            Session["IDSIM"] = phoneNumber;
            Session["NAMECUSTOMER"] = kh.TenKH;
            Server.Transfer("MainForm.aspx");
        }
    }
}