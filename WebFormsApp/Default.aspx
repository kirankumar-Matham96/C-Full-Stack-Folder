<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="title">This is a sample web form with drag and drop components</h1>
    <p>
        <br />
        <table class="w-100">
            <tr>
                <td class="text-end" style="width: 259px; font-size: x-large"><strong>Enter First Name</strong></td>
                <td><strong>
                    <asp:TextBox ID="firstName" runat="server" CssClass="input" style="font-size: x-large"></asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px; height: 21px"></td>
                <td style="height: 21px"></td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px; font-size: x-large"><strong>Enter Last Name</strong></td>
                <td><strong>
                    <asp:TextBox ID="lastName" runat="server" CssClass="input" style="font-size: x-large"></asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px; font-size: x-large"><strong>Enter Email</strong></td>
                <td><strong>
                    <asp:TextBox ID="email" runat="server" CssClass="input" style="font-size: x-large"></asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px; font-size: x-large"><strong>Enter Password</strong></td>
                <td><strong>
                    <asp:TextBox type="password" ID="password" runat="server" CssClass="input" style="font-size: x-large" AutoCompleteType="Disabled" CausesValidation="True"></asp:TextBox>
                    </strong></td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="text-end" style="width: 259px; height: 38px"></td>
                <td style="height: 38px"><strong>
                    <asp:Button ID="dispBtn" runat="server" BorderStyle="None" CssClass="btn btn-primary" Font-Bold="True" OnClick="dispBtn_Click" style="font-size: x-large" Text="Display" />
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 259px; height: 21px"></td>
                <td style="height: 21px"></td>
            </tr>
            <tr>
                <td style="width: 259px; font-weight: bold; font-size: x-large;" class="text-end">First Name: </td>
                <td><strong>
                    <asp:Label ID="FisrstNameLabel" runat="server" style="font-size: x-large" Text="Label"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 259px; height: 26px" class="text-end"></td>
                <td style="height: 26px"></td>
            </tr>
            <tr>
                <td style="width: 259px; font-size: x-large; text-align: right;"><b>Last Name: </b></td>
                <td>
                    <asp:Label ID="LastNameLabel" runat="server" Font-Bold="True" style="font-size: x-large" Text="Label"></asp:Label>
                    </b></td>
            </tr>
            <tr>
                <td style="width: 259px; font-size: x-large; height: 1px; font-weight: bold;" class="text-end">&nbsp;</td>
                <td style="height: 1px"></b></td>
            </tr>
            <tr>
                <td style="width: 259px; font-size: x-large; text-align: right;"><b>Email: </b></td>
                <td>
                    <asp:Label ID="EmailLabel" runat="server" Font-Bold="True" style="font-size: x-large" Text="Label"></asp:Label>
                    </b></td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Table ID="Table1" runat="server">
                    </asp:Table>
                    <b><span style="font-size: x-large">&nbsp;</span><span style="font-size: xx-large">Calculator</span></b></td>
            </tr>
            <tr>
                <td style="width: 259px; font-size: x-large;">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px; font-size: x-large;"><b>Enter Number1:</b></td>
                <td>
                    <asp:TextBox ID="Num1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 259px; font-size: x-large;">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px; font-size: x-large;"><b>Enter Number2: </b></td>
                <td>
                    <asp:TextBox ID="Num2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px"><strong>
                    <asp:Button ID="AddBtn" runat="server" CssClass="btn btn-info m-3" Font-Bold="True" OnClick="AddBtn_Click" style="font-size: x-large" Text="Add" />
                    <asp:Button ID="SubBtn" runat="server" CssClass="btn btn-info m-3" Font-Bold="True" OnClick="SubBtn_Click" style="font-size: x-large" Text="Sub" />
                    <asp:Button ID="MulBtn" runat="server" CssClass="btn btn-info m-3" Font-Bold="True" OnClick="MulBtn_Click" style="font-size: x-large" Text="Mul" />
                    <asp:Button ID="Div" runat="server" CssClass="btn btn-info m-3" Font-Bold="True" OnClick="Div_Click" style="font-size: x-large" Text="Div" />
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px; height: 21px;"></td>
                <td style="height: 21px"></td>
            </tr>
            <tr>
                <td style="height: 21px;" colspan="2">
                    <asp:Label ID="Result" runat="server" style="font-weight: 700; font-size: x-large" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px">Skills: </td>
                <td>
                    <asp:CheckBox ID="Java" runat="server" OnCheckedChanged="Java_CheckedChanged" Text="Java" />
&nbsp;
                    <asp:CheckBox ID="Dotnet" runat="server" OnCheckedChanged="Dotnet_CheckedChanged" Text="DotNet" />
&nbsp;
                    <asp:CheckBox ID="Javascript" runat="server" OnCheckedChanged="Javascript_CheckedChanged" Text="JavaScript" />
&nbsp;
                    <asp:CheckBox ID="Python" runat="server" OnCheckedChanged="Python_CheckedChanged" Text="Python" />
                </td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>
                    <asp:Button ID="SkillsBtn" runat="server" CssClass="btn btn-info m-3" Font-Bold="True" OnClick="SkillsBtn_Click" Text="Display Skills" />
                </td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px; height: 19px;">
                    <asp:Label ID="SkillsLabel" runat="server" style="font-weight: 700; font-size: x-large" Text="Label"></asp:Label>
                </td>
                <td style="height: 19px"></td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px; height: 21px;"></td>
                <td style="height: 21px"></td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 259px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>



</asp:Content>
