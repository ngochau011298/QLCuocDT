<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StartForm.aspx.cs" Inherits="StartFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form style="padding-top:50px" id="form1" runat="server">
        <div class="container">
            <div style="border-color:DarkRed;" class="panel panel-primary">
                <div style="background-color:PeachPuff; border-bottom-color:DarkRed;" class="panel-heading text-center">
                    <h3 style="color:darkred; font-family:'iCielBC Cubano Normal';font-size:35px;">NUMBER PHONE</h3>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-xs-11">
                            <div class="input-group">
                                <span style="background-color:peachpuff; border-color:darkred; color:darkred; font-family:'iCielBC Cubano Normal'" class="input-group-addon">Phone Number</span>
                                <asp:TextBox style="border-color:darkred;" CssClass="form-control" runat="server" ID="txtPhoneNumber" placeholder="Input Phone number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-xs-1">
                            <asp:Button runat="server" BorderColor="peachpuff" BackColor="PeachPuff" ForeColor="DarkRed" CssClass="btn btn-primary" OnClick="btnCheckPhoneNumber_Click" ID="btnCheckPhoneNumber" Text="Check" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="text-center text-danger">
                            <asp:Label runat="server" ID="lblNotify" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
