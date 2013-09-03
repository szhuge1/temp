<%@ Page Title="Home Page" Language="C#"  CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" AutoEventWireup="true" %>

<html>

<body>
    <form id="Form2" runat="server">
        <table border="1">

        <tr>
        <td>Campaign Title<i>*</i></td>
        <td>
            <asp:TextBox ID="txtTitle" runat="server" MaxLength="32" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv" runat="server" ControlToValidate="txtTitle" Display="None" ErrorMessage="Campaign title is required." CssClass="error" ValidationGroup="vgover" />
        </td>
        <td>Weekdays<i>*</i></td>
        <td colspan="2">
            <asp:CheckBox ID="chkM" runat="server" Text="M" OnCheckedChanged="Check_ClickedM" AutoPostBack="true"/>
            <asp:CheckBox ID="chkT" runat="server" Text="T" OnCheckedChanged="Check_ClickedT" AutoPostBack="true"/>
            <asp:CheckBox ID="chkW" runat="server" Text="W" OnCheckedChanged="Check_ClickedW" AutoPostBack="true"/>
            <asp:CheckBox ID="chkTh" runat="server" Text="T" OnCheckedChanged="Check_ClickedTh" AutoPostBack="true" />
            <asp:CheckBox ID="chkF" runat="server" Text="F" OnCheckedChanged="Check_ClickedF" AutoPostBack="true" />
            <asp:CheckBox ID="chkS" runat="server" Text="S" OnCheckedChanged="Check_ClickedS" AutoPostBack="true" /> 
            <asp:CheckBox ID="chkSun" runat="server" Text="S" OnCheckedChanged="Check_ClickedSun" AutoPostBack="true" />

           <%-- <asp:CheckBox ID="chkM" runat="server" Text="M" />
            <asp:CheckBox ID="chkT" runat="server" Text="T" />
            <asp:CheckBox ID="chkW" runat="server" Text="W" />
            <asp:CheckBox ID="chkTh" runat="server" Text="T"  />
            <asp:CheckBox ID="chkF" runat="server" Text="F"  />
            <asp:CheckBox ID="chkS" runat="server" Text="S"  /> 
            <asp:CheckBox ID="chkSun" runat="server" Text="S"  />  --%>
        </td>
    </tr>
    <tr>

        <td>Start Date<i>*</i></td>
        <td>
            <asp:TextBox ID="txtStartDate" runat="server" AutoPostBack="true" />
            <asp:Button ID="btnPopup1" runat="server" Text="." OnClick="btnPopup1_Click" />
            <asp:Panel ID="Panel1" runat="server">
                <asp:Calendar id="startDateCal"  Runat="server" OnSelectionChanged="startDateCal_SelectionChanged" />
            </asp:Panel>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtStartDate" ErrorMessage="Start Date is required." Display="None" ValidationGroup="vgover" />
        </td>

        <td>End Date<i>*</i></td>
        <td>
            <asp:TextBox ID="txtEndDate" runat="server"  AutoPostBack="true"/>
            <asp:Button ID="btnPopup2" runat="server" Text="." OnClick="btnPopup2_Click" />
            <asp:Panel ID="Panel2" runat="server">
                <asp:Calendar id="endDateCal"  Runat="server" OnSelectionChanged="endDateCal_SelectionChanged" />
            </asp:Panel>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEndDate" ErrorMessage="End Date is required." Display="None" ValidationGroup="vgover" />
        </td>
    </tr>
    <tr>
        <td>No of Days<i>*</i></td>
        <td colspan="3">
            <asp:TextBox ID="txtNoofDay" runat="server"  AutoPostBack="true"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNoofDay" Display="None" ErrorMessage="No of Day(s) is required." CssClass="error" ValidationGroup="vgover" />    
        </td>
       <%-- <td><asp:CheckBox ID="chkFlashRptFlag" runat="server" Text="Flash Report Flag" /></td>--%>
    </tr>
        </table>
    </form>  
</body>
</html>
