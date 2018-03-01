<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="orderbooking.aspx.cs" Inherits="WebApplication4.orderbooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
   
    
   
   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  
        Width="69%" CellSpacing="2" CellPadding="8"
        GridLines="None"  >
        <Columns>
          
            <asp:BoundField DataField="p_id" HeaderText="Product_Id" SortExpression="p_id" />
           
            <asp:BoundField DataField="P_name" HeaderText="Product Name" SortExpression="p_name" />
          




             <asp:TemplateField HeaderStyle-Width="20px"  ItemStyle-HorizontalAlign="Center">
                <ItemTemplate >
                    <img width="100" src='../images/tempr/<%#Eval("image")%>' />
                </ItemTemplate>
            </asp:TemplateField>



            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:BoundField DataField="discount" HeaderText="Discount" SortExpression="discount" />
            <asp:BoundField DataField="qty" HeaderText="Qauntity" SortExpression="qauntity" />
        </Columns>
    </asp:GridView>
   <asp:Label ID="Label2" runat="server" Text="Number of Quantity"></asp:Label>
    &nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Contact Number"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Place To Deliver"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Total"></asp:Label>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Get Total" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Order It" OnClick="Button2_Click" />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Show Order History" />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Cancel" />
    <br />
</asp:Content>
