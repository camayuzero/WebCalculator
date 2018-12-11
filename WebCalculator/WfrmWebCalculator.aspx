<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfrmWebCalculator.aspx.cs" Inherits="WebCalculator.WfrmWebCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 18%;
            border:outset;
            background-color:lightblue;
        }
        .auto-style2 {
            font-size: xx-large;
            color: #0000FF;
            text-align: center;
        }
        .auto-style3 {
            height: 20px;
            text-align: center;
        }
        .auto-style4 {
            text-align: center;
        }
        .textBox{
            text-align: center;            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" >
                <tr>
                    <td class="auto-style2"><strong>WebCalculator</strong></td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="textBox">
                        <asp:TextBox ID="txtDisplay" runat="server" Font-Size="Large" Height="37px" ReadOnly="True" Rows="3" TextMode="MultiLine" style="text-align:right" resize="none" Width="190px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btnCancel" runat="server" Font-Size="Large" Text="C" Width="88px" Height="30px" OnClick="btnCancel_Click"/>
                        &nbsp;<asp:Button ID="btnBackspace" runat="server" Font-Size="Large" Text="&lt;--" Width="88px" Height="30px" OnClick="btnBackspace_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="btn7" runat="server" Font-Size="Large" Text="7" Width="40px" Height="30px" OnClick="btn7_Click" />
                        &nbsp;<asp:Button ID="btn8" runat="server" Font-Size="Large" Text="8" Width="40px" Height="30px" OnClick="btn8_Click"/>
                        &nbsp;<asp:Button ID="btn9" runat="server" Font-Size="Large" Text="9" Width="40px" Height="30px" OnClick="btn9_Click"/>
                        &nbsp;<asp:Button ID="btnDivision" runat="server" Font-Size="Large" Text="/" Width="40px" Height="30px" OnClick="btnDivision_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btn4" runat="server" Font-Size="Large" Text="4" Width="40px" Height="30px" OnClick="btn4_Click"/>
                        &nbsp;<asp:Button ID="btn5" runat="server" Font-Size="Large" Text="5" Width="40px" Height="30px" OnClick="btn5_Click"/>
                        &nbsp;<asp:Button ID="btn6" runat="server" Font-Size="Large" Text="6" Width="40px" Height="30px" OnClick="btn6_Click"/>
                        &nbsp;<asp:Button ID="btnMultiplication" runat="server" Font-Size="Large" Text="*" Width="40px" Height="30px" OnClick="btnMultiplication_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btn1" runat="server" Font-Size="Large" Text="1" Width="40px" Height="30px" OnClick="btn1_Click"/>
                        &nbsp;<asp:Button ID="btn2" runat="server" Font-Size="Large" Text="2" Width="40px" Height="30px" OnClick="btn2_Click"/>
                        &nbsp;<asp:Button ID="btn3" runat="server" Font-Size="Large" Text="3" Width="40px" Height="30px" OnClick="btn3_Click"/>
                        &nbsp;<asp:Button ID="btnSubtraction" runat="server" Font-Size="Large" Text="-" Width="40px" Height="30px" OnClick="btnSubtraction_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="btn0" runat="server" Font-Size="Large" Text="0" Width="40px" Height="30px" OnClick="btn0_Click"/>
                        &nbsp;<asp:Button ID="btnDot" runat="server" Font-Size="Large" Text="." Width="40px" Height="30px" OnClick="btnDot_Click"/>
                        &nbsp;<asp:Button ID="btnAmount" runat="server" Font-Size="Large" Text="=" Width="40px" Height="30px" OnClick="btnAmount_Click"/>
                        &nbsp;<asp:Button ID="btnAddition" runat="server" Font-Size="Large" Text="+" Width="40px" Height="30px" OnClick="btnAddition_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
