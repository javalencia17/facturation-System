﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="categoria.aspx.cs" Inherits="Facturador.UI.Web.categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Category</h1>
    <asp:GridView ID="gvCategory" runat="server" AutoGenerateColumns="False" CellPadding="10" ForeColor="Black"  ShowFooter="True" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnRowEditing="gvCategory_RowEditing" AllowPaging="True" OnPageIndexChanging="gvCategory_PageIndexChanging" OnRowCancelingEdit="gvCategory_RowCancelingEdit" OnRowDeleting="gvCategory_RowDeleting" OnRowUpdating="gvCategory_RowUpdating" PageSize="7" OnSelectedIndexChanged="gvCategory_SelectedIndexChanged" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="4">
        <Columns>
            <asp:TemplateField HeaderText="Id">
                <EditItemTemplate>
                    <asp:Label ID="lblId" runat="server" Text='<%# Eval("idCategory") %>'></asp:Label>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("idCategory") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <EditItemTemplate>
                    <asp:TextBox ID="txtNameUp" runat="server" Text='<%# Eval("name") %>'></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </FooterTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
</asp:Content>