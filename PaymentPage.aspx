<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PaymentPage.aspx.cs" Inherits="PaymentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!DOCTYPE html>
<html>
    <head>
        <title>
            Payment Gateway
        </title>
        <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
        <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
        <link href="css/font-awesome.css" rel="stylesheet" />
        <link rel="stylesheet" href="css/jstarbox.css" type="text/css" media="screen" charset="utf-8" />
    </head>
    <body>
        <!--<form id="form1" runat="server">-->
            <div class="cart">
                <div class="container">
                    <div class="col-md-8 cart-items">
                        <div class="min-agileites" style="width; 100%;">
                            <div class="form-agileites form1">
                                <h3>
                                    CHECKOUT NOW
                                </h3>
                                <div class="key">
                                    <asp:TextBox ID="txtOrder" runat="server" placeholder="ORDER ID"></asp:TextBox>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="key">
                                    <asp:TextBox ID="txtName" runat="server" placeholder="NAME"></asp:TextBox>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="key">
                                    <asp:TextBox ID="txtEmail" runat="server" placeholder="EMAIL ID"></asp:TextBox>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="key">
                                    <asp:TextBox ID="txtMobileNumber" runat="server" placeholder="CONTACT NO."></asp:TextBox>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="key">
                                    <asp:TextBox ID="txtAmount" runat="server" placeholder="ENTER AMOUNT"></asp:TextBox>
                                    <div class="clearfix"></div>
                                </div>
                                <asp:Button ID="BtnCheckout" OnClick="btnCheckout_Click" runat="server" Text="CHECKOUT" /><br /><br />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        <!--</form>-->
    </body>
</html>

</asp:Content>





