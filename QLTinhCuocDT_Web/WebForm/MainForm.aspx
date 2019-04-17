<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainForm.aspx.cs" Inherits="testCalender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Assets/css/pikaday.css" rel="stylesheet" />
    <link href="Assets/css/site.css" rel="stylesheet" />
    <link href="Assets/css/theme.css" rel="stylesheet" />
    <link href="Assets/css/triangle.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Assets/js/pikaday.js"></script>
</head>
<body>
    <form style="padding-top:50px; " id="form1" runat="server">
        <div class="container">
            <div class="list-group">
                <div style="border-color:darkred; background-color:peachpuff;" class="list-group-item">
                    <div style="border-color:DarkRed;" class="panel panel-primary">
                        <div style="background-color:PeachPuff; border-bottom-color:DarkRed;" class="panel-heading text-center">
                            <h3 style="color:darkred; font-family:'iCielBC Cubano Normal';font-size:35px;"><asp:Label runat="server" ID="lblnameCustomer"></asp:Label></h3>
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-xs-5">
                                    <asp:TextBox BorderColor="DarkRed" ID="FromDate" CssClass="form-control" placeholder="From date" runat="server"></asp:TextBox>
                                    <script type="text/javascript">
                                        var pickerFrom = new Pikaday(
                                            {
                                                field: document.getElementById('FromDate'),
                                                firstDay: 1,
                                                format: 'D/M/YYYY',
                                                minDate: new Date('2000-01-01'),
                                                maxDate: new Date('2020-12-31'),
                                                yearRange: [2000, 2020],
                                                numberOfMonths: 1,
                                                theme: 'dark-theme',
                                                toString(date, format) {
                                                    // you should do formatting based on the passed format,
                                                    // but we will just return 'D/M/YYYY' for simplicity
                                                    const day = date.getDate();
                                                    const month = date.getMonth() + 1;
                                                    const year = date.getFullYear();
                                                    return `${day}/${month}/${year}`;
                                                },
                                                parse(dateString, format) {
                                                    // dateString is the result of `toString` method
                                                    const parts = dateString.split('/');
                                                    const day = parseInt(parts[0], 10);
                                                    const month = parseInt(parts[1], 10) - 1;
                                                    const year = parseInt(parts[2], 10);
                                                    return new Date(year, month, day);
                                                }
                                            });
                                    </script>
                                </div>
                                <div class="col-xs-5">
                                    <asp:TextBox BorderColor="DarkRed" ID="ToDate" CssClass="form-control" placeholder="To date" runat="server"></asp:TextBox>
                                    <script type="text/javascript">
                                        var pickerTo = new Pikaday(
                                            {
                                                field: document.getElementById('ToDate'),
                                                firstDay: 1,
                                                format: 'D/M/YYYY',
                                                minDate: new Date('2000-01-01'),
                                                maxDate: new Date('2020-12-31'),
                                                yearRange: [2000, 2020],
                                                numberOfMonths: 1,
                                                theme: 'dark-theme',
                                                toString(date, format) {
                                                    // you should do formatting based on the passed format,
                                                    // but we will just return 'D/M/YYYY' for simplicity
                                                    const day = date.getDate();
                                                    const month = date.getMonth() + 1;
                                                    const year = date.getFullYear();
                                                    return `${day}/${month}/${year}`;
                                                },
                                                parse(dateString, format) {
                                                    // dateString is the result of `toString` method
                                                    const parts = dateString.split('/');
                                                    const day = parseInt(parts[0], 10);
                                                    const month = parseInt(parts[1], 10) - 1;
                                                    const year = parseInt(parts[2], 10);
                                                    return new Date(year, month, day);
                                                }
                                            });
                                    </script>
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button BorderColor="peachpuff" BackColor="PeachPuff" ForeColor="DarkRed" CssClass="btn btn-primary" runat="server" ID="Button1" OnClick="btnSearch_Click" Text="Search" Font-Size="Large" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-10">
                                    <div class="input-group">
                                        <span BorderColor="DarkRed" class="input-group-addon" style="font-size: medium; font-family:'iCielBC Cubano Normal'; color:darkred; background-color:peachpuff; border-color:darkred">Month:     </span>
                                        <asp:DropDownList BorderColor="DarkRed" runat="server" CssClass="dropdown form-control" ID="ddMonth" OnSelectedIndexChanged="ddMonth_SelectedIndexChanged">
                                            <asp:ListItem Text="1 tháng gần đây nhất" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="3 tháng gần đây nhất" Value="3"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-xs-2">
                                    <asp:Button BorderColor="peachpuff" BackColor="PeachPuff" ForeColor="DarkRed" CssClass="btn btn-primary" runat="server" ID="btnSearchByMonth" OnClick="btnSearchByMonth_Click" Text="Search" Font-Size="Large"/>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="text-center text-danger">
                            <asp:Label runat="server" ID="lblNotify" Text=""></asp:Label>
                        </div>
                    </div>
                    <asp:GridView CssClass="table table-bordered" ID="gvThongTinSuDung" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="TGBD" HeaderText="Time Start" />
                            <asp:BoundField DataField="TGKT" HeaderText="Time End" />
                            <asp:BoundField DataField="SoPhutSD" HeaderText="Minutes" />
                            <asp:BoundField DataField="PhiCuocGoi" HeaderText="Price" />
                        </Columns>
                    </asp:GridView>
                </div>
                <div style="border-color:darkred; background-color:peachpuff;" class="list-group-item">
                    <div style="color:darkred; border-color:darkred;" class="panel panel-default">
                        <div class="panel-body">
                            <div  class="row align-items-center h-100">
                                <div class="col-md-8">
                                    <h4 style=" font-family:'iCielBC Cubano Normal';">Total cost:</h4>
                                </div>
                                <div class="col-md-2">
                                    <span class="text-center">
                                        <asp:Label runat="server" ID="totalMinutes"></asp:Label>
                                    </span>
                                </div>
                                <div class="col-md-2">
                                    <span class="text-center">
                                        <asp:Label runat="server" ID="totalPrice"></asp:Label>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
