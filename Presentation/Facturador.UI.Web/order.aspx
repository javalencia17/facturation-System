<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="Facturador.UI.Web.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Order</h1>
    <div>
    
        <asp:Label ID="label" runat="server" Text="Customer"></asp:Label>
                &nbsp;&nbsp;&nbsp;
    
        <asp:DropDownList ID="ddlCustomer" runat="server" Height="33px" Width="213px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Prouct"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:DropDownList ID="ddlProduct" runat="server" Height="33px" Width="213px">
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text="Cant"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtCant" runat="server"></asp:TextBox>
        <span id="btn">&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="btnAdd" runat="server"  Text="Add" OnClick="btnAdd_Click1" style="height: 26px" />
        <br />
        <br />
        <br />
        <asp:GridView ID="gvOrderDetail" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="10" CellSpacing="3" ForeColor="Black" OnSelectedIndexChanged="gvOrderDetail_SelectedIndexChanged" ShowFooter="True">
            <Columns>
                <asp:TemplateField HeaderText="#">
                    <FooterTemplate>
                        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <span id="btn">
                        <asp:Label ID="lblIDOrderDetail" runat="server" Text='<%# Eval("idOrderDetail") %>'></asp:Label>
                        </span>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:Label ID="idLblQuantity" runat="server" Text='<%# Eval("quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <span id="btn">
                        <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                        </span>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Subtotal">
                    <FooterTemplate>
                        <asp:Button ID="btnCreateOrder" runat="server" OnClick="btnCreateOrder_Click" Text="Create Order" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <span id="btn">
                        <asp:Label ID="lblSubtotal" runat="server" Text='<%# Eval("subtotal") %>'></asp:Label>
                        </span>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
        </span>
        <br />
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    
</asp:Content>
