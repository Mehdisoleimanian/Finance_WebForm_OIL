<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Finance_WebForm_OIL._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<header dir="rtl" style="font-size:xx-large;font-family:'B Nazanin'">
    <h2>سیستم حقوق و دستمزد کارکنان</h2>
    <p>&nbsp;</p>
</header>

    <div dir="rtl" style="font-family:'B Nazanin'; width: 1226px;">

        <asp:Label ID="lblName" runat ="server"  Text="نام کارمند : " ></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Width="172px"></asp:TextBox><br/>

         <asp:Label ID="lblPersonCode" runat ="server"  Text="شماره پرسنلی : " ></asp:Label>
        <asp:TextBox ID="txtPersonCode" runat="server"></asp:TextBox><br/>

         <asp:Label ID="lblhourpay" runat ="server"  Text="حقوق ساعتی : " ></asp:Label>
        <asp:TextBox ID="txtHourpay" runat="server"></asp:TextBox>
        <br />
        <br/>

        <asp:Button ID="btnSave" runat="server" Text="ذخیره" OnClick="btnSave_Click" Width="130px" />




    </div>

</asp:Content>
