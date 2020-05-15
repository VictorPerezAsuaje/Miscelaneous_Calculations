<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Miscelaneous_Calculations.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Miscelaneous Calculations</h1>
            <h3>Fibonacci sequence</h3>
            <asp:Label ID="FiboNumbers" runat="server"></asp:Label>
            <br />
            <p>Elige el número de cifras a mostrar (0 - 50):</p>
            <asp:TextBox ID="CifrasFibo" runat="server" Width="73px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnCalcFibo" runat="server" OnClick="BtnCalcFibo_Click" Text="Calculate" />
            <br />
            <h3>Is it Fibonacci?</h3>
            <asp:TextBox ID="TxtNumberIsFibo" runat="server" Width="69px"></asp:TextBox>
&nbsp;
            <asp:Label ID="AnswerIsFibo" runat="server"></asp:Label>
            <br />
            <br />

            <asp:Button ID="BtnIsFibo" runat="server" OnClick="BtnIsFibo_Click" Text="Is it?" />

            <br />
            <h3>Find the N number of Pi</h3>
            <asp:Label ID="PiLbl" runat="server" Text="3,1415..."></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TxtBoxAllResults" runat="server" Height="81px" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="861px"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TxtNPi" runat="server" Width="68px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnNOfPi" runat="server" OnClick="BtnNOfPi_Click" Text="Search" />
&nbsp;&nbsp;
            <asp:Button ID="BtnNextIndexPi" runat="server" OnClick="BtnNextIndexPi_Click" Text="All the places where it appears" Visible="False" />
&nbsp;&nbsp;
            <asp:Button ID="BtnClear" runat="server" OnClick="BtnClear_Click" Text="Clear TextBox" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
