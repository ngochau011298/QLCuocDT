using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public partial class testCalender : System.Web.UI.Page
{
    QLTinhCuocDTEntities qLTinhCuocDT = new QLTinhCuocDTEntities();
    private string idPhoneNumber = "";
    private string nameCustomer = "";
    List<ChiTietSuDung> listDetail;

    #region Envent
    protected void Page_Load(object sender, EventArgs e)
    {
        idPhoneNumber = (string)Session["IDSIM"];
        nameCustomer = (string)Session["NAMECUSTOMER"];
        listDetail = qLTinhCuocDT.ChiTietSuDungs.Where(x => x.IDSIM == idPhoneNumber).ToList();
        //SearchByMonth(1);
        lblnameCustomer.Text = nameCustomer.ToUpper() + "'S INFORMATION";
        Notify("");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string from = FromDate.Text;
        string to = ToDate.Text;
        if (from.Equals("") || to.Equals(""))
            return;
        SearchByDay(from, to);
    }

    protected void btnSearchByMonth_Click(object sender, EventArgs e)
    {
        string selectedValue = ddMonth.SelectedValue;
        SearchByMonth(int.Parse(selectedValue));
    }

    protected void ddMonth_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedValue = ddMonth.SelectedValue;
        SearchByMonth(int.Parse(selectedValue));
    }
    #endregion

    #region Method
    private void SearchByMonth(int month)
    {
        DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month - (month - 1), 1);
        List<ChiTietSuDung> listMonthLastest = listDetail.Where(x => x.TGBD >= firstDayOfMonth && x.TGKT <= DateTime.Now && x.IDSIM == idPhoneNumber).OrderByDescending(x=>x.TGBD).ToList();
        if (listMonthLastest.Count == 0) Notify("Have no item found");
        gvThongTinSuDung.DataSource = listMonthLastest;
        gvThongTinSuDung.DataBind();
        float totalMinutes = 0;
        decimal totalPrice = 0;
        foreach (ChiTietSuDung item in listMonthLastest)
        {
            totalMinutes += item.SoPhutSD.GetValueOrDefault();
            totalPrice += item.PhiCuocGoi.GetValueOrDefault();
        }
        this.totalMinutes.Text = totalMinutes.ToString() + " minutes";
        this.totalPrice.Text = totalPrice.ToString() + "Đ";
    }
    private void SearchByDay(string from, string to)
    {
        DateTime fromDate = DateTime.ParseExact(ChangeFormat(from), "dd/MM/yyyy", null);
        DateTime toDate = DateTime.ParseExact(ChangeFormat(to), "dd/MM/yyyy", null);
        List<ChiTietSuDung> listBySearch = listDetail.Where(x => x.TGBD >= fromDate && x.TGKT <= toDate && x.IDSIM.Equals(idPhoneNumber)).OrderByDescending(x => x.TGBD).ToList();
        if (listBySearch.Count == 0) Notify("Have no item found");
        gvThongTinSuDung.DataSource = listBySearch;
        gvThongTinSuDung.DataBind();
        float totalMinutes = 0;
        decimal totalPrice = 0;
        foreach (ChiTietSuDung item in listBySearch)
        {
            totalMinutes += item.SoPhutSD.GetValueOrDefault();
            totalPrice += item.PhiCuocGoi.GetValueOrDefault();
        }
        this.totalMinutes.Text = totalMinutes.ToString() + "minutes";
        this.totalPrice.Text = totalPrice.ToString() + "Đ";
    }
    private string ChangeFormat(string input)
    {
        if(!input.Equals(""))
        {
            string[] strs = input.Split('/');
            if(int.Parse(strs[0]) < 10)
            {
                strs[0] = "0" + strs[0];
            }
            if (int.Parse(strs[1]) < 10)
            {
                strs[1] = "0" + strs[1];
            }
            return strs[0] + "/" + strs[1] + "/" + strs[2];
        }
        return "";
    }
    private void Notify(string notify)
    {
        lblNotify.Text = notify;
    }

    #endregion
    
}